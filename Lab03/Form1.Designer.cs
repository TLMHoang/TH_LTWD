namespace Lab03
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.wdpPlay = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.tbrBalance = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lstbListPlay = new System.Windows.Forms.ListBox();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.tbrVolume = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tmrCheck = new System.Windows.Forms.Timer(this.components);
            this.tmrPlay = new System.Windows.Forms.Timer(this.components);
            this.btnFastForward = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckbAutoPlay = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.wdpPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrVolume)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wdpPlay
            // 
            this.wdpPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wdpPlay.Enabled = true;
            this.wdpPlay.Location = new System.Drawing.Point(0, 2);
            this.wdpPlay.Name = "wdpPlay";
            this.wdpPlay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wdpPlay.OcxState")));
            this.wdpPlay.Size = new System.Drawing.Size(506, 363);
            this.wdpPlay.TabIndex = 0;
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(6, 50);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(47, 23);
            this.btnOpenFileDialog.TabIndex = 1;
            this.btnOpenFileDialog.Text = "Open";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbrBalance
            // 
            this.tbrBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbrBalance.Location = new System.Drawing.Point(576, 371);
            this.tbrBalance.Maximum = 100;
            this.tbrBalance.Minimum = -100;
            this.tbrBalance.Name = "tbrBalance";
            this.tbrBalance.Size = new System.Drawing.Size(218, 45);
            this.tbrBalance.TabIndex = 4;
            this.tbrBalance.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(512, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Balance";
            // 
            // txtBalance
            // 
            this.txtBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBalance.Location = new System.Drawing.Point(524, 390);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(34, 20);
            this.txtBalance.TabIndex = 6;
            this.txtBalance.Text = "0";
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBalance.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Location = new System.Drawing.Point(6, 15);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(75, 23);
            this.btnPlayPause.TabIndex = 7;
            this.btnPlayPause.Text = "Play";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(87, 15);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(411, 15);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(249, 15);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lstbListPlay
            // 
            this.lstbListPlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbListPlay.FormattingEnabled = true;
            this.lstbListPlay.Location = new System.Drawing.Point(512, 10);
            this.lstbListPlay.Name = "lstbListPlay";
            this.lstbListPlay.Size = new System.Drawing.Size(282, 355);
            this.lstbListPlay.TabIndex = 8;
            this.lstbListPlay.SelectedIndexChanged += new System.EventHandler(this.lstbListPlay_SelectedIndexChanged);
            this.lstbListPlay.DoubleClick += new System.EventHandler(this.lstbListPlay_DoubleClick);
            // 
            // txtVolume
            // 
            this.txtVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVolume.Location = new System.Drawing.Point(524, 442);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(34, 20);
            this.txtVolume.TabIndex = 9;
            this.txtVolume.Text = "0";
            this.txtVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVolume.TextChanged += new System.EventHandler(this.txtVolume_TextChanged);
            this.txtVolume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // tbrVolume
            // 
            this.tbrVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbrVolume.Location = new System.Drawing.Point(576, 422);
            this.tbrVolume.Maximum = 100;
            this.tbrVolume.Name = "tbrVolume";
            this.tbrVolume.Size = new System.Drawing.Size(218, 45);
            this.tbrVolume.TabIndex = 4;
            this.tbrVolume.Scroll += new System.EventHandler(this.tbrVolume_Scroll);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(512, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Volume";
            // 
            // tmrCheck
            // 
            this.tmrCheck.Interval = 1000;
            this.tmrCheck.Tick += new System.EventHandler(this.tmrCheck_Tick);
            // 
            // tmrPlay
            // 
            this.tmrPlay.Tick += new System.EventHandler(this.tmrPlay_Tick);
            // 
            // btnFastForward
            // 
            this.btnFastForward.Location = new System.Drawing.Point(330, 15);
            this.btnFastForward.Name = "btnFastForward";
            this.btnFastForward.Size = new System.Drawing.Size(75, 23);
            this.btnFastForward.TabIndex = 10;
            this.btnFastForward.Text = "FastForward";
            this.btnFastForward.UseVisualStyleBackColor = true;
            this.btnFastForward.Click += new System.EventHandler(this.btnFastForward_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(168, 15);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(75, 23);
            this.btnReverse.TabIndex = 10;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.ckbAutoPlay);
            this.panel1.Controls.Add(this.btnReverse);
            this.panel1.Controls.Add(this.btnFastForward);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnPlayPause);
            this.panel1.Controls.Add(this.btnOpenFileDialog);
            this.panel1.Location = new System.Drawing.Point(6, 372);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 117);
            this.panel1.TabIndex = 11;
            // 
            // ckbAutoPlay
            // 
            this.ckbAutoPlay.AutoSize = true;
            this.ckbAutoPlay.Location = new System.Drawing.Point(115, 73);
            this.ckbAutoPlay.Name = "ckbAutoPlay";
            this.ckbAutoPlay.Size = new System.Drawing.Size(68, 17);
            this.ckbAutoPlay.TabIndex = 11;
            this.ckbAutoPlay.Text = "AutoPlay";
            this.ckbAutoPlay.UseVisualStyleBackColor = true;
            this.ckbAutoPlay.CheckedChanged += new System.EventHandler(this.ckbAutoPlay_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.lstbListPlay);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbrVolume);
            this.Controls.Add(this.tbrBalance);
            this.Controls.Add(this.wdpPlay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.wdpPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrVolume)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wdpPlay;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.TrackBar tbrBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.ListBox lstbListPlay;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.TrackBar tbrVolume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmrCheck;
        private System.Windows.Forms.Timer tmrPlay;
        private System.Windows.Forms.Button btnFastForward;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ckbAutoPlay;
    }
}

