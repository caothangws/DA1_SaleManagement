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

namespace SaleManagement.Froms
{
    public partial class frmTaoHD : Form
    {
        ModelSale context = new ModelSale();
        private int maKH;
        public frmTaoHD(int makh)
        {
            InitializeComponent();
            maKH = makh;    
        }

        private void frmTaoHD_Load(object sender, EventArgs e)
        {
            loadDanhMuc();
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
    }
}
