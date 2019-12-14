using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNguon_Click(object sender, EventArgs e)
        {
            OpenFileOrFolder(true);

        }

        public void OpenFileOrFolder(bool Check)
        {
            if (ckbFIle.Checked)
            {
                if (Check)
                {
                    OpenFileDialog open = new OpenFileDialog();
                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        txtNguon.Text = open.FileName;
                    }
                }
                else
                {
                    FolderBrowserDialog folder = new FolderBrowserDialog();
                    if (folder.ShowDialog() == DialogResult.OK)
                    {
                        txtDich.Text = folder.SelectedPath;
                    }
                }
            }
            else
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                if (folder.ShowDialog() == DialogResult.OK)
                {
                    if (Check)
                    {
                        txtNguon.Text = folder.SelectedPath;
                    }
                    else
                    {
                        txtDich.Text = folder.SelectedPath;
                    }
                }
            }
        }

        private void ckbFIle_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFIle.Checked)
            {
                ckbFolder.Checked = false;
            }
            else
            {
                ckbFolder.Checked = true;
            }
        }

        private void ckbFolder_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFolder.Checked)
            {
                ckbFIle.Checked = false;
            }
            else
            {
                ckbFIle.Checked = true;
            }
        }

        private void btnDich_Click(object sender, EventArgs e)
        {
            OpenFileOrFolder(false);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            File.Copy(txtNguon.Text, txtDich.Text);
        }

        private void tmrTick_Tick(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(prbTime);
        }
    }
}
