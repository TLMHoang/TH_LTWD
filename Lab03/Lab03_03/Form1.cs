using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab03_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadFont();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode.Equals(Keys.N))
                {
                    tsmiNew_Click(null, null);
                    MessageBox.Show("Tao Mới");
                }
            }
        }

        private void tsmiNew_Click(object sender, EventArgs e)
        {
            rtxtData.Text = "";
            rtxtData.Font = new Font("Tahoma", 14);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        public void LoadFont()
        {
            InstalledFontCollection installed = new InstalledFontCollection();

            foreach (FontFamily item in installed.Families)
            {
                tscbxFont.Items.Add(item.Name);
            }
            tscbxFont.Items.RemoveAt(0);
            string[] A = { "8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72" };

            tscbxSize.Items.AddRange(A);
            
        }

        private void tscbxFont_TextChanged(object sender, EventArgs e)
        {
            rtxtData.Font = new Font(tscbxFont.Text, float.Parse(tscbxSize.Text));
        }

        private void tscbxSize_TextChanged(object sender, EventArgs e)
        {
            if (tscbxSize.Text == "")
            {
                tscbxSize.Text = "14";
            }
            rtxtData.Font = new Font(tscbxFont.Text, float.Parse(tscbxSize.Text));
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog open = new SaveFileDialog();
            open.DefaultExt = "txt";
            string path = "";

            if (open.ShowDialog() == DialogResult.OK)
            {
                path = open.FileName;
                FileStream file = new FileStream(path, FileMode.Create);
                StreamWriter stream = new StreamWriter(file, Encoding.UTF8);

                stream.Write(rtxtData.Text);
                stream.Close();
                file.Close();
            }
        }

        private void DinhDangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog open = new FontDialog();
            open.Font = rtxtData.Font;
            open.ShowColor = true;
            if (open.ShowDialog() != DialogResult.Cancel)
            {
                rtxtData.Font = open.Font;
                //Form1 form = ne
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //rtxtData.Font = new Font(tscbxFont.Text, float.Parse(tscbxSize.Text), FontStyle.Underline);
            //rtxtData.Font = new Font()
        }

    }
}
