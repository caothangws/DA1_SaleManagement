using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement.Froms
{
    public partial class frmNhanVien : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DA1_SaleManagement;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adp;
        DataTable dt;
        private bool ThemDL;
        private string manv = "";
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            setValue();
            disable(false);
            loadData();
        }

        private void setValue()
        {
            txtTenNV.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
        }

        private void disable(bool gt)
        {
            txtTenNV.Enabled = gt;
            txtSDT.Enabled = gt;
            txtEmail.Enabled = gt;
            txtDiaChi.Enabled = gt;

            btnLuu.Enabled = gt;
            btnThem.Enabled = !gt;
            btnCapNhat.Enabled = !gt;
            btnXoa.Enabled = !gt;
        }

        private void loadData()
        {
            string sql = "SELECT * FROM NHANVIEN";
            adp = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            adp.Fill(dt);
            dtgvNhanVien.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            setValue();
            disable(true);
            ThemDL = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            disable(true);
            ThemDL = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTenNV.Text))
                {
                    MessageBox.Show("Vui long chon nhan vien can xoa");
                    return;
                }
                else
                {
                    conn.Open();
                    string sql = "DELETE FROM NHANVIEN WHERE MANV = '" + manv + "'";
                    cmd = new SqlCommand(sql, conn);
                    int kq = cmd.ExecuteNonQuery();
                    MessageBox.Show(kq > 0 ? "Xoa thanh cong" : "Xoa that bai");
                }
                frmNhanVien_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Loi");
                return;
            }
        }

        private bool ktDuLieu()
        {
            if (string.IsNullOrEmpty(txtTenNV.Text))
            {
                MessageBox.Show("Vui long nhap ten");
                txtTenNV.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Vui long nhap So dien thoai");
                txtSDT.Focus();
                return false;
            }
            else if (int.TryParse(txtSDT.Text, out int i) == false)
            {
                MessageBox.Show("So dien thoai phai la so");
                txtSDT.Focus();
                return false;
            }
            else if (txtSDT.TextLength < 10)
            {
                MessageBox.Show("So dien thoai toi da 10 so");
                txtSDT.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Vui long nhap email");
                txtEmail.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Vui long dia chi ");
                txtDiaChi.Focus();
                return false;
            }
            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (ktDuLieu())
                {
                    if (ThemDL == true)
                    {
                        string sql = "INSERT INTO NHANVIEN(TENNV,SDT,EMAIL,NGAYSINH,DIACHI) VALUES(@TENNV,@SDT,@EMAIL,@NGAYSINH,@DIACHI)";
                        cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@TENNV", txtTenNV.Text);
                        cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                        cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@NGAYSINH", dtpkNgaySinh.Value);
                        cmd.Parameters.AddWithValue("@DIACHI", txtDiaChi.Text);

                        int kq = cmd.ExecuteNonQuery();
                        MessageBox.Show(kq > 0 ? "Them thanh cong" : "Them that bai");
                    }
                    else
                    {
                        string sql = "UPDATE NHANVIEN SET TENNV = @TENNV,SDT = @SDT,EMAIL = @EMAIL,NGAYSINH = @NGAYSINH,DIACHI = @DIACHI WHERE MANV = @MANV ";
                        cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@TENNV", txtTenNV.Text);
                        cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                        cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@NGAYSINH", dtpkNgaySinh.Value);
                        cmd.Parameters.AddWithValue("@DIACHI", txtDiaChi.Text);
                        cmd.Parameters.AddWithValue("@MANV", manv);

                        int kq = cmd.ExecuteNonQuery();
                        MessageBox.Show(kq > 0 ? "Cap nhat thanh cong" : "Cap nhat that bai");

                    }
                    frmNhanVien_Load(sender, e);

                }

            }
            catch
            {
                MessageBox.Show("Loi");
                return;
            }
            finally
            {
                conn.Close();
            }

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }

        private void dtgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    manv = dtgvNhanVien.Rows[e.RowIndex].Cells["MANV1"].Value.ToString();
                    txtTenNV.Text = dtgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtSDT.Text = dtgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtEmail.Text = dtgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                    dtpkNgaySinh.Text = dtgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtDiaChi.Text = dtgvNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Loi");

            }
        }
    }
}
