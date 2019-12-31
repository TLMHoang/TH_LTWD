using Lap04.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap04
{
    public partial class frmFalculty : Form
    {
        private List<Falculty> Lst = new List<Falculty>();
        private HandleDB db = new HandleDB();
        private Falculty f = new Falculty();
        public frmFalculty()
        {
            InitializeComponent();
        }

        public frmFalculty(List<Falculty> lst)
        {
            InitializeComponent();

            Lst = lst;
            dgvData.DataSource = lst;
        }

        private async void btnAU_Click(object sender, EventArgs e)
        {
            f.FacultyID = int.Parse(txtID.Text);
            f.FacultyName = txtName.Text;

            if ((await f.CapNhap(f)))
            {
                MessageBox.Show("Cập nhập thành công.");
            }
            else
            {
                if (await f.Them(f))
                {
                    MessageBox.Show("Thêm Thành công");
                }
            }
            Lst = db.Falculty.ToList();
            dgvData.DataSource = Lst;

            f = new Falculty();
        }

        private void frmFalculty_Load(object sender, EventArgs e)
        {

        }
    }
}
