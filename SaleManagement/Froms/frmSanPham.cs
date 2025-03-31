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
    public partial class frmSanPham : Form
    {
        private string maNV;
        public frmSanPham(string manv)
        {
            InitializeComponent();
            this.maNV = manv;
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {

        }
    }
}
