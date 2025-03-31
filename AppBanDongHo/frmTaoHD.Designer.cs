<<<<<<< HEAD
﻿namespace AppBanDongHo
{
    partial class frmTaoHD
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maKHLabel;
            System.Windows.Forms.Label giaBanLabel;
            System.Windows.Forms.Label soLuongBanLabel;
            System.Windows.Forms.Label maSPLabel;
            System.Windows.Forms.Label ngayLapLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaoHD));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSLTon = new System.Windows.Forms.TextBox();
            this.txtTG = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cbxTenSP = new System.Windows.Forms.ComboBox();
            this.txtSoluongMua = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.cbxTenKH = new System.Windows.Forms.ComboBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.doAn1_BanDongHoDataSet = new AppBanDongHo.DoAn1_BanDongHoDataSet();
            this.dtgvChiTietHD = new System.Windows.Forms.DataGridView();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doAn1BanDongHoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            maKHLabel = new System.Windows.Forms.Label();
            giaBanLabel = new System.Windows.Forms.Label();
            soLuongBanLabel = new System.Windows.Forms.Label();
            maSPLabel = new System.Windows.Forms.Label();
            ngayLapLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doAn1_BanDongHoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAn1BanDongHoDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maKHLabel
            // 
            maKHLabel.AutoSize = true;
            maKHLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maKHLabel.Location = new System.Drawing.Point(88, 25);
            maKHLabel.Name = "maKHLabel";
            maKHLabel.Size = new System.Drawing.Size(121, 23);
            maKHLabel.TabIndex = 1;
            maKHLabel.Text = " Tên nhân viên";
            // 
            // giaBanLabel
            // 
            giaBanLabel.AutoSize = true;
            giaBanLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            giaBanLabel.Location = new System.Drawing.Point(574, 122);
            giaBanLabel.Name = "giaBanLabel";
            giaBanLabel.Size = new System.Drawing.Size(74, 23);
            giaBanLabel.TabIndex = 3;
            giaBanLabel.Text = "Đơn giá:";
            // 
            // soLuongBanLabel
            // 
            soLuongBanLabel.AutoSize = true;
            soLuongBanLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soLuongBanLabel.Location = new System.Drawing.Point(784, 25);
            soLuongBanLabel.Name = "soLuongBanLabel";
            soLuongBanLabel.Size = new System.Drawing.Size(82, 23);
            soLuongBanLabel.TabIndex = 5;
            soLuongBanLabel.Text = "Số lượng:";
            // 
            // maSPLabel
            // 
            maSPLabel.AutoSize = true;
            maSPLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maSPLabel.Location = new System.Drawing.Point(334, 25);
            maSPLabel.Name = "maSPLabel";
            maSPLabel.Size = new System.Drawing.Size(65, 23);
            maSPLabel.TabIndex = 7;
            maSPLabel.Text = "Tên SP ";
            // 
            // ngayLapLabel
            // 
            ngayLapLabel.AutoSize = true;
            ngayLapLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayLapLabel.Location = new System.Drawing.Point(334, 122);
            ngayLapLabel.Name = "ngayLapLabel";
            ngayLapLabel.Size = new System.Drawing.Size(85, 23);
            ngayLapLabel.TabIndex = 9;
            ngayLapLabel.Text = "Thời gian:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(85, 122);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(130, 23);
            label1.TabIndex = 11;
            label1.Text = "Tên khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(776, 122);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(90, 23);
            label2.TabIndex = 3;
            label2.Text = "Tổng Tiền:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(574, 25);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(116, 23);
            label3.TabIndex = 15;
            label3.Text = "Số lượng Tồn:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(this.txtSLTon);
            this.panel1.Controls.Add(this.txtTG);
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(ngayLapLabel);
            this.panel1.Controls.Add(maSPLabel);
            this.panel1.Controls.Add(this.cbxTenSP);
            this.panel1.Controls.Add(soLuongBanLabel);
            this.panel1.Controls.Add(this.txtSoluongMua);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(giaBanLabel);
            this.panel1.Controls.Add(this.txtGiaBan);
            this.panel1.Controls.Add(maKHLabel);
            this.panel1.Controls.Add(this.cbxTenKH);
            this.panel1.Controls.Add(this.txtTenNV);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 352);
            this.panel1.TabIndex = 0;
            // 
            // txtSLTon
            // 
            this.txtSLTon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLTon.Location = new System.Drawing.Point(578, 58);
            this.txtSLTon.Name = "txtSLTon";
            this.txtSLTon.Size = new System.Drawing.Size(145, 30);
            this.txtSLTon.TabIndex = 16;
            // 
            // txtTG
            // 
            this.txtTG.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTG.Location = new System.Drawing.Point(337, 161);
            this.txtTG.Multiline = true;
            this.txtTG.Name = "txtTG";
            this.txtTG.Size = new System.Drawing.Size(194, 31);
            this.txtTG.TabIndex = 14;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.AutoRoundedCorners = true;
            this.btnThanhToan.BorderRadius = 21;
            this.btnThanhToan.CheckedState.Parent = this.btnThanhToan;
            this.btnThanhToan.CustomImages.Parent = this.btnThanhToan;
            this.btnThanhToan.FillColor = System.Drawing.Color.Black;
            this.btnThanhToan.FillColor2 = System.Drawing.Color.Gray;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnThanhToan.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.btnThanhToan.HoverState.Parent = this.btnThanhToan;
            this.btnThanhToan.Location = new System.Drawing.Point(699, 253);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.ShadowDecoration.Parent = this.btnThanhToan;
            this.btnThanhToan.Size = new System.Drawing.Size(137, 45);
            this.btnThanhToan.TabIndex = 13;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.AutoRoundedCorners = true;
            this.btnLamMoi.BorderRadius = 21;
            this.btnLamMoi.CheckedState.Parent = this.btnLamMoi;
            this.btnLamMoi.CustomImages.Parent = this.btnLamMoi;
            this.btnLamMoi.FillColor = System.Drawing.Color.Black;
            this.btnLamMoi.FillColor2 = System.Drawing.Color.Gray;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnLamMoi.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.btnLamMoi.HoverState.Parent = this.btnLamMoi;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.Location = new System.Drawing.Point(439, 253);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ShadowDecoration.Parent = this.btnLamMoi;
            this.btnLamMoi.Size = new System.Drawing.Size(149, 45);
            this.btnLamMoi.TabIndex = 13;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.AutoRoundedCorners = true;
            this.btnThem.BorderRadius = 21;
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
            this.btnThem.Location = new System.Drawing.Point(176, 253);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(149, 45);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbxTenSP
            // 
            this.cbxTenSP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTenSP.FormattingEnabled = true;
            this.cbxTenSP.Location = new System.Drawing.Point(338, 57);
            this.cbxTenSP.Name = "cbxTenSP";
            this.cbxTenSP.Size = new System.Drawing.Size(190, 31);
            this.cbxTenSP.TabIndex = 8;
            this.cbxTenSP.SelectedIndexChanged += new System.EventHandler(this.cbxMaSP_SelectedIndexChanged);
            // 
            // txtSoluongMua
            // 
            this.txtSoluongMua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoluongMua.Location = new System.Drawing.Point(788, 61);
            this.txtSoluongMua.Name = "txtSoluongMua";
            this.txtSoluongMua.Size = new System.Drawing.Size(145, 30);
            this.txtSoluongMua.TabIndex = 6;
            this.txtSoluongMua.TextChanged += new System.EventHandler(this.txtSoluongMua_TextChanged);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.Location = new System.Drawing.Point(578, 162);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(120, 30);
            this.txtGiaBan.TabIndex = 4;
            // 
            // cbxTenKH
            // 
            this.cbxTenKH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTenKH.FormattingEnabled = true;
            this.cbxTenKH.Location = new System.Drawing.Point(89, 157);
            this.cbxTenKH.Name = "cbxTenKH";
            this.cbxTenKH.Size = new System.Drawing.Size(194, 31);
            this.cbxTenKH.TabIndex = 2;
            this.cbxTenKH.SelectedIndexChanged += new System.EventHandler(this.cbxTenKH_SelectedIndexChanged);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(92, 57);
            this.txtTenNV.Multiline = true;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(194, 31);
            this.txtTenNV.TabIndex = 0;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(780, 161);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(164, 31);
            this.txtTongTien.TabIndex = 0;
            // 
            // doAn1_BanDongHoDataSet
            // 
            this.doAn1_BanDongHoDataSet.DataSetName = "DoAn1_BanDongHoDataSet";
            this.doAn1_BanDongHoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtgvChiTietHD
            // 
            this.dtgvChiTietHD.AutoGenerateColumns = false;
            this.dtgvChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenSP,
            this.TenNV,
            this.TenKH,
            this.SoLuong,
            this.TongTien});
            this.dtgvChiTietHD.DataSource = this.doAn1BanDongHoDataSetBindingSource;
            this.dtgvChiTietHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvChiTietHD.Location = new System.Drawing.Point(0, 352);
            this.dtgvChiTietHD.Name = "dtgvChiTietHD";
            this.dtgvChiTietHD.RowTemplate.Height = 24;
            this.dtgvChiTietHD.Size = new System.Drawing.Size(1007, 307);
            this.dtgvChiTietHD.TabIndex = 1;
            // 
            // TenSP
            // 
            this.TenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.Name = "TenSP";
            // 
            // TenNV
            // 
            this.TenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNV.DataPropertyName = "MaNV";
            this.TenNV.HeaderText = "Mã Nhân Viên";
            this.TenNV.Name = "TenNV";
            // 
            // TenKH
            // 
            this.TenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên Khách Hàng";
            this.TenKH.Name = "TenKH";
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // TongTien
            // 
            this.TongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            // 
            // doAn1BanDongHoDataSetBindingSource
            // 
            this.doAn1BanDongHoDataSetBindingSource.DataSource = this.doAn1_BanDongHoDataSet;
            this.doAn1BanDongHoDataSetBindingSource.Position = 0;
            // 
            // frmTaoHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 659);
            this.Controls.Add(this.dtgvChiTietHD);
            this.Controls.Add(this.panel1);
            this.Name = "frmTaoHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTaoHD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmChiTietHD_FormClosed);
            this.Load += new System.EventHandler(this.frmChiTietHD_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doAn1_BanDongHoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAn1BanDongHoDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DoAn1_BanDongHoDataSet doAn1_BanDongHoDataSet;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.ComboBox cbxTenSP;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.ComboBox cbxTenKH;
        private Guna.UI2.WinForms.Guna2GradientButton btnThanhToan;
        private Guna.UI2.WinForms.Guna2GradientButton btnThem;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtTG;
        private System.Windows.Forms.TextBox txtSLTon;
        private System.Windows.Forms.TextBox txtSoluongMua;
        private Guna.UI2.WinForms.Guna2GradientButton btnLamMoi;
        public System.Windows.Forms.DataGridView dtgvChiTietHD;
        private System.Windows.Forms.BindingSource doAn1BanDongHoDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
    }
