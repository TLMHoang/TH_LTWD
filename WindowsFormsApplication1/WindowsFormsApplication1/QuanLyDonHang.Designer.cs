namespace WindowsFormsApplication1
{
    partial class frmQuanLy
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
            this.btnDatHang = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongCong = new System.Windows.Forms.TextBox();
            this.clmSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.dateNgayDat = new System.Windows.Forms.DateTimePicker();
            this.dateNgayGiao = new System.Windows.Forms.DateTimePicker();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDatHang
            // 
            this.btnDatHang.Location = new System.Drawing.Point(167, 398);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(128, 22);
            this.btnDatHang.TabIndex = 8;
            this.btnDatHang.Text = "Đặt Hàng";
            this.btnDatHang.UseVisualStyleBackColor = true;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(12, 398);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(128, 22);
            this.btnIn.TabIndex = 9;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSTT,
            this.clmMaSP,
            this.clmDVT,
            this.clmSL,
            this.clmGia,
            this.clmThanhTien});
            this.dataGridView1.Location = new System.Drawing.Point(12, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(782, 180);
            this.dataGridView1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng cộng:";
            // 
            // txtTongCong
            // 
            this.txtTongCong.Location = new System.Drawing.Point(593, 390);
            this.txtTongCong.Name = "txtTongCong";
            this.txtTongCong.ReadOnly = true;
            this.txtTongCong.Size = new System.Drawing.Size(201, 20);
            this.txtTongCong.TabIndex = 10;
            this.txtTongCong.TextChanged += new System.EventHandler(this.txtTongCong_TextChanged);
            // 
            // clmSTT
            // 
            this.clmSTT.HeaderText = "STT";
            this.clmSTT.Name = "clmSTT";
            // 
            // clmMaSP
            // 
            this.clmMaSP.HeaderText = "Mã Sản Phẩm";
            this.clmMaSP.Name = "clmMaSP";
            // 
            // clmDVT
            // 
            this.clmDVT.HeaderText = "ĐVT";
            this.clmDVT.Name = "clmDVT";
            // 
            // clmSL
            // 
            this.clmSL.HeaderText = "Số Lượng";
            this.clmSL.Name = "clmSL";
            // 
            // clmGia
            // 
            this.clmGia.HeaderText = "Giá Bán";
            this.clmGia.Name = "clmGia";
            // 
            // clmThanhTien
            // 
            this.clmThanhTien.HeaderText = "Thành Tiền";
            this.clmThanhTien.Name = "clmThanhTien";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(221, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "THÔNG TIN ĐƠN HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Theo hóa đơn só:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ngày đặt:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày giao:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ghi chú:";
            // 
            // txtSoHD
            // 
            this.txtSoHD.Location = new System.Drawing.Point(227, 62);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(191, 20);
            this.txtSoHD.TabIndex = 14;
            // 
            // dateNgayDat
            // 
            this.dateNgayDat.Location = new System.Drawing.Point(179, 92);
            this.dateNgayDat.Name = "dateNgayDat";
            this.dateNgayDat.Size = new System.Drawing.Size(190, 20);
            this.dateNgayDat.TabIndex = 15;
            // 
            // dateNgayGiao
            // 
            this.dateNgayGiao.Location = new System.Drawing.Point(473, 92);
            this.dateNgayGiao.Name = "dateNgayGiao";
            this.dateNgayGiao.Size = new System.Drawing.Size(190, 20);
            this.dateNgayGiao.TabIndex = 15;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(181, 130);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(349, 52);
            this.txtGhiChu.TabIndex = 16;
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 440);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.dateNgayGiao);
            this.Controls.Add(this.dateNgayDat);
            this.Controls.Add(this.txtSoHD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTongCong);
            this.Controls.Add(this.btnDatHang);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmQuanLy";
            this.Text = "QuanLyDonHang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDatHang;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThanhTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.DateTimePicker dateNgayDat;
        private System.Windows.Forms.DateTimePicker dateNgayGiao;
        private System.Windows.Forms.TextBox txtGhiChu;
    }
}