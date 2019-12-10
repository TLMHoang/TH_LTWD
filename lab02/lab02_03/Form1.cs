using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab02_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ThemLuu()
        {
            btnThem.Text = "Hủy";
            btnThem.Enabled = false;
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                btnThem.Enabled = true;

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            ListViewItem item = new ListViewItem((listView1.Items.Count + 1).ToString());
            item.SubItems.Add(txtSTK.Text);
            item.SubItems.Add(txtTKH.Text);
            item.SubItems.Add(txtDiaChi.Text);
            item.SubItems.Add(txtSoTienTK.Text);

            listView1.Items.Add(item);

            ThemLuu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa không","Tài Khoản",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)== DialogResult.OK)
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                    listView1.Items.Remove(item);
                
            }
        }

        private void txtSTK_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int tongtien = 0;
            ListViewItem item = new ListViewItem((listView1.Items.Count + 1).ToString());
            item.SubItems.Add(txtSTK.Text);
            item.SubItems.Add(txtTKH.Text);
            item.SubItems.Add(txtDiaChi.Text);
            item.SubItems.Add(txtSoTienTK.Text);

            listView1.Items.Add(item);
            
            foreach (ListViewItem i in listView1.Items)
            {

                tongtien += int.Parse(i.SubItems[4].Text);
            }
            ThemLuu();
            txtTien.Text = tongtien.ToString();
        }
    }
}