=======
﻿namespace AppBanDongHo
{
    partial class frmTaoHD
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maKHLabel;
            System.Windows.Forms.Label giaBanLabel;
            System.Windows.Forms.Label soLuongBanLabel;
            System.Windows.Forms.Label maSPLabel;
            System.Windows.Forms.Label ngayLapLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaoHD));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSLTon = new System.Windows.Forms.TextBox();
            this.txtTG = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cbxTenSP = new System.Windows.Forms.ComboBox();
            this.txtSoluongMua = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.cbxTenKH = new System.Windows.Forms.ComboBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.dtgvChiTietHD = new System.Windows.Forms.DataGridView();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doAn1BanDongHoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            maKHLabel = new System.Windows.Forms.Label();
            giaBanLabel = new System.Windows.Forms.Label();
            soLuongBanLabel = new System.Windows.Forms.Label();
            maSPLabel = new System.Windows.Forms.Label();
            ngayLapLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAn1BanDongHoDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maKHLabel
            // 
            maKHLabel.AutoSize = true;
            maKHLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maKHLabel.Location = new System.Drawing.Point(88, 25);
            maKHLabel.Name = "maKHLabel";
            maKHLabel.Size = new System.Drawing.Size(121, 23);
            maKHLabel.TabIndex = 1;
            maKHLabel.Text = " Tên nhân viên";
            // 
            // giaBanLabel
            // 
            giaBanLabel.AutoSize = true;
            giaBanLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            giaBanLabel.Location = new System.Drawing.Point(574, 122);
            giaBanLabel.Name = "giaBanLabel";
            giaBanLabel.Size = new System.Drawing.Size(74, 23);
            giaBanLabel.TabIndex = 3;
            giaBanLabel.Text = "Đơn giá:";
            // 
            // soLuongBanLabel
            // 
            soLuongBanLabel.AutoSize = true;
            soLuongBanLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soLuongBanLabel.Location = new System.Drawing.Point(784, 25);
            soLuongBanLabel.Name = "soLuongBanLabel";
            soLuongBanLabel.Size = new System.Drawing.Size(82, 23);
            soLuongBanLabel.TabIndex = 5;
            soLuongBanLabel.Text = "Số lượng:";
            // 
            // maSPLabel
            // 
            maSPLabel.AutoSize = true;
            maSPLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maSPLabel.Location = new System.Drawing.Point(334, 25);
            maSPLabel.Name = "maSPLabel";
            maSPLabel.Size = new System.Drawing.Size(65, 23);
            maSPLabel.TabIndex = 7;
            maSPLabel.Text = "Tên SP ";
            // 
            // ngayLapLabel
            // 
            ngayLapLabel.AutoSize = true;
            ngayLapLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayLapLabel.Location = new System.Drawing.Point(334, 122);
            ngayLapLabel.Name = "ngayLapLabel";
            ngayLapLabel.Size = new System.Drawing.Size(85, 23);
            ngayLapLabel.TabIndex = 9;
            ngayLapLabel.Text = "Thời gian:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(85, 122);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(130, 23);
            label1.TabIndex = 11;
            label1.Text = "Tên khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(776, 122);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(90, 23);
            label2.TabIndex = 3;
            label2.Text = "Tổng Tiền:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(574, 25);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(116, 23);
            label3.TabIndex = 15;
            label3.Text = "Số lượng Tồn:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(this.txtSLTon);
            this.panel1.Controls.Add(this.txtTG);
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(ngayLapLabel);
            this.panel1.Controls.Add(maSPLabel);
            this.panel1.Controls.Add(this.cbxTenSP);
            this.panel1.Controls.Add(soLuongBanLabel);
            this.panel1.Controls.Add(this.txtSoluongMua);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(giaBanLabel);
            this.panel1.Controls.Add(this.txtGiaBan);
            this.panel1.Controls.Add(maKHLabel);
            this.panel1.Controls.Add(this.cbxTenKH);
            this.panel1.Controls.Add(this.txtTenNV);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 352);
            this.panel1.TabIndex = 0;
            // 
            // txtSLTon
            // 
            this.txtSLTon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLTon.Location = new System.Drawing.Point(578, 58);
            this.txtSLTon.Name = "txtSLTon";
            this.txtSLTon.Size = new System.Drawing.Size(145, 30);
            this.txtSLTon.TabIndex = 16;
            // 
            // txtTG
            // 
            this.txtTG.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTG.Location = new System.Drawing.Point(337, 161);
            this.txtTG.Multiline = true;
            this.txtTG.Name = "txtTG";
            this.txtTG.Size = new System.Drawing.Size(194, 31);
            this.txtTG.TabIndex = 14;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.AutoRoundedCorners = true;
            this.btnThanhToan.BorderRadius = 21;
            this.btnThanhToan.CheckedState.Parent = this.btnThanhToan;
            this.btnThanhToan.CustomImages.Parent = this.btnThanhToan;
            this.btnThanhToan.FillColor = System.Drawing.Color.Black;
            this.btnThanhToan.FillColor2 = System.Drawing.Color.Gray;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnThanhToan.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.btnThanhToan.HoverState.Parent = this.btnThanhToan;
            this.btnThanhToan.Location = new System.Drawing.Point(699, 253);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.ShadowDecoration.Parent = this.btnThanhToan;
            this.btnThanhToan.Size = new System.Drawing.Size(137, 45);
            this.btnThanhToan.TabIndex = 13;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.AutoRoundedCorners = true;
            this.btnLamMoi.BorderRadius = 21;
            this.btnLamMoi.CheckedState.Parent = this.btnLamMoi;
            this.btnLamMoi.CustomImages.Parent = this.btnLamMoi;
            this.btnLamMoi.FillColor = System.Drawing.Color.Black;
            this.btnLamMoi.FillColor2 = System.Drawing.Color.Gray;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnLamMoi.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.btnLamMoi.HoverState.Parent = this.btnLamMoi;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.Location = new System.Drawing.Point(439, 253);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ShadowDecoration.Parent = this.btnLamMoi;
            this.btnLamMoi.Size = new System.Drawing.Size(149, 45);
            this.btnLamMoi.TabIndex = 13;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.AutoRoundedCorners = true;
            this.btnThem.BorderRadius = 21;
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
            this.btnThem.Location = new System.Drawing.Point(176, 253);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(149, 45);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbxTenSP
            // 
            this.cbxTenSP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTenSP.FormattingEnabled = true;
            this.cbxTenSP.Location = new System.Drawing.Point(338, 57);
            this.cbxTenSP.Name = "cbxTenSP";
            this.cbxTenSP.Size = new System.Drawing.Size(190, 31);
            this.cbxTenSP.TabIndex = 8;
            this.cbxTenSP.SelectedIndexChanged += new System.EventHandler(this.cbxMaSP_SelectedIndexChanged);
            // 
            // txtSoluongMua
            // 
            this.txtSoluongMua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoluongMua.Location = new System.Drawing.Point(788, 61);
            this.txtSoluongMua.Name = "txtSoluongMua";
            this.txtSoluongMua.Size = new System.Drawing.Size(145, 30);
            this.txtSoluongMua.TabIndex = 6;
            this.txtSoluongMua.TextChanged += new System.EventHandler(this.txtSoluongMua_TextChanged);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.Location = new System.Drawing.Point(578, 162);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(120, 30);
            this.txtGiaBan.TabIndex = 4;
            // 
            // cbxTenKH
            // 
            this.cbxTenKH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTenKH.FormattingEnabled = true;
            this.cbxTenKH.Location = new System.Drawing.Point(89, 157);
            this.cbxTenKH.Name = "cbxTenKH";
            this.cbxTenKH.Size = new System.Drawing.Size(194, 31);
            this.cbxTenKH.TabIndex = 2;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(92, 57);
            this.txtTenNV.Multiline = true;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(194, 31);
            this.txtTenNV.TabIndex = 0;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(780, 161);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(164, 31);
            this.txtTongTien.TabIndex = 0;
            // 
            // dtgvChiTietHD
            // 
            this.dtgvChiTietHD.AutoGenerateColumns = false;
            this.dtgvChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenSP,
            this.TenNV,
            this.TenKH,
            this.SoLuong,
            this.TongTien});
            this.dtgvChiTietHD.DataSource = this.doAn1BanDongHoDataSetBindingSource;
            this.dtgvChiTietHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvChiTietHD.Location = new System.Drawing.Point(0, 352);
            this.dtgvChiTietHD.Name = "dtgvChiTietHD";
            this.dtgvChiTietHD.RowHeadersWidth = 51;
            this.dtgvChiTietHD.RowTemplate.Height = 24;
            this.dtgvChiTietHD.Size = new System.Drawing.Size(1007, 307);
            this.dtgvChiTietHD.TabIndex = 1;
            // 
            // TenSP
            // 
            this.TenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            // 
            // TenNV
            // 
            this.TenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNV.DataPropertyName = "MaNV";
            this.TenNV.HeaderText = "Mã Nhân Viên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            // 
            // TenKH
            // 
            this.TenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên Khách Hàng";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // TongTien
            // 
            this.TongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            // 
            // frmTaoHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 659);
            this.Controls.Add(this.dtgvChiTietHD);
            this.Controls.Add(this.panel1);
            this.Name = "frmTaoHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmChiTietHD_FormClosed);
            this.Load += new System.EventHandler(this.frmChiTietHD_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAn1BanDongHoDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.ComboBox cbxTenSP;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.ComboBox cbxTenKH;
        private Guna.UI2.WinForms.Guna2GradientButton btnThanhToan;
        private Guna.UI2.WinForms.Guna2GradientButton btnThem;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtTG;
        private System.Windows.Forms.TextBox txtSLTon;
        private System.Windows.Forms.TextBox txtSoluongMua;
        private Guna.UI2.WinForms.Guna2GradientButton btnLamMoi;
        public System.Windows.Forms.DataGridView dtgvChiTietHD;
        private System.Windows.Forms.BindingSource doAn1BanDongHoDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
    }
>>>>>>> 52ae496 (commit)
}