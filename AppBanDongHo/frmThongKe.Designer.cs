<<<<<<< HEAD
﻿namespace AppBanDongHo
{
    partial class frmThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartDT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.radNgay = new System.Windows.Forms.RadioButton();
            this.radThang = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartDT)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDT
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDT.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDT.Legends.Add(legend1);
            this.chartDT.Location = new System.Drawing.Point(2, 197);
            this.chartDT.Margin = new System.Windows.Forms.Padding(4);
            this.chartDT.Name = "chartDT";
            this.chartDT.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "DoanhThu";
            this.chartDT.Series.Add(series1);
            this.chartDT.Size = new System.Drawing.Size(749, 451);
            this.chartDT.TabIndex = 0;
            this.chartDT.Text = "chart1";
            // 
            // radNgay
            // 
            this.radNgay.AutoSize = true;
            this.radNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNgay.Location = new System.Drawing.Point(61, 41);
            this.radNgay.Margin = new System.Windows.Forms.Padding(4);
            this.radNgay.Name = "radNgay";
            this.radNgay.Size = new System.Drawing.Size(233, 29);
            this.radNgay.TabIndex = 4;
            this.radNgay.TabStop = true;
            this.radNgay.Text = "Doanh Thu Theo Ngày";
            this.radNgay.UseVisualStyleBackColor = true;
            this.radNgay.CheckedChanged += new System.EventHandler(this.radNgay_CheckedChanged);
            // 
            // radThang
            // 
            this.radThang.AutoSize = true;
            this.radThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radThang.Location = new System.Drawing.Point(61, 85);
            this.radThang.Margin = new System.Windows.Forms.Padding(4);
            this.radThang.Name = "radThang";
            this.radThang.Size = new System.Drawing.Size(244, 29);
            this.radThang.TabIndex = 4;
            this.radThang.TabStop = true;
            this.radThang.Text = "Doanh Thu Theo Tháng";
            this.radThang.UseVisualStyleBackColor = true;
            this.radThang.CheckedChanged += new System.EventHandler(this.radThang_CheckedChanged);
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNam.Location = new System.Drawing.Point(61, 129);
            this.radNam.Margin = new System.Windows.Forms.Padding(4);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(228, 29);
            this.radNam.TabIndex = 4;
            this.radNam.TabStop = true;
            this.radNam.Text = "Doanh Thu Theo Năm";
            this.radNam.UseVisualStyleBackColor = true;
            this.radNam.CheckedChanged += new System.EventHandler(this.radNam_CheckedChanged);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 706);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.radThang);
            this.Controls.Add(this.radNgay);
            this.Controls.Add(this.chartDT);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDT;
        private System.Windows.Forms.RadioButton radNgay;
        private System.Windows.Forms.RadioButton radThang;
        private System.Windows.Forms.RadioButton radNam;


    }
=======
﻿namespace AppBanDongHo
{
    partial class frmThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartDT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.radNgay = new System.Windows.Forms.RadioButton();
            this.radThang = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartDT)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDT
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDT.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDT.Legends.Add(legend1);
            this.chartDT.Location = new System.Drawing.Point(2, 197);
            this.chartDT.Margin = new System.Windows.Forms.Padding(4);
            this.chartDT.Name = "chartDT";
            this.chartDT.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "DoanhThu";
            this.chartDT.Series.Add(series1);
            this.chartDT.Size = new System.Drawing.Size(749, 451);
            this.chartDT.TabIndex = 0;
            this.chartDT.Text = "chart1";
            // 
            // radNgay
            // 
            this.radNgay.AutoSize = true;
            this.radNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNgay.Location = new System.Drawing.Point(61, 41);
            this.radNgay.Margin = new System.Windows.Forms.Padding(4);
            this.radNgay.Name = "radNgay";
            this.radNgay.Size = new System.Drawing.Size(233, 29);
            this.radNgay.TabIndex = 4;
            this.radNgay.TabStop = true;
            this.radNgay.Text = "Doanh Thu Theo Ngày";
            this.radNgay.UseVisualStyleBackColor = true;
            this.radNgay.CheckedChanged += new System.EventHandler(this.radNgay_CheckedChanged);
            // 
            // radThang
            // 
            this.radThang.AutoSize = true;
            this.radThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radThang.Location = new System.Drawing.Point(61, 85);
            this.radThang.Margin = new System.Windows.Forms.Padding(4);
            this.radThang.Name = "radThang";
            this.radThang.Size = new System.Drawing.Size(244, 29);
            this.radThang.TabIndex = 4;
            this.radThang.TabStop = true;
            this.radThang.Text = "Doanh Thu Theo Tháng";
            this.radThang.UseVisualStyleBackColor = true;
            this.radThang.CheckedChanged += new System.EventHandler(this.radThang_CheckedChanged);
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNam.Location = new System.Drawing.Point(61, 129);
            this.radNam.Margin = new System.Windows.Forms.Padding(4);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(228, 29);
            this.radNam.TabIndex = 4;
            this.radNam.TabStop = true;
            this.radNam.Text = "Doanh Thu Theo Năm";
            this.radNam.UseVisualStyleBackColor = true;
            this.radNam.CheckedChanged += new System.EventHandler(this.radNam_CheckedChanged);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 706);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.radThang);
            this.Controls.Add(this.radNgay);
            this.Controls.Add(this.chartDT);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDT;
        private System.Windows.Forms.RadioButton radNgay;
        private System.Windows.Forms.RadioButton radThang;
        private System.Windows.Forms.RadioButton radNam;


    }
>>>>>>> 52ae496 (commit)
}