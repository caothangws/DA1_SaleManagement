using SaleManagement.Model;
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
    public partial class frmDangNhap : Form
    {
        ModelSale context = new ModelSale();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTenTK.Text = Properties.Settings.Default.TaiKhoan;
            txtMatKhau.Text = Properties.Settings.Default.MatKhau;
            if (Properties.Settings.Default.TaiKhoan != "")
            {
                chkLuu.Checked = true;
            }
        }

        private void chkLuu_CheckedChanged(object sender, EventArgs e)
        {
            if (txtTenTK.Text != "" && txtMatKhau.Text != "")
            {
                if (chkLuu.Checked == true)
                {
                    string email = txtTenTK.Text;
                    string mk = txtMatKhau.Text;
                    Properties.Settings.Default.TaiKhoan = email;
                    Properties.Settings.Default.MatKhau = mk;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Reset();
                }
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tk = txtTenTK.Text.Trim();
            string mk = txtMatKhau.Text.Trim();
            try
            {
                var user = context.USERS.FirstOrDefault(r => r.TAIKHOAN == tk && r.MATKHAU == mk);

                if (user != null)
                {
                    int quyen = int.Parse(user.QUYEN.ToString());
                    frmMain _main = new frmMain(quyen);
                    _main.kt = quyen.ToString();

                    MessageBox.Show("Đăng nhập thành công.");
                    this.Hide();
                    _main.Show();

                    if (chkLuu.Checked)
                    {
                        Properties.Settings.Default.TaiKhoan = tk;
                    }
                    Properties.Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("Sai tai khoan hoặc mật khẩu");
                    txtTenTK.Text = "";
                    txtMatKhau.Text = "";
                }
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
