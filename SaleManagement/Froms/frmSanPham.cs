using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms.Suite;
using SaleManagement.Model;

namespace SaleManagement.Froms
{
    public partial class frmSanPham : Form
    {
        ModelSale context = new ModelSale();
        private bool ThemDL;
        private string masp = "";
        private int Quyen;
        private int maNV;
        public frmSanPham(int manv, int quyen)
        {
            InitializeComponent();
            maNV = manv;
            Quyen = quyen;
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            setValue();
            disable(false);
            loadData();
            loadDanhMuc();

            var nv = (from n in context.NHANVIEN
                      where n.MANV == maNV
                      select new
                      {
                          n.MANV,
                          n.TENNV,
                      }).ToList();

            txtNguoiNhap.Text = nv.First().TENNV;
            if(Quyen == 0)
            {
                btnXoa.Enabled = false;
                btnCapNhat.Enabled = false;
            }
        }

        private void setValue()
        {
            txtGiaNhap.Text = "";
            txtSLNhap.Text = "";
            txtThanhTien.Text = "";
            txtHinhAnh.Text = "";
            txtTenSP.Text = "";
            txtSLTon.Text = "";
            txtGiaBan.Text = "";
            txtGhiChu.Text = "";
            picHinhAnh.Image = null;
        }

        private void disable(bool gt)
        {
            txtGiaNhap.Enabled = gt;
            txtSLNhap.Enabled = gt;
            txtTenSP.Enabled = gt;
            txtGiaBan.Enabled = gt;
            txtGhiChu.Enabled = gt;
            cbxDanhMuc.Enabled = gt;
            dtpkNgayNhap.Enabled = gt;

            btnChon.Enabled = gt;
            btnThem.Enabled = !gt;
            btnCapNhat.Enabled = !gt;
            btnXoa.Enabled = !gt;
            btnLuu.Enabled = gt;
        }

        private void disableCN(bool gt)
        {
            txtTenSP.Enabled = gt;
            txtGiaBan.Enabled = gt;
            txtGhiChu.Enabled = gt;
            btnChon.Enabled = gt;
            btnLuu.Enabled = gt;
            btnThem.Enabled = !gt;
            btnXoa.Enabled = !gt;
            btnCapNhat.Enabled = !gt;
        }

        private void loadData()
        {
            var sanpham = (from sp in context.SANPHAM
                           join dm in context.DANHMUCSP on sp.IDDanhMuc equals dm.IDDanhMuc
                           select new
                           {
                               sp.MASP,
                               sp.TENSP,
                               sp.SOLUONGTON,
                               sp.GIABAN,
                               sp.GHICHU,
                               hinhanh = sp.HINHANH.Trim(),
                               dm.IDDanhMuc,
                               dm.TENDM,
                           }).ToList();


            dtgvSanPham.AutoGenerateColumns = false;
            dtgvSanPham.DataSource = sanpham;
        }

        private void loadDanhMuc()
        {
            List<DANHMUCSP> dm = new List<DANHMUCSP>();
            dm = context.DANHMUCSP.ToList();
            cbxDanhMuc.DataSource = dm;
            cbxDanhMuc.DisplayMember = "TENDM";
            cbxDanhMuc.ValueMember = "IDDanhMuc";
            cbxDanhMuc.SelectedIndex = -1;


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            setValue();
            disable(true);
            ThemDL = true;

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            ThemDL = false;
            disableCN(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenSP.Text))
            {
                MessageBox.Show("Vui long chon san pham can xoa");
                return;
            }
            else
            {
                int maspInt = int.Parse(masp);
                var nhapspList = context.NHAPSP.Where(n => n.MASP == maspInt).ToList();
                if (nhapspList.Any())
                {
                    context.NHAPSP.RemoveRange(nhapspList);
                    context.SaveChanges();
                }

                SANPHAM sp = context.SANPHAM.Find(int.Parse(masp));
                if (sp != null)
                {
                    context.SANPHAM.Remove(sp);
                    context.SaveChanges();
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
                frmSanPham_Load(sender, e);
            }
        }

