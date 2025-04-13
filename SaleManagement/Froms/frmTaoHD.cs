using SaleManagement.Model;
using SaleManagement.Reports;
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
    public partial class frmTaoHD : Form
    {
        ModelSale context = new ModelSale();
        private int maKH;
        private int maNV;
        string maHoaDon;
        public frmTaoHD(int makh, int manv)
        {
            InitializeComponent();
            maKH = makh;
            maNV = manv;
        }

        private void frmTaoHD_Load(object sender, EventArgs e)
        {
            loadDanhMuc();
            loadKhachHang();
            loadNguoiTao();
            btnInHD.Enabled = false;
            txtTongTien.Text = "";
        }

        private void loadDanhMuc()
        {
            List<DANHMUCSP> dm = new List<DANHMUCSP>();
            dm = context.DANHMUCSP.ToList();
            cbxDanhMuc.DataSource = dm;
            cbxDanhMuc.DisplayMember = "tendm";
            cbxDanhMuc.ValueMember = "iddanhmuc";
            cbxDanhMuc.SelectedIndex = -1;
        }

        private void loadKhachHang()
        {
            int makhach = int.Parse(maKH.ToString());
            var khachhang = (from kh in context.KHACHHANG
                             where kh.MAKH == makhach
                             select new
                             {
                                 kh.TENKH,
                                 kh.SDT,
                             }).FirstOrDefault();
            txtTenKH.Text = khachhang.TENKH;
            txtSDT.Text = khachhang.SDT;
        }

        private void loadNguoiTao()
        {
            int manhanvien = int.Parse(maNV.ToString());
            var nhanvien = context.NHANVIEN.Where(r => r.MANV == manhanvien)
                                            .Select(r => r.TENNV).FirstOrDefault();
            txtNguoiTao.Text = nhanvien;
        }

        private void loadSanPham()
        {
            int iddm = int.Parse(cbxDanhMuc.SelectedValue.ToString());
            var sanpham = context.SANPHAM.Where(r => r.IDDanhMuc == iddm && r.SOLUONGTON > 0)
                                         .Select(r => new
                                         {
                                             r.MASP,
                                             r.TENSP,
                                             r.SOLUONGTON,
                                             r.GIABAN,
                                         }).ToList();

            dtgvSanPham.AutoGenerateColumns = false;
            dtgvSanPham.DataSource = sanpham;
            txtTongTien.Text = "0.00";
        }

        private string generateMaHD()
        {
            var lastInvoice = context.HOADON.OrderByDescending(r => r.MAHD).FirstOrDefault();

            if (lastInvoice == null)
            {
                return "HD001";
            }

            string lastMahd = lastInvoice.MAHD;
            int lastNumber = int.Parse(lastMahd.Substring(2));
            return $"HD{(lastNumber + 1):D3}";
        }

        private void cbxDanhMuc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadSanPham();
        }

        private void dtgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0) // Cột checkbox "chkSP"
            {
                if (cbxDanhMuc.SelectedIndex == -1 || cbxDanhMuc.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn danh mục trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Không thực hiện hành động tiếp theo
                }
                dtgvSanPham.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dtgvSanPham_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvSanPham.Rows.Count == 0 || e.RowIndex < 0) return;

            DataGridViewRow row = dtgvSanPham.Rows[e.RowIndex];
            if (e.ColumnIndex == dtgvSanPham.Columns["chkSP"].Index)
            {
                bool isChecked = Convert.ToBoolean(row.Cells["chkSP"].Value);
                row.Cells["soluongmua"].Value = isChecked ? 1 : 0; // Mặc định 1 khi chọn

                UpdateTongTien();
            }

            if (e.ColumnIndex == dtgvSanPham.Columns["soluongmua"].Index)
            {
                int soluong = Convert.ToInt32(row.Cells["soluongmua"].Value);
                int soluongTon = Convert.ToInt32(row.Cells["soluongton"].Value);

                // Kiểm tra số lượng không vượt quá tồn kho
                if (soluong > soluongTon)
                {
                    MessageBox.Show($"Số lượng không được vượt quá {soluongTon}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    row.Cells["soluongmua"].Value = soluongTon; // Đặt lại về tối đa
                }
                UpdateTongTien();
            }
        }

        private void UpdateTongTien()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dtgvSanPham.Rows)
            {
                bool isChecked = Convert.ToBoolean(row.Cells["chkSP"].Value);
                if (isChecked)
                {
                    int soluong = Convert.ToInt32(row.Cells["soluongmua"].Value);
                    decimal giaban = Convert.ToDecimal(row.Cells["giaban"].Value);
                    total += soluong * giaban;
                }
            }

        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {

            bool selectSP = false;
            btnInHD.Enabled = true;

            if (cbxDanhMuc.SelectedIndex == -1 || cbxDanhMuc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn danh mục trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Không thực hiện hành động tiếp theo
            }

            foreach (DataGridViewRow row in dtgvSanPham.Rows)
            {
                if (row.Cells["chkSP"].Value != null && Convert.ToBoolean(row.Cells["chkSP"].Value))
                {
                    selectSP = true;
                    int soluong = 0;
                    if (row.Cells["soluongmua"].Value == null || !int.TryParse(row.Cells["soluongmua"].Value.ToString(), out soluong) || soluong <= 0)
                    {
                        string tensp = row.Cells["tensp"].Value?.ToString() ?? "Sản phẩm";
                        MessageBox.Show($"Sản phẩm \"{tensp}\" có số lượng không hợp lệ (≤ 0). Vui lòng kiểm tra lại.", "Lỗi số lượng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    break;
                }
            }

            if (!selectSP)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                 maHoaDon = generateMaHD();
                HOADON hd = new HOADON()
                {
                    MAHD = maHoaDon,
                    MAKH = maKH,
                    NGAYTAO = dateTimePicker1.Value,
                    TONGTIEN = Convert.ToDecimal(txtTongTien.Text),
                    MANV = maNV,
                };

                context.HOADON.Add(hd);

                foreach(DataGridViewRow row in dtgvSanPham.Rows)
                {
                    if (row.Cells["chkSP"].Value != null && Convert.ToBoolean(row.Cells["chkSP"].Value))
                    {
                        int masp = Convert.ToInt32(row.Cells["masp"].Value);
                        int soluongmua = Convert.ToInt32(row.Cells["soluongmua"].Value);
                        decimal giaban = Convert.ToDecimal(row.Cells["giaban"].Value);
                        decimal thanhtien = soluongmua * giaban;

                        CHITIETHD cthd = new CHITIETHD()
                        {
                            MAHD = maHoaDon,
                            MASP = masp,
                            SOLUONG = soluongmua,
                            THANHTIEN = thanhtien,
                        };

                        context.CHITIETHD.Add(cthd);

                        var sanpham = context.SANPHAM.FirstOrDefault(r => r.MASP == masp);

                        if(sanpham != null)
                        {
                            sanpham.SOLUONGTON -= soluongmua;
                        }
                    }
                }
                context.SaveChanges();
                MessageBox.Show("Tạo hóa đơn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (DataGridViewRow row in dtgvSanPham.Rows)
                {
                    row.Cells["chkSP"].Value = false;
                    row.Cells["soluongmua"].Value = 0; // Đặt lại số lượng về 0 hoặc giá trị mặc định
                }

               
            }
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            frmCTHD cthd = new frmCTHD(maHoaDon);
            cthd.Show();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmTaoHD_Load(sender,e);
        }
    }
}
