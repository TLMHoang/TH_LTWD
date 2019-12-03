using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab02_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                dgvTable[0, dgvTable.RowCount].Value = dgvTable.RowCount + 1;
                dgvTable[1, dgvTable.RowCount].Value = txtID;
            }
        }


        public bool Check()
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Chưa điên Số tài khoản");
                return false;
            }
            if (txtName.Text == "")
            {
                MessageBox.Show("Chưa điền Tên");
                return false;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Chưa điền Địa chỉ");
                return false;
            }
            if (txtMonney.Text == "")
            {
                MessageBox.Show("Chưa điền số tiền");
                return false;
            }
            return true;
        }

        private void txtID_Leave(object sender, EventArgs e)
        {

        }
    }
}
