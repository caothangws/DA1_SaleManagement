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
using System.IO;
namespace AppBanDongHo
{
    public partial class frmSanPham : Form
    {
        string chuoiKN;
        SqlConnection connect;
        SqlCommand cmd;
        SqlDataAdapter adp = new SqlDataAdapter();
        DataSet dtSet;

        public string valueimg = "";
        public frmSanPham()
        {
            InitializeComponent();
        }
        private void setValue(bool param, bool isLoad)
        {
            txtMaSP.ReadOnly = true;
            txtMaSP.Text = null;
            txtTenSP.Text = null;
            txtSoLuong.Text = null;
            txtGiaNhap.Text = null;
            txtGiaBan.Text = null;
            picSP.Image = null;
            txtGhichu.Text = null;
            txtTimKiem.Text = null;
            btnThem.Enabled = !param;
            btnLuu.Enabled = param;

            if (isLoad)
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                btnSua.Enabled = !param;
                btnXoa.Enabled = !param;
            }

        }

        private void LoadSP(string tk = "")
        {

            connect = new SqlConnection(chuoiKN);

            string selectNV = "select * from SanPham order by MaSP";
            if (tk != "")
            {
                selectNV = string.Format("select * from SanPham where TenSP Like N'%{0}%'", tk);
            }

            adp = new SqlDataAdapter(selectNV, connect);

            dtSet = new DataSet();
            adp.Fill(dtSet, "SanPham");
            dtgvSanPham.DataSource = dtSet.Tables[0];

        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
          
            chuoiKN = global::AppBanDongHo.Properties.Settings.Default.DoAn1_BanDongHoConnectionString;
            LoadSP();
            setValue(false, true);

        }

