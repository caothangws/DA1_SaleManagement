<<<<<<< HEAD
﻿namespace AppBanDongHo
{
    partial class frmSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label maSPLabel;
            System.Windows.Forms.Label tenSPLabel;
            System.Windows.Forms.Label soLuongLabel;
            System.Windows.Forms.Label giaNhapLabel;
            System.Windows.Forms.Label giaBanLabel;
            System.Windows.Forms.Label hinhAnhLabel;
            System.Windows.Forms.Label ghiChuLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picSP = new System.Windows.Forms.PictureBox();
            this.btnOpenHinhAnh = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.doAn1_BanDongHoDataSet = new AppBanDongHo.DoAn1_BanDongHoDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTK = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnHTall = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnBoqua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLuu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnXoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dtgvSanPham = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileHinhAnh = new System.Windows.Forms.OpenFileDialog();
            maSPLabel = new System.Windows.Forms.Label();
            tenSPLabel = new System.Windows.Forms.Label();
            soLuongLabel = new System.Windows.Forms.Label();
            giaNhapLabel = new System.Windows.Forms.Label();
            giaBanLabel = new System.Windows.Forms.Label();
            hinhAnhLabel = new System.Windows.Forms.Label();
            ghiChuLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAn1_BanDongHoDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // maSPLabel
            // 
            maSPLabel.AutoSize = true;
            maSPLabel.BackColor = System.Drawing.Color.Transparent;
            maSPLabel.Location = new System.Drawing.Point(74, 51);
            maSPLabel.Name = "maSPLabel";
            maSPLabel.Size = new System.Drawing.Size(118, 23);
            maSPLabel.TabIndex = 0;
            maSPLabel.Text = "Mã sản phẩm:";
            // 
            // tenSPLabel
            // 
            tenSPLabel.AutoSize = true;
            tenSPLabel.BackColor = System.Drawing.Color.Transparent;
            tenSPLabel.Location = new System.Drawing.Point(71, 102);
            tenSPLabel.Name = "tenSPLabel";
            tenSPLabel.Size = new System.Drawing.Size(120, 23);
            tenSPLabel.TabIndex = 2;
            tenSPLabel.Text = "Tên sản phẩm:";
            // 
            // soLuongLabel
            // 
            soLuongLabel.AutoSize = true;
            soLuongLabel.BackColor = System.Drawing.Color.Transparent;
            soLuongLabel.Location = new System.Drawing.Point(74, 155);
            soLuongLabel.Name = "soLuongLabel";
            soLuongLabel.Size = new System.Drawing.Size(82, 23);
            soLuongLabel.TabIndex = 4;
            soLuongLabel.Text = "Số lượng:";
            // 
            // giaNhapLabel
            // 
            giaNhapLabel.AutoSize = true;
            giaNhapLabel.BackColor = System.Drawing.Color.Transparent;
            giaNhapLabel.Location = new System.Drawing.Point(75, 206);
            giaNhapLabel.Name = "giaNhapLabel";
            giaNhapLabel.Size = new System.Drawing.Size(86, 23);
            giaNhapLabel.TabIndex = 6;
            giaNhapLabel.Text = "Giá Nhập:";
            // 
            // giaBanLabel
            // 
            giaBanLabel.AutoSize = true;
            giaBanLabel.BackColor = System.Drawing.Color.Transparent;
            giaBanLabel.Location = new System.Drawing.Point(75, 255);
            giaBanLabel.Name = "giaBanLabel";
            giaBanLabel.Size = new System.Drawing.Size(73, 23);
            giaBanLabel.TabIndex = 8;
            giaBanLabel.Text = "Giá Bán:";
            // 
            // hinhAnhLabel
            // 
            hinhAnhLabel.AutoSize = true;
            hinhAnhLabel.BackColor = System.Drawing.Color.Transparent;
            hinhAnhLabel.Location = new System.Drawing.Point(624, 38);
            hinhAnhLabel.Name = "hinhAnhLabel";
            hinhAnhLabel.Size = new System.Drawing.Size(84, 23);
            hinhAnhLabel.TabIndex = 10;
            hinhAnhLabel.Text = "Hình ảnh:";
            // 
            // ghiChuLabel
            // 
            ghiChuLabel.AutoSize = true;
            ghiChuLabel.Location = new System.Drawing.Point(624, 192);
            ghiChuLabel.Name = "ghiChuLabel";
            ghiChuLabel.Size = new System.Drawing.Size(76, 23);
            ghiChuLabel.TabIndex = 12;
            ghiChuLabel.Text = "Ghi Chú:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.picSP);
            this.groupBox1.Controls.Add(this.btnOpenHinhAnh);
            this.groupBox1.Controls.Add(ghiChuLabel);
            this.groupBox1.Controls.Add(this.txtGhichu);
            this.groupBox1.Controls.Add(hinhAnhLabel);
            this.groupBox1.Controls.Add(giaBanLabel);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(giaNhapLabel);
            this.groupBox1.Controls.Add(this.txtGiaNhap);
            this.groupBox1.Controls.Add(soLuongLabel);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(tenSPLabel);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(maSPLabel);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 335);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // picSP
            // 
            this.picSP.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picSP.Location = new System.Drawing.Point(789, 29);
            this.picSP.Name = "picSP";
            this.picSP.Size = new System.Drawing.Size(175, 134);
            this.picSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSP.TabIndex = 14;
            this.picSP.TabStop = false;
            this.picSP.Click += new System.EventHandler(this.picSP_Click);
            // 
            // btnOpenHinhAnh
            // 
            this.btnOpenHinhAnh.CheckedState.Parent = this.btnOpenHinhAnh;
            this.btnOpenHinhAnh.CustomImages.Parent = this.btnOpenHinhAnh;
            this.btnOpenHinhAnh.FillColor = System.Drawing.Color.Black;
            this.btnOpenHinhAnh.FillColor2 = System.Drawing.Color.Gray;
            this.btnOpenHinhAnh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenHinhAnh.ForeColor = System.Drawing.Color.White;
            this.btnOpenHinhAnh.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnOpenHinhAnh.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.btnOpenHinhAnh.HoverState.Parent = this.btnOpenHinhAnh;
            this.btnOpenHinhAnh.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenHinhAnh.Image")));
            this.btnOpenHinhAnh.Location = new System.Drawing.Point(616, 71);
            this.btnOpenHinhAnh.Name = "btnOpenHinhAnh";
            this.btnOpenHinhAnh.ShadowDecoration.Parent = this.btnOpenHinhAnh;
            this.btnOpenHinhAnh.Size = new System.Drawing.Size(146, 45);
            this.btnOpenHinhAnh.TabIndex = 3;
            this.btnOpenHinhAnh.Text = "Mở hình";
            this.btnOpenHinhAnh.Click += new System.EventHandler(this.btnOpenHinhAnh_Click);
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(789, 192);
            this.txtGhichu.Multiline = true;
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(175, 123);
            this.txtGhichu.TabIndex = 13;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(235, 248);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(213, 30);
            this.txtGiaBan.TabIndex = 9;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(235, 199);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(213, 30);
            this.txtGiaNhap.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(234, 148);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(213, 30);
            this.txtSoLuong.TabIndex = 5;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(234, 95);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(213, 30);
            this.txtTenSP.TabIndex = 3;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(234, 44);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(213, 30);
            this.txtMaSP.TabIndex = 1;
            // 
            // doAn1_BanDongHoDataSet
            // 
            this.doAn1_BanDongHoDataSet.DataSetName = "DoAn1_BanDongHoDataSet";
            this.doAn1_BanDongHoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Controls.Add(this.btnTK);
            this.groupBox2.Controls.Add(this.btnHTall);
            this.groupBox2.Controls.Add(this.btnBoqua);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(992, 145);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nhập tên sản phẩm:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiem.Location = new System.Drawing.Point(219, 90);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(346, 32);
            this.txtTimKiem.TabIndex = 19;
            this.txtTimKiem.Tag = "";
            // 
            // btnTK
            // 
            this.btnTK.CheckedState.Parent = this.btnTK;
            this.btnTK.CustomImages.Parent = this.btnTK;
            this.btnTK.FillColor = System.Drawing.Color.Black;
            this.btnTK.FillColor2 = System.Drawing.Color.Gray;
            this.btnTK.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.ForeColor = System.Drawing.Color.White;
            this.btnTK.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnTK.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.btnTK.HoverState.Parent = this.btnTK;
            this.btnTK.Image = ((System.Drawing.Image)(resources.GetObject("btnTK.Image")));
            this.btnTK.Location = new System.Drawing.Point(613, 77);
            this.btnTK.Name = "btnTK";
            this.btnTK.ShadowDecoration.Parent = this.btnTK;
            this.btnTK.Size = new System.Drawing.Size(149, 45);
            this.btnTK.TabIndex = 18;
            this.btnTK.Text = "Tìm kiếm";
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // btnHTall
            // 
            this.btnHTall.CheckedState.Parent = this.btnHTall;
            this.btnHTall.CustomImages.Parent = this.btnHTall;
            this.btnHTall.FillColor = System.Drawing.Color.Black;
            this.btnHTall.FillColor2 = System.Drawing.Color.Gray;
            this.btnHTall.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHTall.ForeColor = System.Drawing.Color.White;
            this.btnHTall.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnHTall.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.btnHTall.HoverState.Parent = this.btnHTall;
            this.btnHTall.Image = ((System.Drawing.Image)(resources.GetObject("btnHTall.Image")));
            this.btnHTall.Location = new System.Drawing.Point(815, 77);
            this.btnHTall.Name = "btnHTall";
            this.btnHTall.ShadowDecoration.Parent = this.btnHTall;
            this.btnHTall.Size = new System.Drawing.Size(149, 45);
            this.btnHTall.TabIndex = 17;
            this.btnHTall.Text = "Hiển thị tất cả";
            this.btnHTall.Click += new System.EventHandler(this.btnHTall_Click_1);
            // 
            // btnBoqua
            // 
            this.btnBoqua.CheckedState.Parent = this.btnBoqua;
            this.btnBoqua.CustomImages.Parent = this.btnBoqua;
            this.btnBoqua.FillColor = System.Drawing.Color.Black;
            this.btnBoqua.FillColor2 = System.Drawing.Color.Gray;
            this.btnBoqua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoqua.ForeColor = System.Drawing.Color.White;
            this.btnBoqua.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnBoqua.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.btnBoqua.HoverState.Parent = this.btnBoqua;
            this.btnBoqua.Image = ((System.Drawing.Image)(resources.GetObject("btnBoqua.Image")));
            this.btnBoqua.Location = new System.Drawing.Point(815, 22);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.ShadowDecoration.Parent = this.btnBoqua;
            this.btnBoqua.Size = new System.Drawing.Size(149, 45);
            this.btnBoqua.TabIndex = 15;
            this.btnBoqua.Text = "Bỏ Qua";
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.CheckedState.Parent = this.btnLuu;
            this.btnLuu.CustomImages.Parent = this.btnLuu;
            this.btnLuu.FillColor = System.Drawing.Color.Black;
            this.btnLuu.FillColor2 = System.Drawing.Color.Gray;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnLuu.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.btnLuu.HoverState.Parent = this.btnLuu;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(613, 22);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ShadowDecoration.Parent = this.btnLuu;
            this.btnLuu.Size = new System.Drawing.Size(149, 45);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.CheckedState.Parent = this.btnSua;
            this.btnSua.CustomImages.Parent = this.btnSua;
            this.btnSua.FillColor = System.Drawing.Color.Black;
            this.btnSua.FillColor2 = System.Drawing.Color.Gray;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnSua.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.btnSua.HoverState.Parent = this.btnSua;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(416, 22);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(149, 45);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.Black;
            this.btnXoa.FillColor2 = System.Drawing.Color.Gray;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnXoa.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(219, 22);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(149, 45);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.FillColor = System.Drawing.Color.Black;
            this.btnThem.FillColor2 = System.Drawing.Color.Gray;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnThem.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(28, 22);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(149, 45);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // dtgvSanPham
            // 
            this.dtgvSanPham.AllowUserToOrderColumns = true;
            this.dtgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.SoLuong,
            this.GiaNhap,
            this.GiaBan,
            this.GhiChu,
            this.HinhAnh});
            this.dtgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvSanPham.Location = new System.Drawing.Point(0, 480);
            this.dtgvSanPham.Name = "dtgvSanPham";
            this.dtgvSanPham.RowTemplate.Height = 24;
            this.dtgvSanPham.Size = new System.Drawing.Size(992, 226);
            this.dtgvSanPham.TabIndex = 6;
            this.dtgvSanPham.Click += new System.EventHandler(this.dtgvSanPham_Click);
            // 
            // MaSP
            // 
            this.MaSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.Name = "MaSP";
            // 
            // TenSP
            // 
            this.TenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.Name = "TenSP";
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // GiaNhap
            // 
            this.GiaNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.HeaderText = "Giá nhập";
            this.GiaNhap.Name = "GiaNhap";
            // 
            // GiaBan
            // 
            this.GiaBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.Name = "GiaBan";
            // 
            // GhiChu
            // 
            this.GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // HinhAnh
            // 
            this.HinhAnh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HinhAnh.DataPropertyName = "HinhAnh";
            this.HinhAnh.HeaderText = "Hình ảnh";
            this.HinhAnh.Name = "HinhAnh";
            // 
            // openFileHinhAnh
            // 
            this.openFileHinhAnh.FileName = "openFileDialog1";
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 706);
            this.Controls.Add(this.dtgvSanPham);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSanPham";
            this.Text = "frmSanPham";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAn1_BanDongHoDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DoAn1_BanDongHoDataSet doAn1_BanDongHoDataSet;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvSanPham;
        private Guna.UI2.WinForms.Guna2GradientButton btnOpenHinhAnh;
        private System.Windows.Forms.OpenFileDialog openFileHinhAnh;
        private System.Windows.Forms.PictureBox picSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhAnh;
        private System.Windows.Forms.TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2GradientButton btnTK;
        private Guna.UI2.WinForms.Guna2GradientButton btnHTall;
        private Guna.UI2.WinForms.Guna2GradientButton btnBoqua;
        private Guna.UI2.WinForms.Guna2GradientButton btnLuu;
        private Guna.UI2.WinForms.Guna2GradientButton btnSua;
        private Guna.UI2.WinForms.Guna2GradientButton btnXoa;
        private Guna.UI2.WinForms.Guna2GradientButton btnThem;
        private System.Windows.Forms.Label label1;
    }
