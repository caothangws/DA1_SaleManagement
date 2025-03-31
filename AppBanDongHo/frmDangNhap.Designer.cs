<<<<<<< HEAD
﻿namespace AppBanDongHo
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnDangKy = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lnkDK = new System.Windows.Forms.LinkLabel();
            this.radAdmin = new System.Windows.Forms.RadioButton();
            this.lbDK = new System.Windows.Forms.Label();
            this.chkShowMK = new System.Windows.Forms.CheckBox();
            this.btnDangNhap = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbMK = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbTK = new System.Windows.Forms.Label();
            this.lbDN = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuyDK = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2GradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2GradientPanel1.Controls.Add(this.btnHuyDK);
            this.guna2GradientPanel1.Controls.Add(this.btnDangKy);
            this.guna2GradientPanel1.Controls.Add(this.lnkDK);
            this.guna2GradientPanel1.Controls.Add(this.radAdmin);
            this.guna2GradientPanel1.Controls.Add(this.lbDK);
            this.guna2GradientPanel1.Controls.Add(this.chkShowMK);
            this.guna2GradientPanel1.Controls.Add(this.btnDangNhap);
            this.guna2GradientPanel1.Controls.Add(this.txtMatKhau);
            this.guna2GradientPanel1.Controls.Add(this.lbMK);
            this.guna2GradientPanel1.Controls.Add(this.txtTaiKhoan);
            this.guna2GradientPanel1.Controls.Add(this.lbTK);
            this.guna2GradientPanel1.Controls.Add(this.lbDN);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.DarkGray;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.LightGray;
            this.guna2GradientPanel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(591, 98);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(347, 486);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // btnDangKy
            // 
            this.btnDangKy.AutoRoundedCorners = true;
            this.btnDangKy.BackColor = System.Drawing.Color.Transparent;
            this.btnDangKy.BorderRadius = 21;
            this.btnDangKy.CheckedState.Parent = this.btnDangKy;
            this.btnDangKy.CustomImages.Parent = this.btnDangKy;
            this.btnDangKy.FillColor = System.Drawing.Color.DimGray;
            this.btnDangKy.FillColor2 = System.Drawing.Color.Gray;
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDangKy.ForeColor = System.Drawing.Color.Black;
            this.btnDangKy.HoverState.Parent = this.btnDangKy;
            this.btnDangKy.Location = new System.Drawing.Point(32, 359);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.ShadowDecoration.Parent = this.btnDangKy;
            this.btnDangKy.Size = new System.Drawing.Size(129, 45);
            this.btnDangKy.TabIndex = 11;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // lnkDK
            // 
            this.lnkDK.AutoSize = true;
            this.lnkDK.BackColor = System.Drawing.Color.Transparent;
            this.lnkDK.ForeColor = System.Drawing.Color.Transparent;
            this.lnkDK.LinkColor = System.Drawing.Color.Black;
            this.lnkDK.Location = new System.Drawing.Point(222, 315);
            this.lnkDK.Name = "lnkDK";
            this.lnkDK.Size = new System.Drawing.Size(64, 20);
            this.lnkDK.TabIndex = 10;
            this.lnkDK.TabStop = true;
            this.lnkDK.Text = "Đăng Ký";
            this.lnkDK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDK_LinkClicked);
            // 
            // radAdmin
            // 
            this.radAdmin.AutoSize = true;
            this.radAdmin.BackColor = System.Drawing.Color.Transparent;
            this.radAdmin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAdmin.Location = new System.Drawing.Point(45, 315);
            this.radAdmin.Name = "radAdmin";
            this.radAdmin.Size = new System.Drawing.Size(118, 24);
            this.radAdmin.TabIndex = 9;
            this.radAdmin.TabStop = true;
            this.radAdmin.Text = "Quản Trị Viên";
            this.radAdmin.UseVisualStyleBackColor = false;
            // 
            // lbDK
            // 
            this.lbDK.AutoSize = true;
            this.lbDK.BackColor = System.Drawing.Color.Transparent;
            this.lbDK.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDK.Location = new System.Drawing.Point(134, 58);
            this.lbDK.Name = "lbDK";
            this.lbDK.Size = new System.Drawing.Size(81, 25);
            this.lbDK.TabIndex = 8;
            this.lbDK.Text = "Đăng Ký";
            // 
            // chkShowMK
            // 
            this.chkShowMK.AutoSize = true;
            this.chkShowMK.BackColor = System.Drawing.Color.Transparent;
            this.chkShowMK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowMK.Location = new System.Drawing.Point(45, 318);
            this.chkShowMK.Name = "chkShowMK";
            this.chkShowMK.Size = new System.Drawing.Size(148, 24);
            this.chkShowMK.TabIndex = 7;
            this.chkShowMK.Text = "Hiển thị mật khẩu";
            this.chkShowMK.UseVisualStyleBackColor = false;
            this.chkShowMK.CheckedChanged += new System.EventHandler(this.chkShowMK_CheckedChanged);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.AutoRoundedCorners = true;
            this.btnDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.btnDangNhap.BorderRadius = 21;
            this.btnDangNhap.CheckedState.Parent = this.btnDangNhap;
            this.btnDangNhap.CustomImages.Parent = this.btnDangNhap;
            this.btnDangNhap.FillColor = System.Drawing.Color.DimGray;
            this.btnDangNhap.FillColor2 = System.Drawing.Color.Gray;
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDangNhap.ForeColor = System.Drawing.Color.Black;
            this.btnDangNhap.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDangNhap.HoverState.FillColor2 = System.Drawing.Color.Silver;
            this.btnDangNhap.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.HoverState.Parent = this.btnDangNhap;
            this.btnDangNhap.Location = new System.Drawing.Point(72, 359);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ShadowDecoration.Parent = this.btnDangNhap;
            this.btnDangNhap.Size = new System.Drawing.Size(180, 45);
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.AutoRoundedCorners = true;
            this.txtMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.txtMatKhau.BorderColor = System.Drawing.Color.Silver;
            this.txtMatKhau.BorderRadius = 17;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.DefaultText = "";
            this.txtMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.DisabledState.Parent = this.txtMatKhau;
            this.txtMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.FocusedState.Parent = this.txtMatKhau;
            this.txtMatKhau.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.HoverState.Parent = this.txtMatKhau;
            this.txtMatKhau.Location = new System.Drawing.Point(45, 265);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.txtMatKhau.PlaceholderText = "";
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.ShadowDecoration.Parent = this.txtMatKhau;
            this.txtMatKhau.Size = new System.Drawing.Size(253, 37);
            this.txtMatKhau.TabIndex = 4;
            // 
            // lbMK
            // 
            this.lbMK.AutoSize = true;
            this.lbMK.BackColor = System.Drawing.Color.Transparent;
            this.lbMK.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMK.ForeColor = System.Drawing.Color.Black;
            this.lbMK.Location = new System.Drawing.Point(41, 238);
            this.lbMK.Name = "lbMK";
            this.lbMK.Size = new System.Drawing.Size(84, 23);
            this.lbMK.TabIndex = 3;
            this.lbMK.Text = "Mật Khẩu";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.AutoRoundedCorners = true;
            this.txtTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.txtTaiKhoan.BorderColor = System.Drawing.Color.Silver;
            this.txtTaiKhoan.BorderRadius = 17;
            this.txtTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaiKhoan.DefaultText = "";
            this.txtTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaiKhoan.DisabledState.Parent = this.txtTaiKhoan;
            this.txtTaiKhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaiKhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaiKhoan.FocusedState.Parent = this.txtTaiKhoan;
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.txtTaiKhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaiKhoan.HoverState.Parent = this.txtTaiKhoan;
            this.txtTaiKhoan.Location = new System.Drawing.Point(45, 175);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.PasswordChar = '\0';
            this.txtTaiKhoan.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.txtTaiKhoan.PlaceholderText = "";
            this.txtTaiKhoan.SelectedText = "";
            this.txtTaiKhoan.ShadowDecoration.Parent = this.txtTaiKhoan;
            this.txtTaiKhoan.Size = new System.Drawing.Size(253, 37);
            this.txtTaiKhoan.TabIndex = 2;
            // 
            // lbTK
            // 
            this.lbTK.AutoSize = true;
            this.lbTK.BackColor = System.Drawing.Color.Transparent;
            this.lbTK.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTK.ForeColor = System.Drawing.Color.Black;
            this.lbTK.Location = new System.Drawing.Point(41, 148);
            this.lbTK.Name = "lbTK";
            this.lbTK.Size = new System.Drawing.Size(84, 23);
            this.lbTK.TabIndex = 1;
            this.lbTK.Text = "Tài Khoản";
            // 
            // lbDN
            // 
            this.lbDN.AutoSize = true;
            this.lbDN.BackColor = System.Drawing.Color.Transparent;
            this.lbDN.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDN.Location = new System.Drawing.Point(125, 58);
            this.lbDN.Name = "lbDN";
            this.lbDN.Size = new System.Drawing.Size(98, 23);
            this.lbDN.TabIndex = 0;
            this.lbDN.Text = "Đăng Nhập";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(960, -1);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(58, 51);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuyDK
            // 
            this.btnHuyDK.AutoRoundedCorners = true;
            this.btnHuyDK.BackColor = System.Drawing.Color.Transparent;
            this.btnHuyDK.BorderRadius = 21;
            this.btnHuyDK.CheckedState.Parent = this.btnHuyDK;
            this.btnHuyDK.CustomImages.Parent = this.btnHuyDK;
            this.btnHuyDK.FillColor = System.Drawing.Color.DimGray;
            this.btnHuyDK.FillColor2 = System.Drawing.Color.Gray;
            this.btnHuyDK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHuyDK.ForeColor = System.Drawing.Color.Black;
            this.btnHuyDK.HoverState.Parent = this.btnHuyDK;
            this.btnHuyDK.Location = new System.Drawing.Point(183, 359);
            this.btnHuyDK.Name = "btnHuyDK";
            this.btnHuyDK.ShadowDecoration.Parent = this.btnHuyDK;
            this.btnHuyDK.Size = new System.Drawing.Size(129, 45);
            this.btnHuyDK.TabIndex = 12;
            this.btnHuyDK.Text = "Hủy đăng ký";
            this.btnHuyDK.Click += new System.EventHandler(this.btnHuyDK_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 659);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Button btnThoat;
        private Guna.UI2.WinForms.Guna2TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lbTK;
        private System.Windows.Forms.Label lbDN;
        private System.Windows.Forms.Label lbMK;
        private Guna.UI2.WinForms.Guna2GradientButton btnDangNhap;
        private System.Windows.Forms.CheckBox chkShowMK;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhau;
        private System.Windows.Forms.Label lbDK;
        private System.Windows.Forms.RadioButton radAdmin;
        private System.Windows.Forms.LinkLabel lnkDK;
        private Guna.UI2.WinForms.Guna2GradientButton btnDangKy;
        private Guna.UI2.WinForms.Guna2GradientButton btnHuyDK;
    }
}

