using Microsoft.Reporting.WinForms;
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

namespace SaleManagement.Reports
{
    public partial class frmCTHD : Form
    {
        ModelSale context = new ModelSale();
        DataSet_DA1.HOADONDataTable tbHD = new DataSet_DA1.HOADONDataTable();
        string maHD;
        public frmCTHD(string mahd)
        {
            InitializeComponent();
            maHD = mahd;
        }

        private void frmCTHD_Load(object sender, EventArgs e)
        {

            var cthd = (from hd in context.HOADON
                        join nv in context.NHANVIEN on hd.MANV equals nv.MANV
                        join kh in context.KHACHHANG on hd.MAKH equals kh.MAKH
                        join ct in context.CHITIETHD on hd.MAHD equals ct.MAHD
                        join sp in context.SANPHAM on ct.MASP equals sp.MASP
                        where hd.MAHD == maHD.ToString()
                        select new
                        {
                            hd.MAHD,
                            hd.NGAYTAO,
                            hd.TONGTIEN,
                            kh.TENKH,
                            nv.TENNV,
                            sp.TENSP,
                            sp.GIABAN,
                            ct.SOLUONG,
                            ct.THANHTIEN,
                        }).ToList();

            if (cthd.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để hiển thị trong báo cáo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            tbHD.Clear();

            foreach (var i in cthd)
            {
                var newRow = tbHD.NewHOADONRow();
                newRow.MAHD = i.MAHD;
                newRow.NGAYTAO = i.NGAYTAO;
                newRow.TONGTIEN = i.TONGTIEN;
                newRow.TENKH = i.TENKH;
                newRow.TENNV = i.TENNV;
                newRow.TENSP = i.TENSP; 
                newRow.GIABAN = i.GIABAN;
                newRow.SOLUONG = i.SOLUONG;
                newRow.THANHTIEN = i.THANHTIEN;
                tbHD.Rows.Add(newRow);
            }
            reportView.LocalReport.EnableExternalImages = true;
            reportView.LocalReport.ReportPath = "Reports/rpHoaDon.rdlc";
            reportView.LocalReport.DataSources.Clear();
            reportView.LocalReport.DataSources.Add(new ReportDataSource("DataSet1",(DataTable)tbHD));
            reportView.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportView.RefreshReport();

        }
    }
}
