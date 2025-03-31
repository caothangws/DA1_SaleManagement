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
    public partial class frmNhanVien : Form
    {
        SqlConnection connect;
        SqlCommand cmd;
        string chuoiKN;
        SqlDataAdapter adp = new SqlDataAdapter();
        DataSet dtSet;
   



        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void setValue(bool param, bool isLoad)
        {
            
            txtMaNV.Text = null;
            txtTenNV.Text = null;
            txtSDT.Text = null;
            txtEmail.Text = null;
            txtDiaChi.Text = null;
            cbxChucVu.Text = null;
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
        private void LoadNV(string tk = "")
        {

            connect = new SqlConnection(chuoiKN);

            string selectNV = "select MaNV,TenNV,SDT,Email,NgaySinh,DiaChi,ChucVu from NhanVien order by MaNV";
            if (tk != "")
            {
                selectNV = string.Format("select MaNV,TenNV,SDT,Email,NgaySinh,DiaChi,ChucVu  from NhanVien where TenNV Like N'%{0}%'", tk);
            }

            adp = new SqlDataAdapter(selectNV, connect);

            dtSet = new DataSet();
            adp.Fill(dtSet, "NhanVien");
            dtgvNhanVien.DataSource = dtSet.Tables[0];

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {

            chuoiKN = global::AppBanDongHo.Properties.Settings.Default.DoAn1_BanDongHoConnectionString;
            LoadNV();
            setValue(false, true);


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            setValue(true, false);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text != "" && txtSDT.Text != "" && txtEmail.Text != "")
            {
                connect.Open();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                string sql = string.Format("insert into NhanVien values(N'{0}',N'{1}',{2},'{3}','{4}',N'{5}',N'{6}')",txtMaNV.Text, txtTenNV.Text, txtSDT.Text, txtEmail.Text, dpkNgaySinh.Value.ToShortDateString(), txtDiaChi.Text, cbxChucVu.Text);
                cmd.CommandText = sql;
                cmd.Connection = connect;
               
                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công.");
                    frmNhanVien_Load(sender, e);
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            connect.Open();
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            string sqlXoa = string.Format("Delete from NhanVien where  MaNV  = N'{0}'", txtMaNV.Text);
            cmd.CommandText = sqlXoa;
            cmd.Connection = connect;


            if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công.");
                    frmNhanVien_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại.");
                }
                connect.Close();
            }
        }



        private void btnSua_Click(object sender, EventArgs e)
        {
            
            if (txtTenNV.Text != "" && txtSDT.Text != "" && txtEmail.Text != "")
            {

                connect.Open();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;

                string sql = string.Format("update  NhanVien set TenNV = N'{0}', SDT = '{1}', Email = '{2}', NgaySinh = '{3}', DiaChi = N'{4}', ChucVu = N'{5}' where MaNV = '{6}' ",
                    txtTenNV.Text, txtSDT.Text, txtEmail.Text, dpkNgaySinh.Value.ToShortDateString(), txtDiaChi.Text, cbxChucVu.Text, txtMaNV.Text);
                cmd.CommandText = sql;
                cmd.Connection = connect;

                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Sửa thành công.");
                    frmNhanVien_Load(sender, e);
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

        private void btnHTall_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
           
        }
       
        private void btnTK_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtTimKiem.Text))
            {
                LoadNV(txtTimKiem.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNV();
            }

        }



        private void btnBoqua_Click(object sender, EventArgs e)
        {
            setValue(false, true);
        }


        private void dtvgNhanVien_Click(object sender, EventArgs e)
        {
            if (dtgvNhanVien.Rows.Count > 0)
            {
                txtMaNV.Text = dtgvNhanVien.CurrentRow.Cells[0].Value.ToString();
                txtTenNV.Text = dtgvNhanVien.CurrentRow.Cells[1].Value.ToString();
                txtSDT.Text = dtgvNhanVien.CurrentRow.Cells[2].Value.ToString();
                txtEmail.Text = dtgvNhanVien.CurrentRow.Cells[3].Value.ToString();
                dpkNgaySinh.Text = dtgvNhanVien.CurrentRow.Cells[4].Value.ToString();
                txtDiaChi.Text = dtgvNhanVien.CurrentRow.Cells[5].Value.ToString();
                cbxChucVu.Text = dtgvNhanVien.CurrentRow.Cells[6].Value.ToString();
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnLuu.Enabled = false;
              
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
using System.Runtime.Remoting.Contexts;

namespace AppBanDongHo
{
    public partial class frmNhanVien : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DoAn1_BanDongHo;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adp;
        DataTable dt;
        bool themDL;
        private string SelectedMaNV = "";




        public frmNhanVien()
        {
            InitializeComponent();

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadNV();
            setValue();
            disable(false);

        }

        private void setValue()
        {
            txtTenNV.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
        }

        private void disable(bool gt)
        {
            txtTenNV.Enabled = gt;
            txtSDT.Enabled = gt;
            txtDiaChi.Enabled = gt;
            txtEmail.Enabled = gt;
            dpkNgaySinh.Enabled = gt;

            btnThem.Enabled = !gt;
            btnSua.Enabled = !gt;
            btnXoa.Enabled = !gt;
            btnLuu.Enabled = gt;
        }
        private void LoadNV()
        {
            string selectNV = "SELECT * FROM NHANVIEN ORDER BY MANV";
            adp = new SqlDataAdapter(selectNV, conn);
            dt = new DataTable();
            adp.Fill(dt);
            dtgvNhanVien.DataSource = dt;
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            setValue();
            disable(true);
            themDL = true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtTenNV.Text))
            {
                MessageBox.Show("Vui long nhap ten nhan vien");
                txtTenNV.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Vui long nhap so dien thoai");
                txtSDT.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Vui long nhap Email");
                txtEmail.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Vui long nhap dia chi");
                txtDiaChi.Focus();
                return;
            }
            else
            {
                if (themDL == true)
                {
                    conn.Open();
                    string sql = "INSERT INTO NHANVIEN(TENNV,SDT,EMAIL,NGAYSINH,DIACHI) VALUES (@TENNV,@SDT,@EMAIL,@NGAYSINH,@DIACHI)";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@TENNV", txtTenNV.Text);
                    cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@NGAYSINH", dpkNgaySinh.Value);
                    cmd.Parameters.AddWithValue("@DIACHI", txtDiaChi.Text);
                    int kq = cmd.ExecuteNonQuery();
                    MessageBox.Show(kq > 0 ? "Them thanh cong" : "Them that bai");
                }
                else
                {
                    conn.Open();
                    string sql = "UPDATE NHANVIEN SET TENNV = @TENNV,SDT = @SDT,EMAIL = @EMAIL,NGAYSINH = @NGAYSINH,DIACHI = @DIACHI WHERE MANV = @MANV";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@TENNV", txtTenNV.Text);
                    cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@NGAYSINH", dpkNgaySinh.Value);
                    cmd.Parameters.AddWithValue("@DIACHI", txtDiaChi.Text);
                    cmd.Parameters.AddWithValue("@MANV", SelectedMaNV);
                    int kq = cmd.ExecuteNonQuery();
                    MessageBox.Show(kq > 0 ? "Cap nhat thanh cong" : "Cap nhat that bai");

                }
                conn.Close();
                frmNhanVien_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (dtgvNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui long chon nhan vien muon xoa");
                return;
            }
            else
            {
                conn.Open();
                string sql = "DELETE FROM NHANVIEN WHERE MANV = @MANV";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MANV", SelectedMaNV);
                if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int kq = cmd.ExecuteNonQuery();
                    MessageBox.Show(kq > 0 ? "Xóa thành công." : "Xoa that bai");
                    conn.Close();
                    frmNhanVien_Load(sender, e);
                }
            }
        }



        private void btnSua_Click(object sender, EventArgs e)
        {
            disable(true);
            themDL = false;
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }

        private void dtgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    SelectedMaNV = dtgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtTenNV.Text = dtgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtSDT.Text = dtgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtEmail.Text = dtgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                    dpkNgaySinh.Text = dtgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
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

>>>>>>> 52ae496 (commit)