        private bool ktDuLieu()
        {
            if (string.IsNullOrEmpty(txtTenSP.Text))
            {
                MessageBox.Show("Vui long nhap ten san pham");
                return false;
            }
            else if (string.IsNullOrEmpty(txtGiaBan.Text))
            {
                MessageBox.Show("Vui long nhap gia ban");
                return false;
            }
            else if (string.IsNullOrEmpty(txtGiaNhap.Text))
            {
                MessageBox.Show("Vui long nhap gia nhap");
                return false;
            }
            else if (string.IsNullOrEmpty(txtSLNhap.Text))
            {
                MessageBox.Show("Vui long nhap so luong nhap");
                return false;
            }
            else if (int.Parse(txtGiaBan.Text) <= int.Parse(txtGiaNhap.Text))
            {
                MessageBox.Show("gia ban phai lon hon gia nhap");
                return false;
            }
            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ktDuLieu())
            {
                try
                {
                    if (ThemDL == true)
                    {
                        SANPHAM sp = new SANPHAM
                        {
                            TENSP = txtTenSP.Text,
                            SOLUONGTON = int.Parse(txtSLNhap.Text),
                            GIABAN = int.Parse(txtGiaBan.Text),
                            GHICHU = txtGhiChu.Text,
                            HINHANH = txtHinhAnh.Text,
                            IDDanhMuc = int.Parse(cbxDanhMuc.SelectedValue.ToString())
                        };
                        context.SANPHAM.Add(sp);
                        context.SaveChanges();
                        masp = sp.MASP.ToString();
                        NHAPSP nsp = new NHAPSP
                        {
                            MASP = int.Parse(masp),
                            GIANHAP = int.Parse(txtGiaNhap.Text),
                            NGAYNHAP = dtpkNgayNhap.Value,
                            SOLUONG = int.Parse(txtSLNhap.Text),
                            THANHTIEN = int.Parse(txtThanhTien.Text),
                            MANV = maNV,
                        };
                        context.NHAPSP.Add(nsp);
                        context.SaveChanges();
                        MessageBox.Show("Them thanh cong");
                    }
                    else
                    {
                        SANPHAM sp = context.SANPHAM.Find(int.Parse(masp));
                        if (sp != null)
                        {
                            sp.TENSP = txtTenSP.Text;
                            sp.GIABAN = int.Parse(txtGiaBan.Text);
                            sp.GHICHU = txtGhiChu.Text;
                            sp.HINHANH = txtHinhAnh.Text;
                            sp.IDDanhMuc = int.Parse(cbxDanhMuc.SelectedValue.ToString());
                            context.SaveChanges();
                            MessageBox.Show("Cap nhat thanh cong");
                        }
                        else
                        {
                            MessageBox.Show("Cap nhat that bai");
                        }
                    }
                    frmSanPham_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Loi");
                    return;
                }
            }

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmSanPham_Load(sender, e);
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Chọn hình ảnh LOGO",
                Filter = "Hình ảnh|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName; // Đường dẫn ảnh người dùng chọn
                string targetDirectory = Path.Combine(Application.StartupPath, "Resources", "Image");
                string fileName = Path.GetFileName(selectedFilePath); // Lấy tên file
                string targetFilePath = Path.Combine(targetDirectory, fileName); // Đường dẫn lưu trữ ảnh

                // Tạo thư mục nếu chưa tồn tại
                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                }

                // Kiểm tra nếu ảnh đã tồn tại
                if (File.Exists(targetFilePath))
                {
                    DialogResult result = MessageBox.Show("Ảnh đã tồn tại! Bạn có muốn sử dụng ảnh này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        return; // Không làm gì nếu người dùng chọn "No"
                    }
                }
                else
                {
                    try
                    {
                        File.Copy(selectedFilePath, targetFilePath, true); // Sao chép ảnh nếu chưa tồn tại
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Lỗi khi sao chép ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Hiển thị ảnh trong giao diện
                txtHinhAnh.Text = fileName; // Chỉ lưu tên file vào database
                picHinhAnh.ImageLocation = targetFilePath; // Hiển thị ảnh trong PictureBox
            }
        }

