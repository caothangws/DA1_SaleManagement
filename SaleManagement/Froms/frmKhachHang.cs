using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaleManagement.Model;

namespace SaleManagement.Froms
{
    public partial class frmKhachHang : Form
    {
        ModelSale db = new ModelSale();
        private bool ThemDL;
        private string makh = "";
        private int maNV;
        public frmKhachHang(int manv)
        {
            InitializeComponent();
            maNV = manv;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            setValue();
            disable(false);
            loadData();
            btnTaoHD.Enabled = false;
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
            List<KHACHHANG> kh = new List<KHACHHANG>();
            kh = db.KHACHHANG.ToList();
            dtgvKhachHang.AutoGenerateColumns = false;
            dtgvKhachHang.DataSource = kh;  
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
                    KHACHHANG kh = db.KHACHHANG.Find(makh);
                    if (kh != null)
                    {
                        db.KHACHHANG.Remove(kh);
                        db.SaveChanges();
                        MessageBox.Show("Xoa thanh cong");
                    }
                    else
                    {
                        MessageBox.Show("Xoa that bai");
                    }
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
            string gt ="";
            if (radNam.Checked == true)
                gt = "Nam";
            else if (radNu.Checked == true)
                gt = "Nữ";
            if (ktDuLieu())
            {
                try
                {
                    if (ThemDL == true)
                    {
                        KHACHHANG kh = new KHACHHANG
                        {
                            TENKH = txtTenKH.Text,
                            SDT = txtSDT.Text,
                            DIACHI = txtDiaChi.Text,
                            GIOITINH = gt,
                        };
                        db.KHACHHANG.Add(kh);
                        db.SaveChanges();
                        MessageBox.Show("Them thanh cong");
                    }
                    else
                    {
                        KHACHHANG kh = db.KHACHHANG.Find(int.Parse(makh));

                        if (kh != null)
                        {
                            kh.TENKH = txtTenKH.Text;
                            kh.SDT = txtSDT.Text;
                            kh.DIACHI = txtDiaChi.Text;
                            kh.GIOITINH = gt;
                            db.SaveChanges();
                            MessageBox.Show("Cap nhat thanh cong");
                        }
                        else
                        {
                            MessageBox.Show("Cap nhat that bai");
                        }
                    }
                    frmKhachHang_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Loi");
                    return;
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
                    btnTaoHD.Enabled = true;
                    btnThem.Enabled = false;
                    makh = dtgvKhachHang.Rows[e.RowIndex].Cells["MAKH1"].Value.ToString();
                    txtTenKH.Text = dtgvKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtSDT.Text = dtgvKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtDiaChi.Text = dtgvKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string gioitinh = dtgvKhachHang.Rows[e.RowIndex].Cells[4].Value.ToString();
                    if (gioitinh == "Nam")
                    {
                        radNam.Checked = true;
                    }
                    else if (gioitinh == "Nữ")
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

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            frmTaoHD taohd = new frmTaoHD(int.Parse(makh),maNV);
            taohd.Show();
        }
    }
}
