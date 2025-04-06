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
namespace SaleManagement
{
    public partial class frmMain : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DA1_SaleManagement;Integrated Security=True;Encrypt=False;");
        SqlDataAdapter adp;
        private Form currentFormChild;
        public string kt;
        private int quyen;
        private int manv;
        public frmMain(int Quyen)
        {
            InitializeComponent();
            this.quyen = Quyen;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM NHANVIEN WHERE VAITRO =  " + quyen + " ";
            adp = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            lbTenNV.Text = dt.Rows[0]["TENNV"].ToString();
            manv = int.Parse(dt.Rows[0]["MANV"].ToString());
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
            OpenChildForm(new frmKhachHang(manv));
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSanPham(manv));
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHoaDon());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
        }
    }
}
