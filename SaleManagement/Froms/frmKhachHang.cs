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
    public partial class frmKhachHang : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DA1_SaleManagement;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adp;
        DataTable dt;
        private bool ThemDL;
        private string makh = "";
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            setValue();
            disable(false);
            loadData();
        }
        private void setValue()
        {
            txtTenKH.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
        }

        private void disable(bool gt)
        {
            txtTenKH.Enabled = gt;
            txtSDT.Enabled = gt;
            txtDiaChi.Enabled = gt;

            btnLuu.Enabled = gt;
            btnThem.Enabled = !gt;
            btnCapNhat.Enabled = !gt;
            btnXoa.Enabled = !gt;
        }

        private void loadData()
        {
            string sql = "SELECT * FROM KHACHHANG";
            adp = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            adp.Fill(dt);
            dtgvKhachHang.DataSource = dt;
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
                if (string.IsNullOrEmpty(txtTenKH.Text))
                {
                    MessageBox.Show("Vui long chon khach hang can xoa");
                    return;
                }
                else
                {
                    conn.Open();
                    string sql = "DELETE FROM KHACHHANG WHERE MAKH = '" + makh + "'";
                    cmd = new SqlCommand(sql, conn);
                    int kq = cmd.ExecuteNonQuery();
                    MessageBox.Show(kq > 0 ? "Xoa thanh cong" : "Xoa that bai");
                }
                frmKhachHang_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Loi");
                return;
            }
        }

        private bool ktDuLieu()
        {
            if (string.IsNullOrEmpty(txtTenKH.Text))
            {
                MessageBox.Show("Vui long nhap ten");
                txtTenKH.Focus();
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
            else if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Vui long dia chi ");
                txtDiaChi.Focus();
                return false;
            }
            else if (radNam.Checked == false && radNu.Checked == false)
            {
                MessageBox.Show("Vui long chon gioi tinh ");
                return false;
            }
            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int gt = 0;
            if (radNam.Checked == true)
                gt = 0;
            else if (radNu.Checked == true)
                gt = 1;
            if (ktDuLieu())
            {
                try
                {
                    conn.Open();
                    if (ThemDL == true)
                    {
                        string sql = "INSERT INTO KHACHHANG(TENKH,SDT,DIACHI,GIOITINH) VALUES(@TENKH,@SDT,@DIACHI,@GIOITINH)";
                        cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@TENKH", txtTenKH.Text);
                        cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                        cmd.Parameters.AddWithValue("@DIACHI", txtDiaChi.Text);
                        cmd.Parameters.AddWithValue("@GIOITINH", gt);

                        int kq = cmd.ExecuteNonQuery();
                        MessageBox.Show(kq > 0 ? "Them thanh cong" : "Them that bai");
                    }
                    else
                    {
                        string sql = "UPDATE KHACHHANG SET TENKH = @TENKH ,SDT = @SDT,DIACHI = @DIACHI, GIOITINH = @GIOITINH WHERE MAKH = @MAKH ";
                        cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@TENKH", txtTenKH.Text);
                        cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                        cmd.Parameters.AddWithValue("@DIACHI", txtDiaChi.Text);
                        cmd.Parameters.AddWithValue("@GIOITINH", gt);
                        cmd.Parameters.AddWithValue("@MAKH", makh);

                        int kq = cmd.ExecuteNonQuery();
                        MessageBox.Show(kq > 0 ? "Cap nhat thanh cong" : "Cap nhat that bai");
                    }
                    frmKhachHang_Load(sender, e);
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
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
        }

        private void dtgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    btnThem.Enabled = false;
                    makh = dtgvKhachHang.Rows[e.RowIndex].Cells["MAKH1"].Value.ToString();
                    txtTenKH.Text = dtgvKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtSDT.Text = dtgvKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtDiaChi.Text = dtgvKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string gioitinh = dtgvKhachHang.Rows[e.RowIndex].Cells[4].Value.ToString();
                    if (gioitinh == "0")
                    {
                        radNam.Checked = true;
                    }
                    else if (gioitinh == "1")
                    {
                        radNu.Checked = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Loi");

            }
        }
    }
}
