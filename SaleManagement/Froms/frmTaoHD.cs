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
        private int maKH;
        public frmTaoHD(int makh)
        {
            InitializeComponent();
            maKH = makh;    
        }
    }
}
