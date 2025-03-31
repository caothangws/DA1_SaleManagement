<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppBanDongHo
{
    public partial class frmThongKe : Form
    {
        string chuoiKN = global::AppBanDongHo.Properties.Settings.Default.DoAn1_BanDongHoConnectionString;
        SqlConnection connect;
        DataTable tbl;
        DataTable tbDTG;
        SqlDataAdapter adp;

        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(chuoiKN);
            fillChart();

        }


        private void fillChart(string type = "")
        {

            
            chartDT.ChartAreas["ChartArea1"].AxisY.Title = "Tiền";
            chartDT.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chartDT.Series["DoanhThu"].Points.Clear();

            string selectDoanhThu = string.Format("select distinct NgayLap from HoaDon; select SanPham.TenSP, HoaDon.SoLuongBan,SanPham.GiaBan,HoaDon.NgayLap from HoaDon  inner join SanPham on SanPham.MaSP = HoaDon.MaSP  ");
            SqlDataAdapter adpDoanhThu = new SqlDataAdapter(selectDoanhThu, connect);
            DataSet dsDoanhThu = new DataSet();
            adpDoanhThu.Fill(dsDoanhThu);
            DateTime timeNgayBan = DateTime.Now;

            if (type == "radNgay")
            {
                chartDT.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
                foreach (DataRow drNgayBan in dsDoanhThu.Tables[0].Rows)
                {
                    int total = 0;
                    timeNgayBan = DateTime.Parse(drNgayBan["NgayLap"].ToString());
                    foreach (DataRow drDTG in dsDoanhThu.Tables[1].Rows)
                    {
                        DateTime timeDTG = DateTime.Parse(drDTG["NgayLap"].ToString());
                        if (timeNgayBan.ToString("yyyy-MM-dd") == timeDTG.ToString("yyyy-MM-dd"))
                        {
                            total += Int32.Parse(drDTG["GiaBan"].ToString());
                        }
                    }
                    chartDT.Series["DoanhThu"].Points.AddXY(timeNgayBan.ToString("yyyy-MM-dd"), total.ToString());
                }
            }


            if (type == "radThang")
            {
                chartDT.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
                int total = 0;
                for (int i = 0; i < dsDoanhThu.Tables[0].Rows.Count; i++)
                {

                    timeNgayBan = DateTime.Parse(dsDoanhThu.Tables[0].Rows[i]["NgayLap"].ToString());
                    if (i == 0)
                    {
                        foreach (DataRow drDTG in dsDoanhThu.Tables[1].Rows)
                        {
                            DateTime timeDTG = DateTime.Parse(drDTG["NgayLap"].ToString());
                            if (timeNgayBan.ToString("yyyy-MM") == timeDTG.ToString("yyyy-MM"))
                            {
                                total += Int32.Parse(drDTG["GiaBan"].ToString());
                            }
                        }
                        chartDT.Series["DoanhThu"].Points.AddXY(timeNgayBan.ToString("yyyy-MM"), total.ToString());
                        total = 0;
                    }

                    if (i > 0)
                    {
                        DateTime ngayban = DateTime.Parse(dsDoanhThu.Tables[0].Rows[i - 1]["NgayLap"].ToString());
                        if (ngayban.ToString("yyyy-MM") != timeNgayBan.ToString("yyyy-MM"))
                        {
                            foreach (DataRow drDTG in dsDoanhThu.Tables[1].Rows)
                            {
                                DateTime timeDTG = DateTime.Parse(drDTG["NgayLap"].ToString());
                                if (timeNgayBan.ToString("yyyy-MM") == timeDTG.ToString("yyyy-MM"))
                                {
                                    total += Int32.Parse(drDTG["GiaBan"].ToString());
                                }
                            }
                            chartDT.Series["DoanhThu"].Points.AddXY(timeNgayBan.ToString("yyyy-MM"), total.ToString());
                            total = 0;
                        }
                    }

                }
            }



            if (type == "radNam")
            {
                chartDT.ChartAreas["ChartArea1"].AxisX.Title = "Năm";
                int total = 0;
                for (int i = 0; i < dsDoanhThu.Tables[0].Rows.Count; i++)
                {

                    timeNgayBan = DateTime.Parse(dsDoanhThu.Tables[0].Rows[i]["NgayLap"].ToString());
                    if (i == 0)
                    {
                        foreach (DataRow drDTG in dsDoanhThu.Tables[1].Rows)
                        {
                            DateTime timeDTG = DateTime.Parse(drDTG["NgayLap"].ToString());
                            if (timeNgayBan.ToString("yyyy") == timeDTG.ToString("yyyy"))
                            {
                                total += Int32.Parse(drDTG["GiaBan"].ToString());
                            }
                        }
                        chartDT.Series["DoanhThu"].Points.AddXY(timeNgayBan.ToString("yyyy"), total.ToString());
                        total = 0;
                    }

                    if (i > 0)
                    {
                        DateTime ngayban = DateTime.Parse(dsDoanhThu.Tables[0].Rows[i - 1]["NgayLap"].ToString());
                        if (ngayban.ToString("yyyy") != timeNgayBan.ToString("yyyy"))
                        {
                            foreach (DataRow drDTG in dsDoanhThu.Tables[1].Rows)
                            {
                                DateTime timeDTG = DateTime.Parse(drDTG["NgayLap"].ToString());
                                if (timeNgayBan.ToString("yyyy-MM") == timeDTG.ToString("yyyy-MM"))
                                {
                                    total += Int32.Parse(drDTG["GiaBan"].ToString());
                                }
                            }
                            chartDT.Series["DoanhThu"].Points.AddXY(timeNgayBan.ToString("yyyy"), total.ToString());
                            total = 0;
                        }
                    }

                }
            }

        }



        private void radNgay_CheckedChanged(object sender, EventArgs e)
        {

            if (radNgay.Checked == true)
            {
                fillChart("radNgay");

            }
        }

        private void radThang_CheckedChanged(object sender, EventArgs e)
        {
            if (radThang.Checked == true)
            {
                fillChart("radThang");
            }
        }

        private void radNam_CheckedChanged(object sender, EventArgs e)
        {
            if (radNam.Checked == true)
            {
                fillChart("radNam");
            }
        }





    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppBanDongHo
{
    public partial class frmThongKe : Form
    {
        string chuoiKN = global::AppBanDongHo.Properties.Settings.Default.DoAn1_BanDongHoConnectionString1;
        SqlConnection connect;
        DataTable tbl;
        DataTable tbDTG;
        SqlDataAdapter adp;

        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(chuoiKN);
            fillChart();

        }


        private void fillChart(string type = "")
        {

            
            chartDT.ChartAreas["ChartArea1"].AxisY.Title = "Tiền";
            chartDT.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chartDT.Series["DoanhThu"].Points.Clear();

            string selectDoanhThu = string.Format("select distinct NgayLap from HoaDon; select SanPham.TenSP, HoaDon.SoLuongBan,SanPham.GiaBan,HoaDon.NgayLap from HoaDon  inner join SanPham on SanPham.MaSP = HoaDon.MaSP  ");
            SqlDataAdapter adpDoanhThu = new SqlDataAdapter(selectDoanhThu, connect);
            DataSet dsDoanhThu = new DataSet();
            adpDoanhThu.Fill(dsDoanhThu);
            DateTime timeNgayBan = DateTime.Now;

            if (type == "radNgay")
            {
                chartDT.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
                foreach (DataRow drNgayBan in dsDoanhThu.Tables[0].Rows)
                {
                    int total = 0;
                    timeNgayBan = DateTime.Parse(drNgayBan["NgayLap"].ToString());
                    foreach (DataRow drDTG in dsDoanhThu.Tables[1].Rows)
                    {
                        DateTime timeDTG = DateTime.Parse(drDTG["NgayLap"].ToString());
                        if (timeNgayBan.ToString("yyyy-MM-dd") == timeDTG.ToString("yyyy-MM-dd"))
                        {
                            total += Int32.Parse(drDTG["GiaBan"].ToString());
                        }
                    }
                    chartDT.Series["DoanhThu"].Points.AddXY(timeNgayBan.ToString("yyyy-MM-dd"), total.ToString());
                }
            }


            if (type == "radThang")
            {
                chartDT.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
                int total = 0;
                for (int i = 0; i < dsDoanhThu.Tables[0].Rows.Count; i++)
                {

                    timeNgayBan = DateTime.Parse(dsDoanhThu.Tables[0].Rows[i]["NgayLap"].ToString());
                    if (i == 0)
                    {
                        foreach (DataRow drDTG in dsDoanhThu.Tables[1].Rows)
                        {
                            DateTime timeDTG = DateTime.Parse(drDTG["NgayLap"].ToString());
                            if (timeNgayBan.ToString("yyyy-MM") == timeDTG.ToString("yyyy-MM"))
                            {
                                total += Int32.Parse(drDTG["GiaBan"].ToString());
                            }
                        }
                        chartDT.Series["DoanhThu"].Points.AddXY(timeNgayBan.ToString("yyyy-MM"), total.ToString());
                        total = 0;
                    }

                    if (i > 0)
                    {
                        DateTime ngayban = DateTime.Parse(dsDoanhThu.Tables[0].Rows[i - 1]["NgayLap"].ToString());
                        if (ngayban.ToString("yyyy-MM") != timeNgayBan.ToString("yyyy-MM"))
                        {
                            foreach (DataRow drDTG in dsDoanhThu.Tables[1].Rows)
                            {
                                DateTime timeDTG = DateTime.Parse(drDTG["NgayLap"].ToString());
                                if (timeNgayBan.ToString("yyyy-MM") == timeDTG.ToString("yyyy-MM"))
                                {
                                    total += Int32.Parse(drDTG["GiaBan"].ToString());
                                }
                            }
                            chartDT.Series["DoanhThu"].Points.AddXY(timeNgayBan.ToString("yyyy-MM"), total.ToString());
                            total = 0;
                        }
                    }

                }
            }



            if (type == "radNam")
            {
                chartDT.ChartAreas["ChartArea1"].AxisX.Title = "Năm";
                int total = 0;
                for (int i = 0; i < dsDoanhThu.Tables[0].Rows.Count; i++)
                {

                    timeNgayBan = DateTime.Parse(dsDoanhThu.Tables[0].Rows[i]["NgayLap"].ToString());
                    if (i == 0)
                    {
                        foreach (DataRow drDTG in dsDoanhThu.Tables[1].Rows)
                        {
                            DateTime timeDTG = DateTime.Parse(drDTG["NgayLap"].ToString());
                            if (timeNgayBan.ToString("yyyy") == timeDTG.ToString("yyyy"))
                            {
                                total += Int32.Parse(drDTG["GiaBan"].ToString());
                            }
                        }
                        chartDT.Series["DoanhThu"].Points.AddXY(timeNgayBan.ToString("yyyy"), total.ToString());
                        total = 0;
                    }

                    if (i > 0)
                    {
                        DateTime ngayban = DateTime.Parse(dsDoanhThu.Tables[0].Rows[i - 1]["NgayLap"].ToString());
                        if (ngayban.ToString("yyyy") != timeNgayBan.ToString("yyyy"))
                        {
                            foreach (DataRow drDTG in dsDoanhThu.Tables[1].Rows)
                            {
                                DateTime timeDTG = DateTime.Parse(drDTG["NgayLap"].ToString());
                                if (timeNgayBan.ToString("yyyy-MM") == timeDTG.ToString("yyyy-MM"))
                                {
                                    total += Int32.Parse(drDTG["GiaBan"].ToString());
                                }
                            }
                            chartDT.Series["DoanhThu"].Points.AddXY(timeNgayBan.ToString("yyyy"), total.ToString());
                            total = 0;
                        }
                    }

                }
            }

        }



        private void radNgay_CheckedChanged(object sender, EventArgs e)
        {

            if (radNgay.Checked == true)
            {
                fillChart("radNgay");

            }
        }

        private void radThang_CheckedChanged(object sender, EventArgs e)
        {
            if (radThang.Checked == true)
            {
                fillChart("radThang");
            }
        }

        private void radNam_CheckedChanged(object sender, EventArgs e)
        {
            if (radNam.Checked == true)
            {
                fillChart("radNam");
            }
        }





    }
}
>>>>>>> 52ae496 (commit)