        private void txtGiaNhap_TextChanged(object sender, EventArgs e)
        {
            int gianhap, soluong, giaban = 0;

            if (txtGiaNhap.Text == "")
            {
                txtThanhTien.Text = "";
                return;
            }
            else
            {
                if (int.TryParse(txtGiaNhap.Text, out giaban) == true)
                {
                    if (giaban <= 0)
                    {
                        MessageBox.Show("Gia nhap phai lon hon 0");
                        txtGiaNhap.Text = "";
                        return;
                    }
                    float gb = giaban * 1.2f;
                    txtGiaBan.Text = ((int)gb).ToString();
                }
                else
                {
                    MessageBox.Show("Gia nhap phai la so");
                    txtGiaNhap.Text = "";
                    return;
                }
            }
            if (txtSLNhap.Text != "")
            {
                if (int.TryParse(txtGiaNhap.Text, out gianhap) == true)
                {
                    if (int.TryParse(txtSLNhap.Text, out soluong) == true)
                    {
                        int thanhtien = gianhap * soluong;
                        txtThanhTien.Text = thanhtien.ToString();
                    }
                    else
                    {
                        MessageBox.Show("So luong phai la so");
                        txtSLNhap.Text = "";
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Gia nhap phai la so");
                    txtGiaNhap.Text = "";
                    return;
                }
            }
        }

        private void txtSLNhap_TextChanged(object sender, EventArgs e)
        {
            int dg = 0;
            int sl = 0;
            if (txtSLNhap.Text == "")
            {
                txtThanhTien.Text = "";
                return;
            }
            else
            {
                if (int.TryParse(txtSLNhap.Text, out sl) == false)
                {
                    MessageBox.Show("Số lượng phải là số.");
                    txtSLNhap.Text = "";
                    return;
                }
                else
                {
                    if (sl <= 0)
                    {
                        MessageBox.Show("Số lượng phải lớn hơn 0.");
                        txtSLNhap.Text = "";
                        return;
                    }
                }
            }
            if (txtGiaNhap.Text != "")
            {
                if (int.TryParse(txtSLNhap.Text, out sl) == true)
                {
                    if (int.TryParse(txtGiaNhap.Text, out dg) == true)
                    {
                        int thanhtien = dg * sl;
                        txtThanhTien.Text = thanhtien.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Đơn giá phải là số.");
                        txtGiaNhap.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Số lượng phải là số.");
                    txtSLNhap.Text = "";
                }

            }
        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {
            int gb = 0;
            if (txtGiaBan.Text == "")
            {
                return;
            }
            if (int.TryParse(txtGiaBan.Text, out gb) == false)
            {
                MessageBox.Show("Giá bán phải là số");
                txtGiaBan.Text = "";
                return;
            }
        }

        private void dtgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {

                    masp = dtgvSanPham.Rows[e.RowIndex].Cells["MASP1"].Value.ToString(); ;
                    txtTenSP.Text = dtgvSanPham.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtSLTon.Text = dtgvSanPham.Rows[e.RowIndex].Cells[2].Value.ToString();
                    decimal giaBanDecimal = Convert.ToDecimal(dtgvSanPham.Rows[e.RowIndex].Cells[3].Value);
                    int giaBanInt = Convert.ToInt32(giaBanDecimal); // Chuyển decimal -> int
                    txtGiaBan.Text = giaBanInt.ToString();
                    txtGhiChu.Text = dtgvSanPham.Rows[e.RowIndex].Cells[4].Value.ToString();
                    string filename = dtgvSanPham.Rows[e.RowIndex].Cells[5].Value.ToString();
                    cbxDanhMuc.SelectedValue = int.Parse(dtgvSanPham.Rows[e.RowIndex].Cells[6].Value.ToString());
                    txtHinhAnh.Text = filename;

                    if (!string.IsNullOrEmpty(filename))
                    {
                        string imagePath = Path.Combine(Application.StartupPath, "Images", filename);

                        if (File.Exists(imagePath)) // Kiểm tra file tồn tại
                        {
                            picHinhAnh.Image = Image.FromFile(imagePath);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy hình ảnh!");
                            picHinhAnh.Image = null; // Xóa ảnh nếu file không tồn tại
                        }
                    }
                    else
                    {
                        picHinhAnh.Image = null; // Xóa ảnh nếu không có đường dẫn
                    }

                    if (int.TryParse(masp, out int maSanPham))
                    {
                        var nhapsp = context.NHAPSP
                                        .Where(nsp => nsp.MASP == maSanPham)
                                        .Select(nsp => new
                                        {
                                            nsp.GIANHAP,
                                            nsp.NGAYNHAP,
                                            nsp.SOLUONG,
                                            nsp.THANHTIEN
                                        })
                                        .FirstOrDefault();

                        if (nhapsp != null)
                        {
                            txtGiaNhap.Text = Convert.ToInt32(nhapsp.GIANHAP).ToString();
                            dtpkNgayNhap.Text = nhapsp.NGAYNHAP.ToString();
                            txtSLNhap.Text = nhapsp.SOLUONG.ToString();
                            txtThanhTien.Text = Convert.ToInt32(nhapsp.THANHTIEN).ToString();
                        }
                        else
                        {
                            txtGiaNhap.Text = ""; // Nếu không tìm thấy dữ liệu, xóa nội dung
                        }
                    }
                    else
                    {
                        txtGiaNhap.Text = ""; // Nếu `masp` không hợp lệ, xóa nội dung
                    }
                }
            }
            catch
            {
                MessageBox.Show("Loi");
            }
        }


    }
}
