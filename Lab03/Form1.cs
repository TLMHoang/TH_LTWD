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
using WMPLib;

namespace Lab03
{
    public partial class Form1 : Form
    {
        private List<string> listPlay = new List<string>();
        private int vt = 0;

        private int now = 0;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            tbrVolume.Value = wdpPlay.settings.volume;
            txtVolume.Text = tbrVolume.Value.ToString();
            tmrPlay.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;

            if (open.ShowDialog() == DialogResult.OK)
            {
                listPlay.AddRange(open.FileNames);
            }

            Thread thread = new Thread(AddListBox);
            thread.Start();
        }

        void AddListBox()
        {
            lstbListPlay.Items.Clear();
            foreach (string item in listPlay)
            {
                lstbListPlay.Items.Add(ToiUu(item));
            }
        }

        private string ToiUu(string item)
        {
            string a = item;
            int val = a.LastIndexOf(@"\");

            a = a.Remove(0, val + 1);
            a = a.Replace(".mp3", "");

            return a;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            wdpPlay.settings.balance = tbrBalance.Value;
            txtBalance.Text = tbrBalance.Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtBalance.Text == "")
            {
                txtBalance.Text = "0";
            }
            else
            {
                if (int.Parse(txtBalance.Text) > 100)
                {
                    txtBalance.Text = "100";
                }
                if (int.Parse(txtBalance.Text) < -100)
                {
                    txtBalance.Text = "-100";
                }
            
            }

            
            tbrBalance.Value = int.Parse(txtBalance.Text);
            wdpPlay.settings.balance = int.Parse(txtBalance.Text);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back)
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.KeyChar = '\0';
                }
            }
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if (btnPlayPause.Text == "Play")
            {
                btnPlayPause.Text = "Pause";
                wdpPlay.Ctlcontrols.play();
            }
            else
            {
                btnPlayPause.Text = "Play";
                wdpPlay.Ctlcontrols.pause();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            wdpPlay.Ctlcontrols.stop();
            btnPlayPause.Text = "Play";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (vt >= listPlay.Count - 1)
            {
                vt = 0;
            }
            else
            {
                vt++;
            }
            wdpPlay.URL = listPlay[vt];
        }


        private void lstbListPlay_SelectedIndexChanged(object sender, EventArgs e)
        {
            vt = lstbListPlay.SelectedIndex;
            
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (vt == 0)
            {
                vt = listPlay.Count - 1;
            }
            else
            {
                vt--;
            }
            wdpPlay.URL = listPlay[vt];
        }

        private void txtVolume_TextChanged(object sender, EventArgs e)
        {
            if (txtVolume.Text == "")
            {
                txtVolume.Text = "0";
            }
            else
            {
                if (int.Parse(txtVolume.Text) > 100)
                {
                    txtVolume.Text = "100";
                }
                if (int.Parse(txtVolume.Text) < 0)
                {
                    txtVolume.Text = "0";
                }

            }

            tbrVolume.Value = int.Parse(txtVolume.Text);
            wdpPlay.settings.volume = int.Parse(txtVolume.Text);
            
        }

        private void tbrVolume_Scroll(object sender, EventArgs e)
        {
            txtVolume.Text = tbrVolume.Value.ToString();
            wdpPlay.settings.volume = tbrVolume.Value;
        }

        private void tmrCheck_Tick(object sender, EventArgs e)
        {
            if (wdpPlay.status.Contains("Stopped"))
            {
                if (vt >= listPlay.Count - 1)
                {
                    vt = 0;
                }
                else
                {
                    vt++;
                }
                wdpPlay.URL = listPlay[vt];
            }
        }

        private void tmrPlay_Tick(object sender, EventArgs e)
        {
            if (wdpPlay.status == "" && listPlay.Count != 0)
            {
                wdpPlay.URL = listPlay[0];
                vt = 0;
                btnPlayPause.Text = "Pause";
                //tmrCheck.Start();
                ckbAutoPlay_CheckedChanged(null, null);
                tmrPlay.Stop();
            }
        }

        private void lstbListPlay_DoubleClick(object sender, EventArgs e)
        {
            wdpPlay.URL = listPlay[vt];
        }

        private void btnFastForward_Click(object sender, EventArgs e)
        {
            btnReverse.Tag = null;
            if (btnFastForward.Tag == null)
            {
                wdpPlay.Ctlcontrols.fastForward();
                btnFastForward.Tag = "1";
            }
            else
            {
                wdpPlay.Ctlcontrols.play();
                btnFastForward.Tag = null;
                
            }
            
            
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            btnFastForward.Tag = null;
            if (btnReverse.Tag == null)
            {
                btnReverse.Tag = "1";
                wdpPlay.Ctlcontrols.fastReverse();
            }
            else
            {
                wdpPlay.Ctlcontrols.play();
                btnReverse.Tag = null;
            }
        }

        private void ckbAutoPlay_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAutoPlay.Checked)
            {
                tmrCheck.Start();
            }
            else
            {
                tmrCheck.Stop();
            }
        }
    }
}
