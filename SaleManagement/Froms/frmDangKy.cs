using SaleManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement.Froms
{
    public partial class frmDangKy : Form
    {
        ModelSale context = new ModelSale();

        public frmDangKy()
        {
            InitializeComponent();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap dn = new frmDangNhap();
            dn.Show();

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string tk = txtTenTK.Text.ToLower();
            string mk = txtMatKhau.Text;
            int quyen = 0;
            if (string.IsNullOrEmpty(txtTenNV.Text))
            {
                MessageBox.Show("Vui long nhap ten cua ban");
                return;
            }
            else if (string.IsNullOrEmpty(txtTenTK.Text))
            {
                MessageBox.Show("Vui long nhap tai khoan cua ban");
                return;
            }
            else if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui long nhap matkhau cua ban");
                return;
            }
            else
            {
                var existingUser = context.USERS.FirstOrDefault(u => u.TAIKHOAN == tk);
                if (existingUser != null)
                {
                    MessageBox.Show("Tài khoản này đã tồn tại. Vui lòng chọn tên khác.");
                    txtTenTK.Text = "";
                    return;
                }

                NHANVIEN nv = new NHANVIEN
                {
                    TENNV = txtTenNV.Text,
                    NGAYSINH = DateTime.Now,
                    VAITRO = quyen,
                };
                context.NHANVIEN.Add(nv);
                context.SaveChanges();

                USERS user = new USERS
                {
                    TAIKHOAN = tk,
                    MATKHAU = mk,
                    QUYEN = quyen,
                    MANV = nv.MANV,

                };
                context.USERS.Add(user);
                context.SaveChanges();
                MessageBox.Show("Tao tai khoan thanh cong");
                this.Close();
                frmDangNhap dn = new frmDangNhap();
                dn.Show();
            }
        }

       
    }
}
