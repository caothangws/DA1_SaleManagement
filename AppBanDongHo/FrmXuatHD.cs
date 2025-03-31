using System;
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
    public partial class FrmXuatHD : Form
    {
        SqlConnection connect;
        SqlDataAdapter adp = new SqlDataAdapter();
        DataSet dtSet;
        public string tongTien = "";
        
        public FrmXuatHD()
        {
            InitializeComponent();
        }

        private void FrmXuatHD_Load(object sender, EventArgs e)
        {
           
        }

       
    }
}
