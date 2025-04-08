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
using SaleManagement.Froms;
using SaleManagement.Model;
namespace SaleManagement
{
    public partial class frmMain : Form
    {
        ModelSale context = new ModelSale();
        SqlDataAdapter adp;
        private Form currentFormChild;
        public int maNV;
        private Timer timer;
        string vaitro;
        int quyen;
        public frmMain(int manv)
        {
            InitializeComponent();
            manv = maNV;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            lbDate.Text = date.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var nv = context.NHANVIEN.Where(r => r.MANV == maNV).Select( r => new
            {
                r.MANV,
                r.TENNV,
                r.VAITRO,
            }).FirstOrDefault();
            
            lbTenNV.Text = "Xin chào: " + nv.TENNV.ToString();
            quyen = nv.VAITRO;
            
            if(nv.VAITRO == 1)
            {
                vaitro = "Quản trị";
            }
            else
            {
                vaitro = "Nhân viên";
            }
            lbVaiTro.Text = "Vai trò: " + vaitro;

            if (nv.VAITRO == 0)
            {
                btnNhanVien.Enabled = false;
                btnBaoCao.Enabled = false;
            }
        }

        public void UpdateTenNV(string tenMoi)
        {
            lbTenNV.Text = "Xin chào: " + tenMoi;
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
            childForm.BringToFront();
            childForm.Show();
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhanVien());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachHang(maNV,quyen));
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSanPham(maNV,quyen));
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHoaDon());
        }

       

        private void frmThongTin_Click(object sender, EventArgs e)
        {
            frmBSThongTin bstt = new frmBSThongTin(maNV, this);
            bstt.Show();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap dn = new frmDangNhap();
            dn.Show();
        }
    }
}
