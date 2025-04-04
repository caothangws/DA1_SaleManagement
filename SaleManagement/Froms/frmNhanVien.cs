using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaleManagement.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SaleManagement.Froms
{
    public partial class frmNhanVien : Form
    {
        ModelSale context = new ModelSale();
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
            List<NHANVIEN> nv = new List<NHANVIEN>();
            nv = context.NHANVIEN.ToList();
            dtgvNhanVien.AutoGenerateColumns = false;
            dtgvNhanVien.DataSource = nv;
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
                    NHANVIEN nv = context.NHANVIEN.Find(int.Parse(manv));
                    if (nv != null)
                    {
                        context.NHANVIEN.Remove(nv);
                        context.SaveChanges();
                        MessageBox.Show("Xoa thanh cong");
                    }
                    else
                    {
                        MessageBox.Show("Xoa that bai");
                    }
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
            int vt = 0;
            try
            {
                if (ktDuLieu())
                {
                    if (ThemDL == true)
                    {
                        NHANVIEN nv = new NHANVIEN
                        {
                            TENNV = txtTenNV.Text,
                            SDT = txtSDT.Text,
                            EMAIL = txtEmail.Text,
                            NGAYSINH = DateTime.Parse( dtpkNgaySinh.Value.ToString()),
                            DIACHI = txtDiaChi.Text,
                            VAITRO = vt
                        };
                        context.NHANVIEN.Add(nv);
                        context.SaveChanges();
                        MessageBox.Show("Them thanh cong");
                    }
                    else
                    {
                        NHANVIEN nv = context.NHANVIEN.Find(int.Parse(manv));

                        if (nv != null)
                        {
                            nv.TENNV = txtTenNV.Text;
                            nv.SDT = txtSDT.Text;
                            nv.EMAIL = txtEmail.Text;
                            nv.NGAYSINH = dtpkNgaySinh.Value;
                            nv.DIACHI = txtDiaChi.Text;
                            context.SaveChanges();
                            MessageBox.Show("Cap nhat thanh cong");
                        }
                        else
                        {
                            MessageBox.Show("Cap nhat that bai");
                        }

                    }
                    frmNhanVien_Load(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("Loi");
                return;
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
