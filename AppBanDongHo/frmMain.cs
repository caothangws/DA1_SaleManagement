<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace AppBanDongHo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        public int kt;
        
        SqlConnection connect;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            string chuoiKN = global::AppBanDongHo.Properties.Settings.Default.DoAn1_BanDongHoConnectionString;
            connect = new SqlConnection(chuoiKN);
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
             
                string update = string.Format("update  Users set HD = 0 where HD = 1");

                SqlCommand cmd = new SqlCommand(update, connect);
                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
                this.Close();
              

            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            string chuoiKN = global::AppBanDongHo.Properties.Settings.Default.DoAn1_BanDongHoConnectionString;
            connect = new SqlConnection(chuoiKN);
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
              
                string update = string.Format("update  Users set HD = 0 where HD = 1");
                SqlCommand cmd = new SqlCommand(update, connect);
                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();

                this.Close();
                this.Hide();
                frmDangNhap frmDN = new frmDangNhap();
                frmDN.ShowDialog();
                this.Close();

            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhanVien());
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSanPham());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachHang());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHoaDon());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKe());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }



        private void frmMain_Load_1(object sender, EventArgs e)
        {
            
            
            if (kt == 1)
            {
                btnNhanVien.Hide();
                btnThongKe.Hide();
            }
        }
        

    }
}

=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace AppBanDongHo
{
    public partial class frmMain : Form
    {
        private Form currentFormChild;
        public int kt;

        SqlConnection conn = new SqlConnection("Data Source=CAOTHANG;Initial Catalog=DoAn1_BanDongHo;Integrated Security=True");
        public frmMain(string manv)
        {
            InitializeComponent();
        }
        
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhanVien());
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSanPham());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachHang());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHoaDon());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKe());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }



        private void frmMain_Load_1(object sender, EventArgs e)
        {
            string selectNV = string.Format("select TAIKHOAN from USERS where QUYEN = 0");
            SqlDataAdapter adt = new SqlDataAdapter(selectNV, conn);
            DataTable tbl = new DataTable();
            adt.Fill(tbl);
            label1.Text = "Xin chào" + " " + tbl.Rows[0]["TAIKHOAN"].ToString();

            if (kt == 0)
            {
                btnNhanVien.Hide();
                btnThongKe.Hide();
            }

        }


    }
}

>>>>>>> 52ae496 (commit)
