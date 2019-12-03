using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab02
{
    public partial class Form1 : Form
    {

        private double Num1;
        private double Num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.KeyChar = (char)Keys.Back;
                MessageBox.Show("Nhap số không nhập chũ");
            }
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            Num1 = double.Parse(txtNum1.Text);
            Num2 = double.Parse(txtNum2.Text);
            txtAnswer.Text = (Num1 + Num2).ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            Num1 = double.Parse(txtNum1.Text);
            Num2 = double.Parse(txtNum2.Text);
            txtAnswer.Text = (Num1 - Num2).ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            Num1 = double.Parse(txtNum1.Text);
            Num2 = double.Parse(txtNum2.Text);
            txtAnswer.Text = (Num1 * Num2).ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            Num1 = double.Parse(txtNum1.Text);
            Num2 = double.Parse(txtNum2.Text);
            txtAnswer.Text = (Num1 / Num2).ToString();
        }
    }
}
