using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmReportGiaoHang : Form
    {
        public frmReportGiaoHang()
        {
            InitializeComponent();
        }

        private void BaoGiaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void frmReportGiaoHang_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
