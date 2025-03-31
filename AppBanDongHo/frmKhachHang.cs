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
    public partial class frmKhachHang : Form
    {
        SqlConnection connect;
        SqlCommand cmd;
        string chuoiKN;
        SqlDataAdapter adp = new SqlDataAdapter();
        DataSet dtSet;
        string valueCheck = "";



        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void setValue(bool param, bool isLoad)
        {
            txtMaKH.ReadOnly = true;
            txtMaKH.Text = null;
            txtTenKH.Text = null;
            txtSDT.Text = null;
            txtDiaChi.Text = null;
            txtTimKiem.Text = null ;
            radNam.Checked = param;
            radNu.Checked = param;
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
            radNam.Checked = false;
            radNu.Checked = false;
        }

        private void LoadKH(string tk = "")
        {
            connect = new SqlConnection(chuoiKN);

            string selectKH = "select * from KhachHang order by MaKH";
            if (tk != "")
            {
                selectKH = string.Format("select * from KhachHang where TenKH Like N'%{0}%'", tk);
            }
            adp = new SqlDataAdapter(selectKH, connect);
            dtSet = new DataSet();
            adp.Fill(dtSet, "KhachHang");
            dtgvKhachHang.DataSource = dtSet.Tables[0];

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            chuoiKN = global::AppBanDongHo.Properties.Settings.Default.DoAn1_BanDongHoConnectionString;
            LoadKH();
            setValue(false, true);
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
            string sqlXoa = string.Format("Delete from KhachHang where  MaKH  = {0}", txtMaKH.Text);
            cmd.CommandText = sqlXoa;
            cmd.Connection = connect;


            if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công.");
                    frmKhachHang_Load(sender, e);
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
            valueCheck = (radNam.Checked) ? "Nam" : "Nữ";

            if (txtTenKH.Text != "" && txtSDT.Text != "" && radNam.Checked || radNu.Checked)
            {

                connect.Open();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;

                string sql = string.Format("update  KhachHang set TenKH = N'{0}', SDT = {1} ,DiaChi = N'{2}', GioiTinh = N'{3}' where MaKH = {4}", txtTenKH.Text, txtSDT.Text, txtDiaChi.Text, valueCheck, txtMaKH.Text);
                cmd.CommandText = sql;
                cmd.Connection = connect;

                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Sửa thành công.");
                    frmKhachHang_Load(sender, e);
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
            valueCheck = (radNam.Checked) ? "Nam" : "Nữ";
            if (txtTenKH.Text != "" && txtSDT.Text != "" && radNam.Checked || radNu.Checked)
            {
                connect.Open();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                string sql = string.Format("insert into KhachHang values(N'{0}','{1}',N'{2}',N'{3}')", txtTenKH.Text, txtSDT.Text, txtDiaChi.Text, valueCheck);
                cmd.CommandText = sql;
                cmd.Connection = connect;

                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công.");
                    frmKhachHang_Load(sender, e);
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

        private void btnHTall_Click_1(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);

        }

        private void btnTK_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTimKiem.Text))
            {
                    LoadKH(txtTimKiem.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtgvKhachHang_Click_1(object sender, EventArgs e)
        {
            if (dtgvKhachHang.Rows.Count > 0)
            {
                txtMaKH.Text = dtgvKhachHang.CurrentRow.Cells[0].Value.ToString();
                txtTenKH.Text = dtgvKhachHang.CurrentRow.Cells[1].Value.ToString();
                txtSDT.Text = dtgvKhachHang.CurrentRow.Cells[2].Value.ToString();
                txtDiaChi.Text = dtgvKhachHang.CurrentRow.Cells[3].Value.ToString();
                string gt = dtgvKhachHang.CurrentRow.Cells[4].Value.ToString();
                if (gt == "Nam")
                    radNam.Checked = true;
                else
                    radNu.Checked = true;

                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnLuu.Enabled = false;
                radNam.Enabled = true;
                radNu.Enabled = true;
                txtMaKH.ReadOnly = true;
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
    public partial class frmKhachHang : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=CAOTHANG;Initial Catalog=DoAn1_BanDongHo;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adp;
        string valueCheck = "";



        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void setValue(bool param, bool isLoad)
        {
            txtMaKH.ReadOnly = true;
            txtMaKH.Text = null;
            txtTenKH.Text = null;
            txtSDT.Text = null;
            txtDiaChi.Text = null;
            txtTimKiem.Text = null ;
            radNam.Checked = param;
            radNu.Checked = param;
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
            radNam.Checked = false;
            radNu.Checked = false;
        }

        private void LoadKH(string tk = "")
        {

            string selectKH = "select * from KhachHang order by MaKH";
            if (tk != "")
            {
                selectKH = string.Format("select * from KhachHang where TenKH Like N'%{0}%'", tk);
            }
            adp = new SqlDataAdapter(selectKH, conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dtgvKhachHang.DataSource = dt;

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            
            LoadKH();
            setValue(false, true);
        }


        private void btnThem_Click_1(object sender, EventArgs e)
        {
            setValue(true, false);
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            string sqlXoa = string.Format("Delete from KhachHang where  MaKH  = {0}", txtMaKH.Text);
            cmd.CommandText = sqlXoa;
            cmd.Connection = conn;


            if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công.");
                    frmKhachHang_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại.");
                }
                conn.Close();
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            valueCheck = (radNam.Checked) ? "Nam" : "Nữ";

            if (txtTenKH.Text != "" && txtSDT.Text != "" && radNam.Checked || radNu.Checked)
            {

                conn.Open();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;

                string sql = string.Format("update  KhachHang set TenKH = N'{0}', SDT = {1} ,DiaChi = N'{2}', GioiTinh = N'{3}' where MaKH = {4}", txtTenKH.Text, txtSDT.Text, txtDiaChi.Text, valueCheck, txtMaKH.Text);
                cmd.CommandText = sql;
                cmd.Connection = conn;

                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Sửa thành công.");
                    frmKhachHang_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại.");
                }

                conn.Close();

            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            valueCheck = (radNam.Checked) ? "Nam" : "Nữ";
            if (txtTenKH.Text != "" && txtSDT.Text != "" && radNam.Checked || radNu.Checked)
            {
                conn.Open();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                string sql = string.Format("insert into KhachHang values(N'{0}','{1}',N'{2}',N'{3}')", txtTenKH.Text, txtSDT.Text, txtDiaChi.Text, valueCheck);
                cmd.CommandText = sql;
                cmd.Connection = conn;

                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công.");
                    frmKhachHang_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại.");
                }

                conn.Close();
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

        private void btnHTall_Click_1(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);

        }

        private void btnTK_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTimKiem.Text))
            {
                    LoadKH(txtTimKiem.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtgvKhachHang_Click_1(object sender, EventArgs e)
        {
            if (dtgvKhachHang.Rows.Count > 0)
            {
                txtMaKH.Text = dtgvKhachHang.CurrentRow.Cells[0].Value.ToString();
                txtTenKH.Text = dtgvKhachHang.CurrentRow.Cells[1].Value.ToString();
                txtSDT.Text = dtgvKhachHang.CurrentRow.Cells[2].Value.ToString();
                txtDiaChi.Text = dtgvKhachHang.CurrentRow.Cells[3].Value.ToString();
                string gt = dtgvKhachHang.CurrentRow.Cells[4].Value.ToString();
                if (gt == "Nam")
                    radNam.Checked = true;
                else
                    radNu.Checked = true;

                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnLuu.Enabled = false;
                radNam.Enabled = true;
                radNu.Enabled = true;
                txtMaKH.ReadOnly = true;
            }
        }













    }
}
>>>>>>> 52ae496 (commit)
