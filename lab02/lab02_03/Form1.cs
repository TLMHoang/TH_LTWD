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
                dgvTable.Rows.Add(dgvTable.RowCount, txtID.Text, txtName.Text, txtAddress.Text, txtMonney.Text);
                //dgvTable.DataSource = dgvTable;
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


        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView data = sender as DataGridView;
            

            int row = dgvTable.CurrentRow.Index;
            txtID.Text = dgvTable.Rows[row].Cells[1].Value.ToString();
            txtName.Text = dgvTable.Rows[row].Cells[2].Value.ToString();
            txtAddress.Text = dgvTable.Rows[row].Cells[3].Value.ToString();
            txtMonney.Text = dgvTable.Rows[row].Cells[4].Value.ToString();

            

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // gan bang cua DGV sang DataTable
            DataTable data = new DataTable();
            data = (DataTable)dgvTable.DataSource;




            var list = data.AsEnumerable().Where(p => p[1].ToString() == "1");

        }
    }
}