=======
﻿namespace AppBanDongHo
{
    partial class frmSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label maSPLabel;
            System.Windows.Forms.Label tenSPLabel;
            System.Windows.Forms.Label soLuongLabel;
            System.Windows.Forms.Label giaNhapLabel;
            System.Windows.Forms.Label giaBanLabel;
            System.Windows.Forms.Label hinhAnhLabel;
            System.Windows.Forms.Label ghiChuLabel;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxPhanLoai = new System.Windows.Forms.ComboBox();
            this.picSP = new System.Windows.Forms.PictureBox();
            this.btnOpenHinhAnh = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTK = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnHTall = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnBoqua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLuu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnXoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dtgvSanPham = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhanLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileHinhAnh = new System.Windows.Forms.OpenFileDialog();
            maSPLabel = new System.Windows.Forms.Label();
            tenSPLabel = new System.Windows.Forms.Label();
            soLuongLabel = new System.Windows.Forms.Label();
            giaNhapLabel = new System.Windows.Forms.Label();
            giaBanLabel = new System.Windows.Forms.Label();
            hinhAnhLabel = new System.Windows.Forms.Label();
            ghiChuLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // maSPLabel
            // 
            maSPLabel.AutoSize = true;
            maSPLabel.BackColor = System.Drawing.Color.Transparent;
            maSPLabel.Location = new System.Drawing.Point(74, 42);
            maSPLabel.Name = "maSPLabel";
            maSPLabel.Size = new System.Drawing.Size(118, 23);
            maSPLabel.TabIndex = 0;
            maSPLabel.Text = "Mã sản phẩm:";
            // 
            // tenSPLabel
            // 
            tenSPLabel.AutoSize = true;
            tenSPLabel.BackColor = System.Drawing.Color.Transparent;
            tenSPLabel.Location = new System.Drawing.Point(71, 93);
            tenSPLabel.Name = "tenSPLabel";
            tenSPLabel.Size = new System.Drawing.Size(120, 23);
            tenSPLabel.TabIndex = 2;
            tenSPLabel.Text = "Tên sản phẩm:";
            // 
            // soLuongLabel
            // 
            soLuongLabel.AutoSize = true;
            soLuongLabel.BackColor = System.Drawing.Color.Transparent;
            soLuongLabel.Location = new System.Drawing.Point(74, 146);
            soLuongLabel.Name = "soLuongLabel";
            soLuongLabel.Size = new System.Drawing.Size(82, 23);
            soLuongLabel.TabIndex = 4;
            soLuongLabel.Text = "Số lượng:";
            // 
            // giaNhapLabel
            // 
            giaNhapLabel.AutoSize = true;
            giaNhapLabel.BackColor = System.Drawing.Color.Transparent;
            giaNhapLabel.Location = new System.Drawing.Point(75, 197);
            giaNhapLabel.Name = "giaNhapLabel";
            giaNhapLabel.Size = new System.Drawing.Size(86, 23);
            giaNhapLabel.TabIndex = 6;
            giaNhapLabel.Text = "Giá Nhập:";
            // 
            // giaBanLabel
            // 
            giaBanLabel.AutoSize = true;
            giaBanLabel.BackColor = System.Drawing.Color.Transparent;
            giaBanLabel.Location = new System.Drawing.Point(75, 246);
            giaBanLabel.Name = "giaBanLabel";
            giaBanLabel.Size = new System.Drawing.Size(73, 23);
            giaBanLabel.TabIndex = 8;
            giaBanLabel.Text = "Giá Bán:";
            // 
            // hinhAnhLabel
            // 
            hinhAnhLabel.AutoSize = true;
            hinhAnhLabel.BackColor = System.Drawing.Color.Transparent;
            hinhAnhLabel.Location = new System.Drawing.Point(624, 38);
            hinhAnhLabel.Name = "hinhAnhLabel";
            hinhAnhLabel.Size = new System.Drawing.Size(84, 23);
            hinhAnhLabel.TabIndex = 10;
            hinhAnhLabel.Text = "Hình ảnh:";
            // 
            // ghiChuLabel
            // 
            ghiChuLabel.AutoSize = true;
            ghiChuLabel.Location = new System.Drawing.Point(624, 192);
            ghiChuLabel.Name = "ghiChuLabel";
            ghiChuLabel.Size = new System.Drawing.Size(76, 23);
            ghiChuLabel.TabIndex = 12;
            ghiChuLabel.Text = "Ghi Chú:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Location = new System.Drawing.Point(74, 292);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 23);
            label2.TabIndex = 15;
            label2.Text = "Phân loại:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.cbxPhanLoai);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.picSP);
            this.groupBox1.Controls.Add(this.btnOpenHinhAnh);
            this.groupBox1.Controls.Add(ghiChuLabel);
            this.groupBox1.Controls.Add(this.txtGhichu);
            this.groupBox1.Controls.Add(hinhAnhLabel);
            this.groupBox1.Controls.Add(giaBanLabel);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(giaNhapLabel);
            this.groupBox1.Controls.Add(this.txtGiaNhap);
            this.groupBox1.Controls.Add(soLuongLabel);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(tenSPLabel);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(maSPLabel);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 335);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // cbxPhanLoai
            // 
            this.cbxPhanLoai.FormattingEnabled = true;
            this.cbxPhanLoai.Location = new System.Drawing.Point(235, 289);
            this.cbxPhanLoai.Name = "cbxPhanLoai";
            this.cbxPhanLoai.Size = new System.Drawing.Size(213, 31);
            this.cbxPhanLoai.TabIndex = 16;
            // 
            // picSP
            // 
            this.picSP.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picSP.Location = new System.Drawing.Point(789, 29);
            this.picSP.Name = "picSP";
            this.picSP.Size = new System.Drawing.Size(175, 134);
            this.picSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSP.TabIndex = 14;
            this.picSP.TabStop = false;
            this.picSP.Click += new System.EventHandler(this.picSP_Click);
            // 
            // btnOpenHinhAnh
            // 
            this.btnOpenHinhAnh.CheckedState.Parent = this.btnOpenHinhAnh;
            this.btnOpenHinhAnh.CustomImages.Parent = this.btnOpenHinhAnh;
            this.btnOpenHinhAnh.FillColor = System.Drawing.Color.Black;
            this.btnOpenHinhAnh.FillColor2 = System.Drawing.Color.Gray;
            this.btnOpenHinhAnh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenHinhAnh.ForeColor = System.Drawing.Color.White;
            this.btnOpenHinhAnh.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnOpenHinhAnh.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.btnOpenHinhAnh.HoverState.Parent = this.btnOpenHinhAnh;
            this.btnOpenHinhAnh.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenHinhAnh.Image")));
            this.btnOpenHinhAnh.Location = new System.Drawing.Point(616, 71);
            this.btnOpenHinhAnh.Name = "btnOpenHinhAnh";
            this.btnOpenHinhAnh.ShadowDecoration.Parent = this.btnOpenHinhAnh;
            this.btnOpenHinhAnh.Size = new System.Drawing.Size(146, 45);
            this.btnOpenHinhAnh.TabIndex = 3;
            this.btnOpenHinhAnh.Text = "Mở hình";
            this.btnOpenHinhAnh.Click += new System.EventHandler(this.btnOpenHinhAnh_Click);
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(789, 192);
            this.txtGhichu.Multiline = true;
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(175, 123);
            this.txtGhichu.TabIndex = 13;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(235, 239);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(213, 30);
            this.txtGiaBan.TabIndex = 9;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(235, 190);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(213, 30);
            this.txtGiaNhap.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(234, 139);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(213, 30);
            this.txtSoLuong.TabIndex = 5;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(234, 86);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(213, 30);
            this.txtTenSP.TabIndex = 3;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(234, 35);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(213, 30);
            this.txtMaSP.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Controls.Add(this.btnTK);
            this.groupBox2.Controls.Add(this.btnHTall);
            this.groupBox2.Controls.Add(this.btnBoqua);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(992, 145);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nhập sản phẩm:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiem.Location = new System.Drawing.Point(219, 90);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(346, 32);
            this.txtTimKiem.TabIndex = 19;
            this.txtTimKiem.Tag = "";
            // 
            // btnTK
            // 
            this.btnTK.CheckedState.Parent = this.btnTK;
            this.btnTK.CustomImages.Parent = this.btnTK;
            this.btnTK.FillColor = System.Drawing.Color.Black;
            this.btnTK.FillColor2 = System.Drawing.Color.Gray;
            this.btnTK.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.ForeColor = System.Drawing.Color.White;
            this.btnTK.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnTK.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.btnTK.HoverState.Parent = this.btnTK;
            this.btnTK.Image = ((System.Drawing.Image)(resources.GetObject("btnTK.Image")));
            this.btnTK.Location = new System.Drawing.Point(613, 77);
            this.btnTK.Name = "btnTK";
            this.btnTK.ShadowDecoration.Parent = this.btnTK;
            this.btnTK.Size = new System.Drawing.Size(149, 45);
            this.btnTK.TabIndex = 18;
            this.btnTK.Text = "Tìm kiếm";
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // btnHTall
            // 
            this.btnHTall.CheckedState.Parent = this.btnHTall;
            this.btnHTall.CustomImages.Parent = this.btnHTall;
            this.btnHTall.FillColor = System.Drawing.Color.Black;
            this.btnHTall.FillColor2 = System.Drawing.Color.Gray;
            this.btnHTall.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHTall.ForeColor = System.Drawing.Color.White;
            this.btnHTall.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnHTall.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.btnHTall.HoverState.Parent = this.btnHTall;
            this.btnHTall.Image = ((System.Drawing.Image)(resources.GetObject("btnHTall.Image")));
            this.btnHTall.Location = new System.Drawing.Point(815, 77);
            this.btnHTall.Name = "btnHTall";
            this.btnHTall.ShadowDecoration.Parent = this.btnHTall;
            this.btnHTall.Size = new System.Drawing.Size(149, 45);
            this.btnHTall.TabIndex = 17;
            this.btnHTall.Text = "Hiển thị tất cả";
            this.btnHTall.Click += new System.EventHandler(this.btnHTall_Click_1);
            // 
            // btnBoqua
            // 
            this.btnBoqua.CheckedState.Parent = this.btnBoqua;
            this.btnBoqua.CustomImages.Parent = this.btnBoqua;
            this.btnBoqua.FillColor = System.Drawing.Color.Black;
            this.btnBoqua.FillColor2 = System.Drawing.Color.Gray;
            this.btnBoqua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoqua.ForeColor = System.Drawing.Color.White;
            this.btnBoqua.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnBoqua.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.btnBoqua.HoverState.Parent = this.btnBoqua;
            this.btnBoqua.Image = ((System.Drawing.Image)(resources.GetObject("btnBoqua.Image")));
            this.btnBoqua.Location = new System.Drawing.Point(815, 22);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.ShadowDecoration.Parent = this.btnBoqua;
            this.btnBoqua.Size = new System.Drawing.Size(149, 45);
            this.btnBoqua.TabIndex = 15;
            this.btnBoqua.Text = "Bỏ Qua";
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.CheckedState.Parent = this.btnLuu;
            this.btnLuu.CustomImages.Parent = this.btnLuu;
            this.btnLuu.FillColor = System.Drawing.Color.Black;
            this.btnLuu.FillColor2 = System.Drawing.Color.Gray;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnLuu.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.btnLuu.HoverState.Parent = this.btnLuu;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(613, 22);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ShadowDecoration.Parent = this.btnLuu;
            this.btnLuu.Size = new System.Drawing.Size(149, 45);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.CheckedState.Parent = this.btnSua;
            this.btnSua.CustomImages.Parent = this.btnSua;
            this.btnSua.FillColor = System.Drawing.Color.Black;
            this.btnSua.FillColor2 = System.Drawing.Color.Gray;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnSua.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.btnSua.HoverState.Parent = this.btnSua;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(416, 22);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(149, 45);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.Black;
            this.btnXoa.FillColor2 = System.Drawing.Color.Gray;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnXoa.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(219, 22);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(149, 45);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.FillColor = System.Drawing.Color.Black;
            this.btnThem.FillColor2 = System.Drawing.Color.Gray;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnThem.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(28, 22);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(149, 45);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // dtgvSanPham
            // 
            this.dtgvSanPham.AllowUserToOrderColumns = true;
            this.dtgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.PhanLoai,
            this.TenSP,
            this.SoLuong,
            this.GiaNhap,
            this.GiaBan,
            this.GhiChu,
            this.HinhAnh});
            this.dtgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvSanPham.Location = new System.Drawing.Point(0, 480);
            this.dtgvSanPham.Name = "dtgvSanPham";
            this.dtgvSanPham.RowTemplate.Height = 24;
            this.dtgvSanPham.Size = new System.Drawing.Size(992, 226);
            this.dtgvSanPham.TabIndex = 6;
            this.dtgvSanPham.Click += new System.EventHandler(this.dtgvSanPham_Click);
            // 
            // MaSP
            // 
            this.MaSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.Name = "MaSP";
            // 
            // PhanLoai
            // 
            this.PhanLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhanLoai.DataPropertyName = "PhanLoai";
            this.PhanLoai.HeaderText = "Phân Loại";
            this.PhanLoai.Name = "PhanLoai";
            // 
            // TenSP
            // 
            this.TenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.Name = "TenSP";
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // GiaNhap
            // 
            this.GiaNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.HeaderText = "Giá nhập";
            this.GiaNhap.Name = "GiaNhap";
            // 
            // GiaBan
            // 
            this.GiaBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.Name = "GiaBan";
            // 
            // GhiChu
            // 
            this.GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // HinhAnh
            // 
            this.HinhAnh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HinhAnh.DataPropertyName = "HinhAnh";
            this.HinhAnh.HeaderText = "Hình ảnh";
            this.HinhAnh.Name = "HinhAnh";
            // 
            // openFileHinhAnh
            // 
            this.openFileHinhAnh.FileName = "openFileDialog1";
            // 
            // doAn1_BanDongHoDataSet
            // 
           
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 706);
            this.Controls.Add(this.dtgvSanPham);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSanPham";
            this.Text = "frmSanPham";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvSanPham;
        private Guna.UI2.WinForms.Guna2GradientButton btnOpenHinhAnh;
        private System.Windows.Forms.OpenFileDialog openFileHinhAnh;
        private System.Windows.Forms.PictureBox picSP;
        private System.Windows.Forms.TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2GradientButton btnTK;
        private Guna.UI2.WinForms.Guna2GradientButton btnHTall;
        private Guna.UI2.WinForms.Guna2GradientButton btnBoqua;
        private Guna.UI2.WinForms.Guna2GradientButton btnLuu;
        private Guna.UI2.WinForms.Guna2GradientButton btnSua;
        private Guna.UI2.WinForms.Guna2GradientButton btnXoa;
        private Guna.UI2.WinForms.Guna2GradientButton btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPhanLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhanLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhAnh;
    }
>>>>>>> 52ae496 (commit)
}