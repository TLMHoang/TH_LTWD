using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab02_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TaoBang();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        void TongTien()
        {
            txtTien.Text = "0";
            txtSTK.Text = "";
            txtTKH.Text = "";
            txtDiaChi.Text = "";
            txtSoTienTK.Text = "";
            foreach (ListViewItem i in lstvData.Items)
            {

                txtTien.Text = (int.Parse(txtTien.Text) + int.Parse(i.SubItems[4].Text)).ToString();
            }
            
        }

        private void TaoBang()
        {
            lstvData.Columns.Add("STT", 50);
            lstvData.Columns.Add("Mã KH", 150);
            lstvData.Columns.Add("Tên KH", 150);
            lstvData.Columns.Add("Địa chỉ", 320);
            lstvData.Columns.Add("Tiền", 170);
            lstvData.FullRowSelect = true;
            lstvData.GridLines = true;
        }

        private bool CheckNull()
        {
            if (txtSTK.Text == "")
            {
                MessageBox.Show("Chưa nhập số tài khoản");
                return false;
            }
            if (txtTKH.Text == "")
            {
                MessageBox.Show("Chưa nhập tên khách hàng");
                return false;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Chưa nhập địa chỉ");
                return false;
            }
            if (txtSoTienTK.Text == "")
            {
                MessageBox.Show("Chưa nhập Số tiền trong tài khoản");
                return false;
            }
            return true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private ListViewItem AddData()
        {
            ListViewItem item = new ListViewItem((lstvData.Items.Count + 1).ToString());
            item.SubItems.Add(txtSTK.Text);
            item.SubItems.Add(txtTKH.Text);
            item.SubItems.Add(txtDiaChi.Text);
            item.SubItems.Add(txtSoTienTK.Text);

            return item;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                Thread t = new Thread(TongTien);
                t.Start();
                lstvData.Items.Add(AddData());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa không","",MessageBoxButtons.OKCancel)== DialogResult.OK)
            {
                foreach (ListViewItem item in lstvData.SelectedItems)
                    lstvData.Items.Remove(item);
                
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                lstvData.SelectedItems[0].SubItems[1].Text = txtSTK.Text;
                lstvData.SelectedItems[0].SubItems[2].Text = txtTKH.Text;
                lstvData.SelectedItems[0].SubItems[3].Text = txtDiaChi.Text;
                lstvData.SelectedItems[0].SubItems[4].Text = txtSoTienTK.Text;
                Thread t = new Thread(TongTien);
                t.Start();
            }
            

        }

        private void txtSoTienTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back)
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.KeyChar = (char)Keys.Back;
                    MessageBox.Show("Ô này chỉ có thể nhập số không nhập được chữ");
                }
            }
            
        }

        private void lstvData_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thread thread = new Thread(LoadInfo);
            thread.Start();
        }

        void LoadInfo()
        {
            if (lstvData.SelectedItems.Count > 0)
            {
                txtSTK.Text = lstvData.SelectedItems[0].SubItems[1].Text;
                txtTKH.Text = lstvData.SelectedItems[0].SubItems[2].Text;
                txtDiaChi.Text = lstvData.SelectedItems[0].SubItems[3].Text;
                txtSoTienTK.Text = lstvData.SelectedItems[0].SubItems[4].Text;
            }
        }
    }
}
