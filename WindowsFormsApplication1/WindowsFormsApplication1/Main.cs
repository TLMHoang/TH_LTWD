using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void stripNhapDonHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLy ql = new frmQuanLy();
            ql.ShowDialog();
            this.Close();
        }

        private void stripQuanLySP_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLySanPham ql = new frmQuanLySanPham();
            ql.ShowDialog();
            this.Close();
        }

        private void stripBaoGia_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReportBaoGia rp = new frmReportBaoGia();
            rp.ShowDialog();
        }

        private void btnInXem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReportGiaoHang bg = new frmReportGiaoHang();
            bg.ShowDialog();
        }

        private void btnThemDonHang_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void LoadDuLieu()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"sever=DESKTOP-O4J424P,database=ProductOrder;uid=sa;pwd=123");
                con.Open();
                SqlCommand com = new SqlCommand("Select * from");
            }
            catch(Exception)
            {
                throw;
            }
            
        }
    }
}
