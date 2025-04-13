using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaleManagement.Model;

namespace SaleManagement.Froms
{
    public partial class frmHoaDon : Form
    {
        ModelSale context = new ModelSale();
        string maHD;
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            loadHoaDon();
        }

        private void loadHoaDon(string tenkh = "")
        {
            var hoadon = (from hd in context.HOADON
                          join kh in context.KHACHHANG on hd.MAKH equals kh.MAKH
                          join nv in context.NHANVIEN on hd.MANV equals nv.MANV 
                          orderby hd.MAHD descending
                          select new
                          {
                              hd.MAHD,
                              kh.TENKH,
                              hd.NGAYTAO,
                              hd.TONGTIEN,
                              nv.TENNV,
                          });

            if (!string.IsNullOrEmpty(tenkh))
            {
                hoadon = hoadon.Where(hd => hd.TENKH.Contains(tenkh));
            }

            dtgvHoaDon.AutoGenerateColumns = false;
            dtgvHoaDon.DataSource = hoadon.ToList();
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            loadHoaDon(txtTenKH.Text.Trim());
        }

        private void btnXemCT_Click(object sender, EventArgs e)
        {
            if (maHD != null)
            {
                Reports.frmCTHD ct = new Reports.frmCTHD(maHD.ToString());
                ct.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn trước!");
            }
        }

        private void dtgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                maHD = dtgvHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
    }
}