        private void btnOpenHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImg = new OpenFileDialog();
            if (openImg.ShowDialog() == DialogResult.OK)
            {
                picSP.Image = Image.FromFile(openImg.FileName);
                this.Text = openImg.FileName;
                valueimg = openImg.FileName;
            }
        }

        private void picSP_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImg = new OpenFileDialog();
            if (openImg.ShowDialog() == DialogResult.OK)
            {
                picSP.Image = Image.FromFile(openImg.FileName);
                this.Text = openImg.FileName;
                valueimg = openImg.FileName;
         
            }
        }







      
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            setValue(true, false);
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            connect.Open();
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            string sqlXoa = string.Format("Delete from SanPham where  MaSP  = '{0}' ", txtMaSP.Text);
            cmd.CommandText = sqlXoa;
            cmd.Connection = connect;


            if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công.");
                    frmSanPham_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại.");
                }
                connect.Close();
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (  txtTenSP.Text != "" && txtSoLuong.Text != "" && txtGiaNhap.Text != "" && txtGiaBan.Text != "" && txtGhichu.Text != "")
            {

                connect.Open();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;

                string sqlUpdate = string.Format("Update SanPham set TenSP = N'{0}', SoLuong = {2}, GiaNhap = {3}, GiaBan = {4},GhiChu = N'{5}',HinhAnh = N'{6}' where MaSP = '{1}'", 
                    txtTenSP.Text, txtMaSP.Text, txtSoLuong.Text, txtGiaNhap.Text, txtGiaBan.Text, txtGhichu.Text, valueimg.ToString());
               
                cmd.CommandText = sqlUpdate;
                cmd.Connection = connect;

                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Sửa thành công.");
                    frmSanPham_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại.");
                }
                connect.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
         
          if ( txtTenSP.Text != "" && txtSoLuong.Text != "" && txtGiaNhap.Text != "" && txtGiaBan.Text != "" && txtGhichu.Text != "")
            {
                connect.Open();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                string sql = string.Format("insert into SanPham values(N'{0}',{1},{2},{3},N'{4}','{5}')",
                  txtTenSP.Text, txtSoLuong.Text, txtGiaNhap.Text, txtGiaBan.Text, txtGhichu.Text, valueimg );
                cmd.CommandText = sql;
                cmd.Connection = connect;

                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công.");
                    frmSanPham_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại.");
                }

                connect.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            setValue(false, true);
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTimKiem.Text))
            {
                LoadSP(txtTimKiem.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSP();
            }
        }

        private void btnHTall_Click_1(object sender, EventArgs e)
        {
            frmSanPham_Load(sender, e);
            setValue(true, false);
        }
       

        private void dtgvSanPham_Click(object sender, EventArgs e)
        {
           int vitri = dtgvSanPham.CurrentCell.RowIndex;
            if (dtgvSanPham.Rows.Count > 0)
            {
                DataRow row = dtSet.Tables[0].Rows[vitri];
                txtMaSP.Text = dtgvSanPham.CurrentRow.Cells[0].Value.ToString();
                txtTenSP.Text = dtgvSanPham.CurrentRow.Cells[1].Value.ToString();
                txtSoLuong.Text = dtgvSanPham.CurrentRow.Cells[2].Value.ToString();
                txtGiaNhap.Text = dtgvSanPham.CurrentRow.Cells[3].Value.ToString();
                txtGiaBan.Text = dtgvSanPham.CurrentRow.Cells[4].Value.ToString();
                txtGhichu.Text = dtgvSanPham.CurrentRow.Cells[5].Value.ToString();
               picSP.Image = Image.FromFile(row["HinhAnh"].ToString());
              valueimg = dtgvSanPham.CurrentRow.Cells[6].Value.ToString();

                btnLuu.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
               
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
using System.IO;
namespace AppBanDongHo
{
    public partial class frmSanPham : Form
    {
        string chuoiKN;
        SqlConnection connect;
        SqlCommand cmd;
        SqlDataAdapter adp = new SqlDataAdapter();
        DataSet dtSet;
        DataTable tb;
        public string valueimg = "";
        public frmSanPham()
        {
            InitializeComponent();
        }
        private void setValue(bool param, bool isLoad)
        {
            txtMaSP.ReadOnly = true;
            txtMaSP.Text = null;
            txtTenSP.Text = null;
            txtSoLuong.Text = null;
            txtGiaNhap.Text = null;
            txtGiaBan.Text = null;
            cbxPhanLoai.Text = null;
            picSP.Image = null;
            txtGhichu.Text = null;
            txtTimKiem.Text = null;
            btnThem.Enabled = !param;
            btnLuu.Enabled = param;

            if (isLoad)
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                btnSua.Enabled = !param;
                btnXoa.Enabled = !param;
            }

        }

        private void LoadSP(string tk = "")
        {

            connect = new SqlConnection(chuoiKN);

            string selectNV = "select * from SanPham order by MaSP";
            if (tk != "")
            {
                selectNV = string.Format("select * from SanPham where TenSP Like N'%{0}%' or PhanLoai Like N'%{0}%' ", tk);
            }

            adp = new SqlDataAdapter(selectNV, connect);

            dtSet = new DataSet();
            adp.Fill(dtSet, "SanPham");
            dtgvSanPham.DataSource = dtSet.Tables[0];

        }

        private void loadCBX(string select = "")
        {
            string selectCBX = "select  PhanLoai from SanPham ";
            adp = new SqlDataAdapter(selectCBX, connect);
            tb = new DataTable();
            adp.Fill(tb);
            cbxPhanLoai.DataSource = tb;
            cbxPhanLoai.DisplayMember = "PhanLoai";
            cbxPhanLoai.ValueMember = "PhanLoai";
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
          
            chuoiKN = global::AppBanDongHo.Properties.Settings.Default.DoAn1_BanDongHoConnectionString1;
            LoadSP();
            loadCBX();
            setValue(false, true);

        }

        private void btnOpenHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImg = new OpenFileDialog();
            if (openImg.ShowDialog() == DialogResult.OK)
            {
                picSP.Image = Image.FromFile(openImg.FileName);
                this.Text = openImg.FileName;
                valueimg = openImg.FileName;
            }
        }

        private void picSP_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImg = new OpenFileDialog();
            if (openImg.ShowDialog() == DialogResult.OK)
            {
                picSP.Image = Image.FromFile(openImg.FileName);
                this.Text = openImg.FileName;
                valueimg = openImg.FileName;
         
            }
        }







      
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            setValue(true, false);
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            connect.Open();
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            string sqlXoa = string.Format("Delete from SanPham where  MaSP  = '{0}' ", txtMaSP.Text);
            cmd.CommandText = sqlXoa;
            cmd.Connection = connect;


            if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công.");
                    frmSanPham_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại.");
                }
                connect.Close();
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (  txtTenSP.Text != "" && txtSoLuong.Text != "" && txtGiaNhap.Text != "" && txtGiaBan.Text != "" && txtGhichu.Text != "")
            {

                connect.Open();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;

                string sqlUpdate = string.Format("Update SanPham set TenSP = N'{0}',PhanLoai = N'{1}', SoLuong = {2}, GiaNhap = {3}, GiaBan = {4},GhiChu = N'{5}',HinhAnh = N'{6}' where MaSP = '{7}'", 
                    txtTenSP.Text,cbxPhanLoai.Text,  txtSoLuong.Text, txtGiaNhap.Text, txtGiaBan.Text, txtGhichu.Text, valueimg.ToString(),txtMaSP.Text);
               
                cmd.CommandText = sqlUpdate;
                cmd.Connection = connect;

                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Sửa thành công.");
                    frmSanPham_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại.");
                }
                connect.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
         
          if ( txtTenSP.Text != "" && txtSoLuong.Text != "" && txtSoLuong.Text != "" && txtGiaNhap.Text != "" && txtGiaBan.Text != "" && txtGhichu.Text != "")
            {
                connect.Open();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                string sql = string.Format("insert into SanPham values(N'{0}',N'{1}',{2},{3},{4},N'{5}','{6}')",
                  txtTenSP.Text,cbxPhanLoai.Text, txtSoLuong.Text, txtGiaNhap.Text, txtGiaBan.Text, txtGhichu.Text, valueimg );
                cmd.CommandText = sql;
                cmd.Connection = connect;

                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công.");
                    frmSanPham_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại.");
                }

                connect.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            setValue(false, true);
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTimKiem.Text))
            {
                LoadSP(txtTimKiem.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSP();
            }
        }

        private void btnHTall_Click_1(object sender, EventArgs e)
        {
            frmSanPham_Load(sender, e);
            setValue(true, false);
        }
       

        private void dtgvSanPham_Click(object sender, EventArgs e)
        {
           int vitri = dtgvSanPham.CurrentCell.RowIndex;
            if (dtgvSanPham.Rows.Count > 0)
            {
                DataRow row = dtSet.Tables[0].Rows[vitri];
                txtMaSP.Text = dtgvSanPham.CurrentRow.Cells[0].Value.ToString();
                txtTenSP.Text = dtgvSanPham.CurrentRow.Cells[1].Value.ToString();
                cbxPhanLoai.Text = dtgvSanPham.CurrentRow.Cells[2].Value.ToString();
                txtSoLuong.Text = dtgvSanPham.CurrentRow.Cells[3].Value.ToString();
                txtGiaNhap.Text = dtgvSanPham.CurrentRow.Cells[4].Value.ToString();
                txtGiaBan.Text = dtgvSanPham.CurrentRow.Cells[5].Value.ToString();
                txtGhichu.Text = dtgvSanPham.CurrentRow.Cells[6].Value.ToString();
               picSP.Image = Image.FromFile(row["HinhAnh"].ToString());
              valueimg = dtgvSanPham.CurrentRow.Cells[7].Value.ToString();

                btnLuu.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
               
            }
        }

     
       









    }
}
>>>>>>> 52ae496 (commit)
