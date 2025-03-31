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
using System.Data.SqlTypes;


namespace AppBanDongHo
{
    public partial class frmTaoHD : Form
    {


        SqlConnection connect;
        string chuoiKN = global::AppBanDongHo.Properties.Settings.Default.DoAn1_BanDongHoConnectionString;
        SqlDataAdapter adp = new SqlDataAdapter();
        DataSet dtSet;
        DataTable tb;
        DataTable tbl;
        static DataTable tb1;
        int vitricbx = 0 ;

        private DateTime date = new DateTime();
        public string manv;
        public frmTaoHD()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(frmChiTietHD_FormClosed);
        }





        private void loadThongTinKH()
        {
            connect = new SqlConnection(chuoiKN);
            string sqlKH = "select  MaKH ,TenKH from KhachHang";
            adp = new SqlDataAdapter(sqlKH, connect);
            dtSet = new DataSet();
            adp.Fill(dtSet);

            cbxTenKH.DataSource = dtSet.Tables[0];
            cbxTenKH.DisplayMember = "TenKH";
            cbxTenKH.ValueMember = "MaKH";

        }

        private void loadSP()
        {
            connect = new SqlConnection(chuoiKN);
            string sqlSP = "select TenSP , MaSP from SanPham";
            adp = new SqlDataAdapter(sqlSP, connect);
            dtSet = new DataSet();
            adp.Fill(dtSet);

            cbxTenSP.DataSource = dtSet.Tables[0];
            cbxTenSP.DisplayMember = "TenSP";
            cbxTenSP.ValueMember = "MaSP";


        }

        private void loadGiaSP(string select = "")
        {
            string selectGia;
            connect = new SqlConnection(chuoiKN);
            if (select != "")
            {
                selectGia = string.Format("SELECT GiaBan FROM SanPham WHERE TenSP LIKE N'%{0}%'", select);
            }
            else
            {
                selectGia = string.Format("select GiaBan from SanPham where  TenSP LIKE N'%{0}%' ", cbxTenSP.ValueMember);
            }
            SqlDataAdapter adp1 = new SqlDataAdapter(selectGia, connect);
            tb = new DataTable();
            adp1.Fill(tb);
            foreach (DataRow dr in tb.Rows)
            {
                txtGiaBan.Text = dr["GiaBan"].ToString();
            }
        }

        private void loadSLTonSP(string select = "")
        {
            string selectSL;
            connect = new SqlConnection(chuoiKN);
            if (select != "")
            {
                selectSL = string.Format("SELECT SoLuong FROM SanPham WHERE TenSP LIKE N'%{0}%'", select);
            }
            else
            {
                selectSL = string.Format("select SoLuong from SanPham where  TenSP LIKE N'%{0}%' ", cbxTenSP.ValueMember);
            }
            SqlDataAdapter adp1 = new SqlDataAdapter(selectSL, connect);
            tb = new DataTable();
            adp1.Fill(tb);
            foreach (DataRow dr in tb.Rows)
            {
                txtSLTon.Text = dr["SoLuong"].ToString();
            }
        }



        private void frmChiTietHD_Load(object sender, EventArgs e)
        {
            tb1 = new DataTable();

            loadThongTinKH();
            loadSP();
            loadSLTonSP();
            //Load Thoi gian hien tai vao textbox
            date = DateTime.Now;
            txtTG.Text = date.ToString("MM-dd-yyyy") ;
            //select ten nv voi dk hoat dong = 1 load vao textbox
            string selectNV = string.Format("select TaiKhoan from Users where HD = 1");
            SqlDataAdapter adt = new SqlDataAdapter(selectNV, connect);
            DataTable tbl = new DataTable();
            adt.Fill(tbl);
            txtTenNV.Text = tbl.Rows[0]["TaiKhoan"].ToString();
            // load ten cac cot ttrong gridview
            tb1.Columns.Add("TenSP");
            tb1.Columns.Add("MaNV");
            tb1.Columns.Add("TenKH");
            tb1.Columns.Add("SoLuong");
            tb1.Columns.Add("TongTien");
            dtgvChiTietHD.DataSource = tb1;

            //Set cac textbox chi co the doc
            txtTenNV.ReadOnly = true;
            txtSLTon.ReadOnly = true;
            txtGiaBan.ReadOnly = true;
            txtTG.ReadOnly = true;
            txtTongTien.ReadOnly = true;
            txtTongTien.Text = null;
            txtSoluongMua.Text = null;
            txtSoluongMua.Focus();

        }


        private void cbxMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drow = (DataRowView)cbxTenSP.SelectedItem;
            string srtValue = drow["TenSP"].ToString();
            loadGiaSP(srtValue);

