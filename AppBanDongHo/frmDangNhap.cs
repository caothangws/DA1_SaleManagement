<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppBanDongHo
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public int kt;
        SqlConnection ketNoi;
        string chuoiKN = global::AppBanDongHo.Properties.Settings.Default.DoAn1_BanDongHoConnectionString;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            /*if (MessageBox.Show("Bạn chắc chắn muốn thoát", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            } */
            this.Close();
        }

        private void chkShowMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowMK.Checked == true)
            {
                txtMatKhau.PasswordChar = (char)0;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
             
            ketNoi = new SqlConnection(chuoiKN);
            string taiKhoan, matKhau;
            taiKhoan = txtTaiKhoan.Text;
            matKhau = txtMatKhau.Text;


            string sql = "select * from Users where TaiKhoan= '" + txtTaiKhoan.Text.ToString() + "' AND MatKhau = '" + txtMatKhau.Text.ToString() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, ketNoi);
            DataTable tb = new DataTable();

            adapter.Fill(tb);
            if (tb != null && tb.Rows.Count > 0)
            {

                if (tb != null && tb.Rows.Count > 0)
                {
                    frmMain m = new frmMain();
                    foreach (DataRow dr in tb.Rows)
                    {
                        m.kt = int.Parse(dr["Quyen"].ToString());
                    }
                    MessageBox.Show("Đăng nhập thành công.", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    string updateHD = string.Format("update Users set HD = 1 where TaiKhoan = '{0}'", taiKhoan.ToUpper().Trim());
                    SqlCommand command = new SqlCommand(updateHD, ketNoi);
                    ketNoi.Open();
                    command.ExecuteNonQuery();
                    ketNoi.Close();

                    this.Hide();
                    m.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai thông tin đăng nhập ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhau.Clear();
                    txtTaiKhoan.Focus();
                }
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Clear();
                txtTaiKhoan.Focus();
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            lbDK.Hide();
            radAdmin.Hide();
            btnDangKy.Hide();
            btnDangNhap.Show();
            lbDN.Show();
            chkShowMK.Show();
            lnkDK.Show();
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
            btnHuyDK.Hide();
        }

        private void lnkDK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbDK.Show();
            radAdmin.Show();
            btnDangKy.Show();
            btnDangNhap.Hide();
            lbDN.Hide();
            chkShowMK.Hide();
            lnkDK.Hide();
            btnHuyDK.Show();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            int chkQuyen = 1;
            if (radAdmin.Checked)
            {
                chkQuyen = 0;
            }
            ketNoi = new SqlConnection(chuoiKN);
            string insert = string.Format("insert into Users values(N'{0}',N'{1}',{2},{3})", txtTaiKhoan.Text, txtMatKhau.Text, chkQuyen,0);
            SqlCommand cmd = new SqlCommand(insert, ketNoi);
            ketNoi.Open();
           int kq =  cmd.ExecuteNonQuery();
           if(kq > 0)
           {
               MessageBox.Show("Đăng ký thành công");
               frmDangNhap_Load(sender, e);
           }
           else
           {
               MessageBox.Show("Đăng ký không thành công");
           }
           ketNoi.Close();

        }

        private void btnHuyDK_Click(object sender, EventArgs e)
        {
            frmDangNhap_Load(sender, e);
        }

       
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBanDongHo
{
    public partial class frmDangNhap : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DoAn1_BanDongHo;Integrated Security=True");

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            /*if (MessageBox.Show("Bạn chắc chắn muốn thoát", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            } */
            this.Close();
        }



        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string taiKhoan, matKhau;
                taiKhoan = txtTaiKhoan.Text;
                matKhau = txtMatKhau.Text;
                string sql = "SELECT * FROM USERS WHERE TAIKHOAN = '" + taiKhoan + "' AND MATKHAU = '" + matKhau + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                if (tb != null && tb.Rows.Count > 0)
                {
                    frmMain m = new frmMain(taiKhoan);
                    foreach (DataRow dr in tb.Rows)
                    {
                        m.kt = int.Parse(dr["QUYEN"].ToString());
                    }
                    MessageBox.Show("Đăng nhập thành công.", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    m.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai thông tin đăng nhập.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhau.Clear();
                    txtTaiKhoan.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }


        private void chkMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLuuTK.Checked == true)
            {
                txtMatKhau.PasswordChar = (char)0;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }
    }
}
>>>>>>> 52ae496 (commit)