=======
﻿namespace AppBanDongHo
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.chkLuuTK = new System.Windows.Forms.CheckBox();
            this.btnThoat = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDangNhap = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbMK = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbTK = new System.Windows.Forms.Label();
            this.lbDN = new System.Windows.Forms.Label();
            this.btnThoat1 = new System.Windows.Forms.Button();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2GradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2GradientPanel1.Controls.Add(this.chkLuuTK);
            this.guna2GradientPanel1.Controls.Add(this.btnThoat);
            this.guna2GradientPanel1.Controls.Add(this.btnDangNhap);
            this.guna2GradientPanel1.Controls.Add(this.txtMatKhau);
            this.guna2GradientPanel1.Controls.Add(this.lbMK);
            this.guna2GradientPanel1.Controls.Add(this.txtTaiKhoan);
            this.guna2GradientPanel1.Controls.Add(this.lbTK);
            this.guna2GradientPanel1.Controls.Add(this.lbDN);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.DarkGray;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.LightGray;
            this.guna2GradientPanel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(591, 98);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(347, 486);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // chkLuuTK
            // 
            this.chkLuuTK.AutoSize = true;
            this.chkLuuTK.BackColor = System.Drawing.Color.Transparent;
            this.chkLuuTK.Location = new System.Drawing.Point(9, 299);
            this.chkLuuTK.Name = "chkLuuTK";
            this.chkLuuTK.Size = new System.Drawing.Size(120, 24);
            this.chkLuuTK.TabIndex = 7;
            this.chkLuuTK.Text = "Lưu tài khoản";
            this.chkLuuTK.UseVisualStyleBackColor = false;
            this.chkLuuTK.CheckedChanged += new System.EventHandler(this.chkMatKhau_CheckedChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.AutoRoundedCorners = true;
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.BorderRadius = 21;
            this.btnThoat.CheckedState.Parent = this.btnThoat;
            this.btnThoat.CustomImages.Parent = this.btnThoat;
            this.btnThoat.FillColor = System.Drawing.Color.DimGray;
            this.btnThoat.FillColor2 = System.Drawing.Color.Gray;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThoat.HoverState.FillColor2 = System.Drawing.Color.Silver;
            this.btnThoat.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnThoat.HoverState.Parent = this.btnThoat;
            this.btnThoat.Location = new System.Drawing.Point(188, 348);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ShadowDecoration.Parent = this.btnThoat;
            this.btnThoat.Size = new System.Drawing.Size(155, 45);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.AutoRoundedCorners = true;
            this.btnDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.btnDangNhap.BorderRadius = 21;
            this.btnDangNhap.CheckedState.Parent = this.btnDangNhap;
            this.btnDangNhap.CustomImages.Parent = this.btnDangNhap;
            this.btnDangNhap.FillColor = System.Drawing.Color.DimGray;
            this.btnDangNhap.FillColor2 = System.Drawing.Color.Gray;
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDangNhap.HoverState.FillColor2 = System.Drawing.Color.Silver;
            this.btnDangNhap.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.HoverState.Parent = this.btnDangNhap;
            this.btnDangNhap.Location = new System.Drawing.Point(9, 348);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ShadowDecoration.Parent = this.btnDangNhap;
            this.btnDangNhap.Size = new System.Drawing.Size(155, 45);
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.AutoRoundedCorners = true;
            this.txtMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.txtMatKhau.BorderColor = System.Drawing.Color.Silver;
            this.txtMatKhau.BorderRadius = 17;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.DefaultText = "";
            this.txtMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.DisabledState.Parent = this.txtMatKhau;
            this.txtMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.FocusedState.Parent = this.txtMatKhau;
            this.txtMatKhau.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.HoverState.Parent = this.txtMatKhau;
            this.txtMatKhau.Location = new System.Drawing.Point(9, 255);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.txtMatKhau.PlaceholderText = "";
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.ShadowDecoration.Parent = this.txtMatKhau;
            this.txtMatKhau.Size = new System.Drawing.Size(334, 37);
            this.txtMatKhau.TabIndex = 4;
            // 
            // lbMK
            // 
            this.lbMK.AutoSize = true;
            this.lbMK.BackColor = System.Drawing.Color.Transparent;
            this.lbMK.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMK.ForeColor = System.Drawing.Color.Black;
            this.lbMK.Location = new System.Drawing.Point(5, 228);
            this.lbMK.Name = "lbMK";
            this.lbMK.Size = new System.Drawing.Size(84, 23);
            this.lbMK.TabIndex = 3;
            this.lbMK.Text = "Mật Khẩu";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.AutoRoundedCorners = true;
            this.txtTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.txtTaiKhoan.BorderColor = System.Drawing.Color.Silver;
            this.txtTaiKhoan.BorderRadius = 17;
            this.txtTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaiKhoan.DefaultText = "";
            this.txtTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaiKhoan.DisabledState.Parent = this.txtTaiKhoan;
            this.txtTaiKhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaiKhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaiKhoan.FocusedState.Parent = this.txtTaiKhoan;
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.txtTaiKhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaiKhoan.HoverState.Parent = this.txtTaiKhoan;
            this.txtTaiKhoan.Location = new System.Drawing.Point(9, 177);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.PasswordChar = '\0';
            this.txtTaiKhoan.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.txtTaiKhoan.PlaceholderText = "";
            this.txtTaiKhoan.SelectedText = "";
            this.txtTaiKhoan.ShadowDecoration.Parent = this.txtTaiKhoan;
            this.txtTaiKhoan.Size = new System.Drawing.Size(334, 37);
            this.txtTaiKhoan.TabIndex = 2;
            // 
            // lbTK
            // 
            this.lbTK.AutoSize = true;
            this.lbTK.BackColor = System.Drawing.Color.Transparent;
            this.lbTK.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTK.ForeColor = System.Drawing.Color.Black;
            this.lbTK.Location = new System.Drawing.Point(5, 150);
            this.lbTK.Name = "lbTK";
            this.lbTK.Size = new System.Drawing.Size(84, 23);
            this.lbTK.TabIndex = 1;
            this.lbTK.Text = "Tài Khoản";
            // 
            // lbDN
            // 
            this.lbDN.AutoSize = true;
            this.lbDN.BackColor = System.Drawing.Color.Transparent;
            this.lbDN.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDN.Location = new System.Drawing.Point(79, 39);
            this.lbDN.Name = "lbDN";
            this.lbDN.Size = new System.Drawing.Size(182, 36);
            this.lbDN.TabIndex = 0;
            this.lbDN.Text = "Đăng Nhập";
            // 
            // btnThoat1
            // 
            this.btnThoat1.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat1.BackgroundImage")));
            this.btnThoat1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThoat1.FlatAppearance.BorderSize = 0;
            this.btnThoat1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat1.Location = new System.Drawing.Point(960, -1);
            this.btnThoat1.Name = "btnThoat1";
            this.btnThoat1.Size = new System.Drawing.Size(58, 51);
            this.btnThoat1.TabIndex = 1;
            this.btnThoat1.UseVisualStyleBackColor = false;
            this.btnThoat1.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 659);
            this.Controls.Add(this.btnThoat1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Button btnThoat1;
        private Guna.UI2.WinForms.Guna2TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lbTK;
        private System.Windows.Forms.Label lbDN;
        private System.Windows.Forms.Label lbMK;
        private Guna.UI2.WinForms.Guna2GradientButton btnDangNhap;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhau;
        private System.Windows.Forms.CheckBox chkLuuTK;
        private Guna.UI2.WinForms.Guna2GradientButton btnThoat;
    }
}

>>>>>>> 52ae496 (commit)
