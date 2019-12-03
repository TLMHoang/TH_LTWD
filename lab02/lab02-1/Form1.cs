using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab02_1
{

    public partial class Form1 : Form
    {
        private List<List<Label>> maTrix;
        public List<List<Label>> Matrix
        {
            get
            {
                return maTrix;
            }

            set
            {
                maTrix = value;
            }
        }
        public Form1()
        {
            InitializeComponent();
            Matrix = new List<List<Label>>();
            CreateRoom();
            btnThanhToan.Enabled = false;
        }



        private void CreateRoom()
        {
            for (int i = 0; i < tlpRoom.RowCount; i++)
            {
                Matrix.Add(new List<Label>());
                for (int j = 0; j < tlpRoom.ColumnCount; j++)
                {
                    Label lbl = new Label
                    {
                        Text = ((i + 1) * (j + 1)).ToString(),
                        BorderStyle = BorderStyle.Fixed3D,
                        Dock = DockStyle.Fill,
                        Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Bold),
                        TextAlign = ContentAlignment.MiddleCenter,
                        BackColor = Color.White,
                        Tag = i.ToString()
                    };
                    lbl.Click += label_Click;
                    tlpRoom.Controls.Add(lbl);
                    maTrix[i].Add(lbl);
                }
            }
        }

        private void label_Click(object sender, EventArgs e)
        {
            btnThanhToan.Enabled = false;
            Label lbl = sender as Label;
            if (lbl.BackColor != Color.Yellow)
            {
                if (lbl.BackColor == Color.White)
                {
                    lbl.BackColor = Color.Blue;
                }
                else
                {
                    lbl.BackColor = Color.White;
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Ghế đã có người mua. Không thể chọn lại.\n Bạn muốn hủy nó. Yes để hủy, No để bỏ qua.", "", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.None:
                        break;
                    case DialogResult.OK:
                        break;
                    case DialogResult.Cancel:
                        break;
                    case DialogResult.Abort:
                        break;
                    case DialogResult.Retry:
                        break;
                    case DialogResult.Ignore:
                        break;
                    case DialogResult.Yes:
                        if (CheckHuy())
                        {
                            lbl.BackColor = Color.White;
                            
                        }
                        else
                        {
                            MessageBox.Show("Có Ghế dang chon không thể hủy");
                        }
                        
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
            }
        }

        private bool CheckHuy()
        {
            for (int row = 0; row < Matrix.Count; row++)
            {
                for (int col = 0; col < Matrix[row].Count; col++)
                {
                    if (Matrix[row][col].BackColor == Color.Blue)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int Tien = 0;
            for (int row = 0; row < Matrix.Count; row++)
            {
                for (int col = 0; col < Matrix[row].Count; col++)
                {
                    if (Matrix[row][col].BackColor == Color.Blue)
                    {
                        if (Matrix[row][col].BackColor == Color.Blue)
                        {
                            switch (row)
                            {
                                case 0:
                                    Tien += 5000;
                                    break;
                                case 1:
                                    Tien += 6500;
                                    break;
                                default:
                                    Tien += 8000;
                                    break;
                            }
                        }
                        
                    }
                }
            }
            lblTien.Text = Tien.ToString();
            btnThanhToan.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < Matrix.Count; row++)
            {
                for (int col = 0; col < Matrix[row].Count; col++)
                {
                    if (Matrix[row][col].BackColor == Color.Blue)
                    {
                        Matrix[row][col].BackColor = Color.Yellow;
                    }
                }
            }
            lblTien.Text = "0";
        }
    }
    
}
