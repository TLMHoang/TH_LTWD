namespace Lab03_02
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
            this.prbTime = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckbFolder = new System.Windows.Forms.CheckBox();
            this.ckbFIle = new System.Windows.Forms.CheckBox();
            this.btnDich = new System.Windows.Forms.Button();
            this.btnNguon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDich = new System.Windows.Forms.TextBox();
            this.txtNguon = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.tmrTick = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // prbTime
            // 
            this.prbTime.Location = new System.Drawing.Point(12, 19);
            this.prbTime.Name = "prbTime";
            this.prbTime.Size = new System.Drawing.Size(463, 23);
            this.prbTime.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.prbTime);
            this.groupBox1.Location = new System.Drawing.Point(12, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 50);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiến trình";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCopy);
            this.groupBox2.Controls.Add(this.ckbFolder);
            this.groupBox2.Controls.Add(this.ckbFIle);
            this.groupBox2.Controls.Add(this.btnDich);
            this.groupBox2.Controls.Add(this.btnNguon);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDich);
            this.groupBox2.Controls.Add(this.txtNguon);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 180);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // ckbFolder
            // 
            this.ckbFolder.AutoSize = true;
            this.ckbFolder.Location = new System.Drawing.Point(175, 31);
            this.ckbFolder.Name = "ckbFolder";
            this.ckbFolder.Size = new System.Drawing.Size(55, 17);
            this.ckbFolder.TabIndex = 3;
            this.ckbFolder.Text = "Folder";
            this.ckbFolder.UseVisualStyleBackColor = true;
            this.ckbFolder.CheckedChanged += new System.EventHandler(this.ckbFolder_CheckedChanged);
            // 
            // ckbFIle
            // 
            this.ckbFIle.AutoSize = true;
            this.ckbFIle.Checked = true;
            this.ckbFIle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbFIle.Location = new System.Drawing.Point(89, 31);
            this.ckbFIle.Name = "ckbFIle";
            this.ckbFIle.Size = new System.Drawing.Size(42, 17);
            this.ckbFIle.TabIndex = 3;
            this.ckbFIle.Text = "File";
            this.ckbFIle.UseVisualStyleBackColor = true;
            this.ckbFIle.CheckedChanged += new System.EventHandler(this.ckbFIle_CheckedChanged);
            // 
            // btnDich
            // 
            this.btnDich.Location = new System.Drawing.Point(446, 101);
            this.btnDich.Name = "btnDich";
            this.btnDich.Size = new System.Drawing.Size(29, 23);
            this.btnDich.TabIndex = 2;
            this.btnDich.Text = "...";
            this.btnDich.UseVisualStyleBackColor = true;
            this.btnDich.Click += new System.EventHandler(this.btnDich_Click);
            // 
            // btnNguon
            // 
            this.btnNguon.Location = new System.Drawing.Point(446, 74);
            this.btnNguon.Name = "btnNguon";
            this.btnNguon.Size = new System.Drawing.Size(29, 23);
            this.btnNguon.TabIndex = 2;
            this.btnNguon.Text = "...";
            this.btnNguon.UseVisualStyleBackColor = true;
            this.btnNguon.Click += new System.EventHandler(this.btnNguon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đích";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nguồn";
            // 
            // txtDich
            // 
            this.txtDich.Location = new System.Drawing.Point(54, 103);
            this.txtDich.Name = "txtDich";
            this.txtDich.Size = new System.Drawing.Size(386, 20);
            this.txtDich.TabIndex = 0;
            // 
            // txtNguon
            // 
            this.txtNguon.Location = new System.Drawing.Point(54, 76);
            this.txtNguon.Name = "txtNguon";
            this.txtNguon.Size = new System.Drawing.Size(386, 20);
            this.txtNguon.TabIndex = 0;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(96, 143);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // tmrTick
            // 
            this.tmrTick.Tick += new System.EventHandler(this.tmrTick_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 256);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar prbTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDich;
        private System.Windows.Forms.Button btnNguon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDich;
        private System.Windows.Forms.TextBox txtNguon;
        private System.Windows.Forms.CheckBox ckbFolder;
        private System.Windows.Forms.CheckBox ckbFIle;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Timer tmrTick;
    }
}