            DataRowView dr = (DataRowView)cbxTenSP.SelectedItem;
            string str = dr["TenSP"].ToString();
            loadSLTonSP(str);
        }


        private void txtSoluongMua_TextChanged(object sender, EventArgs e)
        {
            int mua = 0;
            int ton = 0;

            ton = int.Parse(txtSLTon.Text);
            if (txtSoluongMua.Text != "")
            {
                mua = int.Parse(txtSoluongMua.Text);
                if (mua > ton)
                {
                    MessageBox.Show("So luong mua qua so luong ton");
                    txtSoluongMua.Text = "";
                }
            }
        }
        private int TinhTien()
        {
            int tien = 0;
            foreach (DataRow dr1 in tb1.Rows)
            {
                tien += int.Parse(dr1["TongTien"].ToString());
            }
            txtTongTien.Text = tien.ToString();
            return tien;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            if (txtSoluongMua.Text != "")
            {
                if (tb1.Rows.Count > 0)
                {
                    foreach (DataRow dr in tb1.Rows)
                    {

                        if (dr["TenSP"].ToString() == cbxTenSP.Text)
                        {
                            int tongSL = int.Parse(dr["SoLuong"].ToString()) + int.Parse(txtSoluongMua.Text);
                            dr["SoLuong"] = "";
                            dr["SoLuong"] = tongSL.ToString();
                            int ttien = int.Parse(txtGiaBan.Text) * int.Parse(tongSL.ToString());
                            dr["TongTien"] = "";
                            dr["TongTien"] = ttien.ToString();
                            TinhTien();
                            return;
                        }
                    }
                    DataRow r = tb1.NewRow();
                    r["TenSP"] = cbxTenSP.Text;
                    r["MaNV"] = txtTenNV.Text;
                    r["TenKH"] = cbxTenKH.Text;
                    r["SoLuong"] = txtSoluongMua.Text;
                    int tongtien = int.Parse(txtGiaBan.Text) * int.Parse(txtSoluongMua.Text);
                    r["TongTien"] = tongtien.ToString();
                    tb1.Rows.Add(r);
                    TinhTien();
                    return;
                }
                else
                {

                    DataRow r = tb1.NewRow();
                    r["TenSP"] = cbxTenSP.Text;
                    r["MaNV"] = txtTenNV.Text;
                    r["TenKH"] = cbxTenKH.Text;
                    vitricbx = cbxTenKH.SelectedIndex;
                  
                    r["SoLuong"] = txtSoluongMua.Text;
                    int tongtien = int.Parse(txtGiaBan.Text) * int.Parse(txtSoluongMua.Text);
                    r["TongTien"] = tongtien.ToString();
                    tb1.Rows.Add(r);
                    TinhTien();
                    //   MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại số lượng mua", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in tb1.Rows)
            {
                foreach (DataRow drr in dtSet.Tables[0].Rows)
                {
                    if (drr["TenSP"] == dr["TenSP"])
                    {
                        //them du lieu vao hoa don
                        string insert = string.Format("Insert into HoaDon( MaNV,MaKH,NgayLap,TongTien,SoLuongBan,MaSP ) values (N'{0}',N'{1}','{2}','{3}','{4}',N'{5}')", txtTenNV.Text, cbxTenKH.SelectedValue, txtTG.Text, dr["TongTien"].ToString(), txtSoluongMua.Text, cbxTenSP.SelectedValue);
                        SqlCommand cmd = new SqlCommand(insert, connect);
                        connect.Open();
                        cmd.ExecuteNonQuery();
                        connect.Close();
                        //lay toan bo du lieu bang sp với dk
                        string select = string.Format("select * from SanPham where MaSP = N'{0}' ", cbxTenSP.SelectedValue);
                        SqlDataAdapter adt = new SqlDataAdapter(select, connect);
                        DataTable tbselect = new DataTable();
                        adt.Fill(tbselect);
                        int soluongHienTai = Int32.Parse(tbselect.Rows[0]["SoLuong"].ToString()) - Int32.Parse(dr["SoLuong"].ToString());
                        string update = string.Format("Update SanPham set SoLuong = {0} where TenSP = N'{1}' ", soluongHienTai,tb1.Rows[0]["TenSP"].ToString());
                        SqlCommand cmd1 = new SqlCommand(update, connect);
                        connect.Open();
                        cmd1.ExecuteNonQuery();
                        connect.Close();
                        this.Close();

                    }
                }
            }
        }





        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTongTien.Text = null;
            txtSoluongMua.Text = null;
            frmChiTietHD_Load(sender, e);
        }

        private void frmChiTietHD_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void cbxTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tb1.Rows.Count > 0)
            {
                cbxTenKH.SelectedIndex = vitricbx;
                MessageBox.Show("Vui lòng thanh toán hóa đơn của khách hiện tại trước khi chọn khách hàng khác.Cảm ơn!","Thông Báo");
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
    public partial class frmTaoHD : Form
    {


        SqlConnection connect;
        string chuoiKN = global::AppBanDongHo.Properties.Settings.Default.DoAn1_BanDongHoConnectionString1;
        SqlDataAdapter adp = new SqlDataAdapter();
        DataSet dtSet;
        DataTable tb;
        DataTable tbl;
    
        
        static DataTable tb1;
  

        private DateTime date = new DateTime();
        public string manv;
        public frmTaoHD()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(frmChiTietHD_FormClosed);
        }





        private void loadThongTinKH()
        {
            connect = new SqlConnection(chuoiKN);
            string sqlKH = "select  MaKH ,TenKH from KhachHang";
            adp = new SqlDataAdapter(sqlKH, connect);
            dtSet = new DataSet();
            adp.Fill(dtSet);

            cbxTenKH.DataSource = dtSet.Tables[0];
            cbxTenKH.DisplayMember = "TenKH";
            cbxTenKH.ValueMember = "MaKH";

        }

        private void loadSP()
        {
            connect = new SqlConnection(chuoiKN);
            string sqlSP = "select TenSP , MaSP from SanPham";
            adp = new SqlDataAdapter(sqlSP, connect);
            dtSet = new DataSet();
            adp.Fill(dtSet);

            cbxTenSP.DataSource = dtSet.Tables[0];
            cbxTenSP.DisplayMember = "TenSP";
            cbxTenSP.ValueMember = "MaSP";


        }

        private void loadGiaSP(string select = "")
        {
            string selectGia;
            connect = new SqlConnection(chuoiKN);
            if (select != "")
            {
                selectGia = string.Format("SELECT GiaBan FROM SanPham WHERE TenSP LIKE N'%{0}%'", select);
            }
            else
            {
                selectGia = string.Format("select GiaBan from SanPham where  TenSP LIKE N'%{0}%' ", cbxTenSP.ValueMember);
            }
            SqlDataAdapter adp1 = new SqlDataAdapter(selectGia, connect);
            tb = new DataTable();
            adp1.Fill(tb);
            foreach (DataRow dr in tb.Rows)
            {
                txtGiaBan.Text = dr["GiaBan"].ToString();
            }
        }

        private void loadSLTonSP(string select = "")
        {
            string selectSL;
            connect = new SqlConnection(chuoiKN);
            if (select != "")
            {
                selectSL = string.Format("SELECT SoLuong FROM SanPham WHERE TenSP LIKE N'%{0}%'", select);
            }
            else
            {
                selectSL = string.Format("select SoLuong from SanPham where  TenSP LIKE N'%{0}%' ", cbxTenSP.ValueMember);
            }
            SqlDataAdapter adp1 = new SqlDataAdapter(selectSL, connect);
            tb = new DataTable();
            adp1.Fill(tb);
            foreach (DataRow dr in tb.Rows)
            {
                txtSLTon.Text = dr["SoLuong"].ToString();
            }
        }



        private void frmChiTietHD_Load(object sender, EventArgs e)
        {
            tb1 = new DataTable();
            
            loadThongTinKH();
            loadSP();
            loadSLTonSP();
            //Load Thoi gian hien tai vao textbox
            date = DateTime.Now;
            txtTG.Text = date.ToString("MM-dd-yyyy") ;
            //select ten nv voi dk hoat dong = 1 load vao textbox
            string selectNV = string.Format("select TaiKhoan from Users where HD = 1");
            SqlDataAdapter adt = new SqlDataAdapter(selectNV, connect);
            DataTable tbl = new DataTable();
            adt.Fill(tbl);
            txtTenNV.Text = tbl.Rows[0]["TaiKhoan"].ToString();
            // load ten cac cot ttrong gridview
            tb1.Columns.Add("TenSP");
            tb1.Columns.Add("MaNV");
            tb1.Columns.Add("TenKH");
            tb1.Columns.Add("SoLuong");
            tb1.Columns.Add("TongTien");
            dtgvChiTietHD.DataSource = tb1;

            //Set cac textbox chi co the doc
            txtTenNV.ReadOnly = true;
            txtSLTon.ReadOnly = true;
            txtGiaBan.ReadOnly = true;
            txtTG.ReadOnly = true;
            txtTongTien.ReadOnly = true;
            txtTongTien.Text = null;
            txtSoluongMua.Text = null;
            txtSoluongMua.Focus();
            //
           
           
            

           
        }


        private void cbxMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drow = (DataRowView)cbxTenSP.SelectedItem;
            string srtValue = drow["TenSP"].ToString();
            loadGiaSP(srtValue);

            DataRowView dr = (DataRowView)cbxTenSP.SelectedItem;
            string str = dr["TenSP"].ToString();
            loadSLTonSP(str);
        }


        private void txtSoluongMua_TextChanged(object sender, EventArgs e)
        {
            int mua = 0;
            int ton = 0;

            ton = int.Parse(txtSLTon.Text);
            if (txtSoluongMua.Text != "")
            {
                mua = int.Parse(txtSoluongMua.Text);
                if (mua > ton)
                {
                    MessageBox.Show("So luong mua qua so luong ton");
                    txtSoluongMua.Text = "";
                }
            }
        }
        private int TinhTien()
        {
            int tien = 0;
            foreach (DataRow dr1 in tb1.Rows)
            {
                tien += int.Parse(dr1["TongTien"].ToString());
            }
            txtTongTien.Text = tien.ToString();
            return tien;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            if (txtSoluongMua.Text != "")
            {
                if (tb1.Rows.Count > 0)
                {
                    foreach (DataRow dr in tb1.Rows)
                    {

                        if (dr["TenSP"].ToString() == cbxTenSP.Text )
                        {
                            int tongSL = int.Parse(dr["SoLuong"].ToString()) + int.Parse(txtSoluongMua.Text);
                            dr["SoLuong"] = "";
                            dr["SoLuong"] = tongSL.ToString();
                            int ttien = int.Parse(txtGiaBan.Text) * int.Parse(tongSL.ToString());
                            dr["TongTien"] = "";
                            dr["TongTien"] = ttien.ToString();
                            TinhTien();
                            return;
                        }
                    }
                    DataRow r = tb1.NewRow();
                    r["TenSP"] = cbxTenSP.Text;
                    r["MaNV"] = txtTenNV.Text;
                    r["TenKH"] = cbxTenKH.Text;
                    r["SoLuong"] = txtSoluongMua.Text;
                    int tongtien = int.Parse(txtGiaBan.Text) * int.Parse(txtSoluongMua.Text);
                    r["TongTien"] = tongtien.ToString();
                    tb1.Rows.Add(r);
                    TinhTien();
                    return;
                }
                else
                {

                    DataRow r = tb1.NewRow();
                    r["TenSP"] = cbxTenSP.Text;
                    r["MaNV"] = txtTenNV.Text;
                    r["TenKH"] = cbxTenKH.Text;
                 
                    r["SoLuong"] = txtSoluongMua.Text;
                    int tongtien = int.Parse(txtGiaBan.Text) * int.Parse(txtSoluongMua.Text);
                    r["TongTien"] = tongtien.ToString();
                    tb1.Rows.Add(r);
                    TinhTien();
                    //   MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại số lượng mua", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
       
         

            foreach (DataRow dr in tb1.Rows)
            {
               
                foreach (DataRow drr in dtSet.Tables[0].Rows)
                {
                    if (drr["TenSP"] == dr["TenSP"])
                    {
                        //them du lieu vao hoa don
                        string insert = string.Format("Insert into HoaDon( MaNV,MaKH,NgayLap,TongTien,SoLuongBan,MaSP ) values (N'{0}',N'{1}','{2}','{3}','{4}',N'{5}')", txtTenNV.Text, cbxTenKH.SelectedValue, txtTG.Text, dr["TongTien"].ToString(), txtSoluongMua.Text, cbxTenSP.SelectedValue);
                        SqlCommand cmd = new SqlCommand(insert, connect);
                        connect.Open();
                        cmd.ExecuteNonQuery();
                        connect.Close();
                        //lay toan bo du lieu bang sp với dk
                        string select = string.Format("select * from SanPham where MaSP = N'{0}' ", cbxTenSP.SelectedValue);
                        SqlDataAdapter adt = new SqlDataAdapter(select, connect);
                        DataTable tbselect = new DataTable();
                        adt.Fill(tbselect);
                        int soluongHienTai = Int32.Parse(tbselect.Rows[0]["SoLuong"].ToString()) - Int32.Parse(dr["SoLuong"].ToString());
                        string update = string.Format("Update SanPham set SoLuong = {0} where TenSP = N'{1}' ", soluongHienTai,tb1.Rows[0]["TenSP"].ToString());
                        SqlCommand cmd1 = new SqlCommand(update, connect);
                        connect.Open();
                        cmd1.ExecuteNonQuery();
                        connect.Close();
                        //Xuat hoa don
                       
                        
                       
                        
                        
                    }
                }
            }
        }





        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTongTien.Text = null;
            txtSoluongMua.Text = null;
            frmChiTietHD_Load(sender, e);
        }

        private void frmChiTietHD_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

   






    }
}
>>>>>>> 52ae496 (commit)
