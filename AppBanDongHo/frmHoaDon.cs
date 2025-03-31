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
    public partial class frmHoaDon : Form
    {
        public delegate void UpdateDataHandler();
        public event UpdateDataHandler UpdateDataEvent;
        SqlConnection connect;
        string chuoiKN = global::AppBanDongHo.Properties.Settings.Default.DoAn1_BanDongHoConnectionString;
        SqlDataAdapter adp = new SqlDataAdapter();
        DataSet dtSet;
        DataTable tb1;
        
        public frmHoaDon()
        {
            InitializeComponent();

        }
        private void frmChiTietHD_FormClosed(object sender, FormClosedEventArgs e)
        {
           frmHoaDon_Load(sender, e); // Gọi hàm tải lại dữ liệu
        }

       

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            loadGridView();
           
        }

        private void loadGridView(string tk = "")
        {
            connect = new SqlConnection(chuoiKN);
            string selectHD = "select MaHD, KhachHang.TenKH, NhanVien.TenNV, NgayLap, TongTien, SoLuongBan, MaSP from HoaDon  inner join KhachHang on KhachHang.MaKH = HoaDon.MaKH  inner join NhanVien on NhanVien.MaNV = HoaDon.MaNV";
            if(tk != "")
            {
                selectHD = string.Format("select MaHD, KhachHang.TenKH, NhanVien.TenNV, NgayLap, TongTien, SoLuongBan from HoaDon inner join KhachHang on KhachHang.MaKH = HoaDon.MaKH inner join NhanVien on NhanVien.MaNV = HoaDon.MaNV where KhachHang.TenKH Like '%{0}%' ", tk);
            }
            adp = new SqlDataAdapter(selectHD, connect);

            dtSet = new DataSet();
            adp.Fill(dtSet);
            gvHoaDon.DataSource = dtSet.Tables[0];
          
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            frmTaoHD frmct = new frmTaoHD();
            frmct.FormClosed += frmChiTietHD_FormClosed; // Đăng ký sự kiện
            frmct.Show();

        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {
            string tk = txtTK.Text.Trim();
            if(tk == "")
            {
                frmHoaDon_Load(sender, e);
                txtTK.Focus();
            }
            else
            {
                loadGridView(txtTK.Text);
            }
        }

      /*  private void loadCBX()
        {
            DateTime now = DateTime.Now;
            
            string select = string.Format("select  distinct TenKH from KhachHang inner join HoaDon on KhachHang.MaKH = HoaDon.MaKH where HoaDon.NgayLap Like '%{0}%'  ",now.ToString("yyyy-DD-mm"));
            SqlDataAdapter adt = new SqlDataAdapter(select, connect);
            DataTable tbl = new DataTable();
            adt.Fill(tbl);
            comboBox1.DataSource = tbl;
            
        }

        private void LoadGridView(string  tenkh = "")
        {
            string selectHD = string.Format("select MaHD, KhachHang.TenKH, NhanVien.TenNV, NgayLap, TongTien, SoLuongBan from HoaDon inner join KhachHang on KhachHang.MaKH = HoaDon.MaKH inner join NhanVien on NhanVien.MaNV = HoaDon.MaNV where KhachHang.TenKH Like '%{0}%' ", tenkh);
            if (tenkh != "")
            {
               selectHD = string.Format("select MaHD, KhachHang.TenKH, NhanVien.TenNV, NgayLap, TongTien, SoLuongBan from HoaDon inner join KhachHang on KhachHang.MaKH = HoaDon.MaKH inner join NhanVien on NhanVien.MaNV = HoaDon.MaNV where KhachHang.TenKH Like '%{0}%' ", tenkh);
             
            }
            SqlDataAdapter a = new SqlDataAdapter(selectHD, connect);
            DataTable tbgv = new DataTable();
            a.Fill(tbgv);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       */
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

namespace AppBanDongHo
{
    public partial class frmHoaDon : Form
    {
        public delegate void UpdateDataHandler();
        public event UpdateDataHandler UpdateDataEvent;
        SqlConnection connect;
        string chuoiKN = global::AppBanDongHo.Properties.Settings.Default.DoAn1_BanDongHoConnectionString1;
        SqlDataAdapter adp = new SqlDataAdapter();
        DataSet dtSet;
        DataTable tb1;
        
        public frmHoaDon()
        {
            InitializeComponent();

        }
        private void frmChiTietHD_FormClosed(object sender, FormClosedEventArgs e)
        {
           frmHoaDon_Load(sender, e); // Gọi hàm tải lại dữ liệu
        }

       

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            loadGridView();
           
        }

        private void loadGridView(string tk = "")
        {
            connect = new SqlConnection(chuoiKN);
            string selectHD = "select MaHD, KhachHang.TenKH, NhanVien.TenNV, NgayLap, TongTien, SoLuongBan, MaSP from HoaDon  inner join KhachHang on KhachHang.MaKH = HoaDon.MaKH  inner join NhanVien on NhanVien.MaNV = HoaDon.MaNV";
            if(tk != "")
            {
                selectHD = string.Format("select MaHD, KhachHang.TenKH, NhanVien.TenNV, NgayLap, TongTien, SoLuongBan from HoaDon inner join KhachHang on KhachHang.MaKH = HoaDon.MaKH inner join NhanVien on NhanVien.MaNV = HoaDon.MaNV where KhachHang.TenKH Like N'%{0}%' ", tk);
            }
            adp = new SqlDataAdapter(selectHD, connect);

            dtSet = new DataSet();
            adp.Fill(dtSet);
            gvHoaDon.DataSource = dtSet.Tables[0];
          
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            frmTaoHD frmct = new frmTaoHD();
            frmct.FormClosed += frmChiTietHD_FormClosed; // Đăng ký sự kiện
            frmct.Show();

        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {
            string tk = txtTK.Text.Trim();
            if(tk == "")
            {
                frmHoaDon_Load(sender, e);
                txtTK.Focus();
            }
            else
            {
                loadGridView(txtTK.Text);
            }
        }

      /*  private void loadCBX()
        {
            DateTime now = DateTime.Now;
            
            string select = string.Format("select  distinct TenKH from KhachHang inner join HoaDon on KhachHang.MaKH = HoaDon.MaKH where HoaDon.NgayLap Like '%{0}%'  ",now.ToString("yyyy-DD-mm"));
            SqlDataAdapter adt = new SqlDataAdapter(select, connect);
            DataTable tbl = new DataTable();
            adt.Fill(tbl);
            comboBox1.DataSource = tbl;
            
        }

        private void LoadGridView(string  tenkh = "")
        {
            string selectHD = string.Format("select MaHD, KhachHang.TenKH, NhanVien.TenNV, NgayLap, TongTien, SoLuongBan from HoaDon inner join KhachHang on KhachHang.MaKH = HoaDon.MaKH inner join NhanVien on NhanVien.MaNV = HoaDon.MaNV where KhachHang.TenKH Like '%{0}%' ", tenkh);
            if (tenkh != "")
            {
               selectHD = string.Format("select MaHD, KhachHang.TenKH, NhanVien.TenNV, NgayLap, TongTien, SoLuongBan from HoaDon inner join KhachHang on KhachHang.MaKH = HoaDon.MaKH inner join NhanVien on NhanVien.MaNV = HoaDon.MaNV where KhachHang.TenKH Like '%{0}%' ", tenkh);
             
            }
            SqlDataAdapter a = new SqlDataAdapter(selectHD, connect);
            DataTable tbgv = new DataTable();
            a.Fill(tbgv);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       */
    }
}
>>>>>>> 52ae496 (commit)
