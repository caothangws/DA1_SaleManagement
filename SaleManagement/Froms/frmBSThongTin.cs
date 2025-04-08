using SaleManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement.Froms
{
    public partial class frmBSThongTin : Form
    {
        ModelSale context = new ModelSale();
        int maNV;
        private frmMain frmMain;
        
        public frmBSThongTin(int manv, frmMain main)
        {
            InitializeComponent();
            maNV = manv;
            frmMain = main;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var nv = context.NHANVIEN.FirstOrDefault(r => r.MANV == maNV);

            if(nv != null)
            {
                nv.TENNV = txtTenNV.Text;
                nv.EMAIL = txtEmail.Text;
                nv.SDT = txtSDT.Text;
                nv.DIACHI = txtDiaChi.Text;
                nv.NGAYSINH = dtpkNgaySinh.Value;

                context.SaveChanges();
                frmMain.UpdateTenNV(nv.TENNV);
                MessageBox.Show("Da cap nhat thong tin");
                this.Close();
            }
        }

        private void frmBSThongTin_Load(object sender, EventArgs e)
        {
            var tt = (from nv in context.NHANVIEN
                      where nv.MANV == maNV
                      select new
                      {
                          nv.TENNV,
                          nv.EMAIL,
                          nv.SDT,
                          nv.DIACHI,
                          nv.NGAYSINH,
                      }).FirstOrDefault();

            if(tt != null)
            {
                txtTenNV.Text = tt.TENNV.ToString() ?? null;
                txtEmail.Text = tt.EMAIL?.ToString() ?? string.Empty;
                txtDiaChi.Text = tt.DIACHI?.ToString() ?? string.Empty;
                txtSDT.Text = tt.SDT?.ToString() ?? string.Empty;
                dtpkNgaySinh.Value = tt.NGAYSINH  ;
            }
            
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
