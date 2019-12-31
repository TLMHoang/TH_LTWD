namespace WindowsFormsApplication1
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stripDonHang = new System.Windows.Forms.ToolStripMenuItem();
            this.stripNhapDonHang = new System.Windows.Forms.ToolStripMenuItem();
            this.stripThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.stripSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.stripQuanLySP = new System.Windows.Forms.ToolStripMenuItem();
            this.stripBaoGia = new System.Windows.Forms.ToolStripMenuItem();
            this.grpThongTinDonHang = new System.Windows.Forms.GroupBox();
            this.dateKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dateBatDau = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkXemTrongThang = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNgayGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInXem = new System.Windows.Forms.Button();
            this.btnThemDonHang = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.grpThongTinDonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripDonHang,
            this.stripSanPham});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1097, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // stripDonHang
            // 
            this.stripDonHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripNhapDonHang,
            this.stripThoat});
            this.stripDonHang.Name = "stripDonHang";
            this.stripDonHang.Size = new System.Drawing.Size(96, 24);
            this.stripDonHang.Text = "Đơn Hàng";
            // 
            // stripNhapDonHang
            // 
            this.stripNhapDonHang.Name = "stripNhapDonHang";
            this.stripNhapDonHang.Size = new System.Drawing.Size(204, 26);
            this.stripNhapDonHang.Text = "Nhập đơn hàng";
            this.stripNhapDonHang.Click += new System.EventHandler(this.stripNhapDonHang_Click);
            // 
            // stripThoat
            // 
            this.stripThoat.Name = "stripThoat";
            this.stripThoat.Size = new System.Drawing.Size(204, 26);
            this.stripThoat.Text = "Thoát";
            // 
            // stripSanPham
            // 
            this.stripSanPham.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripQuanLySP,
            this.stripBaoGia});
            this.stripSanPham.Name = "stripSanPham";
            this.stripSanPham.Size = new System.Drawing.Size(98, 24);
            this.stripSanPham.Text = "Sản Phẩm";
            // 
            // stripQuanLySP
            // 
            this.stripQuanLySP.Name = "stripQuanLySP";
            this.stripQuanLySP.Size = new System.Drawing.Size(256, 26);
            this.stripQuanLySP.Text = "Quản lý sản phẩm";
            this.stripQuanLySP.Click += new System.EventHandler(this.stripQuanLySP_Click);
            // 
            // stripBaoGia
            // 
            this.stripBaoGia.Name = "stripBaoGia";
            this.stripBaoGia.Size = new System.Drawing.Size(256, 26);
            this.stripBaoGia.Text = "Xuất báo giá sản phẩm";
            this.stripBaoGia.Click += new System.EventHandler(this.stripBaoGia_Click);
            // 
            // grpThongTinDonHang
            // 
            this.grpThongTinDonHang.Controls.Add(this.dateKetThuc);
            this.grpThongTinDonHang.Controls.Add(this.dateBatDau);
            this.grpThongTinDonHang.Controls.Add(this.label2);
            this.grpThongTinDonHang.Controls.Add(this.label1);
            this.grpThongTinDonHang.Controls.Add(this.chkXemTrongThang);
            this.grpThongTinDonHang.Location = new System.Drawing.Point(16, 55);
            this.grpThongTinDonHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpThongTinDonHang.Name = "grpThongTinDonHang";
            this.grpThongTinDonHang.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpThongTinDonHang.Size = new System.Drawing.Size(1043, 122);
            this.grpThongTinDonHang.TabIndex = 1;
            this.grpThongTinDonHang.TabStop = false;
            this.grpThongTinDonHang.Text = "Thông tin đơn hàng";
            // 
            // dateKetThuc
            // 
            this.dateKetThuc.Location = new System.Drawing.Point(611, 80);
            this.dateKetThuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateKetThuc.Name = "dateKetThuc";
            this.dateKetThuc.Size = new System.Drawing.Size(265, 22);
            this.dateKetThuc.TabIndex = 3;
            // 
            // dateBatDau
            // 
            this.dateBatDau.Location = new System.Drawing.Point(232, 80);
            this.dateBatDau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateBatDau.Name = "dateBatDau";
            this.dateBatDau.Size = new System.Drawing.Size(237, 22);
            this.dateBatDau.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thời gian giao hàng";
            // 
            // chkXemTrongThang
            // 
            this.chkXemTrongThang.AutoSize = true;
            this.chkXemTrongThang.Location = new System.Drawing.Point(61, 44);
            this.chkXemTrongThang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkXemTrongThang.Name = "chkXemTrongThang";
            this.chkXemTrongThang.Size = new System.Drawing.Size(174, 21);
            this.chkXemTrongThang.TabIndex = 0;
            this.chkXemTrongThang.Text = "Xem tất cả trong tháng";
            this.chkXemTrongThang.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSTT,
            this.clmSoHD,
            this.clmNgayDat,
            this.clmNgayGiao,
            this.clmThanhTien});
            this.dataGridView1.Location = new System.Drawing.Point(16, 222);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 222);
            this.dataGridView1.TabIndex = 2;
            // 
            // clmSTT
            // 
            this.clmSTT.HeaderText = "STT";
            this.clmSTT.MinimumWidth = 6;
            this.clmSTT.Name = "clmSTT";
            this.clmSTT.Width = 125;
            // 
            // clmSoHD
            // 
            this.clmSoHD.HeaderText = "Số HĐ";
            this.clmSoHD.MinimumWidth = 6;
            this.clmSoHD.Name = "clmSoHD";
            this.clmSoHD.Width = 125;
            // 
            // clmNgayDat
            // 
            this.clmNgayDat.HeaderText = "Ngày đặt hàng";
            this.clmNgayDat.MinimumWidth = 6;
            this.clmNgayDat.Name = "clmNgayDat";
            this.clmNgayDat.Width = 125;
            // 
            // clmNgayGiao
            // 
            this.clmNgayGiao.HeaderText = "Ngày Giao Hàng";
            this.clmNgayGiao.MinimumWidth = 6;
            this.clmNgayGiao.Name = "clmNgayGiao";
            this.clmNgayGiao.Width = 125;
            // 
            // clmThanhTien
            // 
            this.clmThanhTien.HeaderText = "Thành Tiền";
            this.clmThanhTien.MinimumWidth = 6;
            this.clmThanhTien.Name = "clmThanhTien";
            this.clmThanhTien.Width = 125;
            // 
            // btnInXem
            // 
            this.btnInXem.Location = new System.Drawing.Point(16, 480);
            this.btnInXem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInXem.Name = "btnInXem";
            this.btnInXem.Size = new System.Drawing.Size(171, 27);
            this.btnInXem.TabIndex = 3;
            this.btnInXem.Text = "In/Xem";
            this.btnInXem.UseVisualStyleBackColor = true;
            this.btnInXem.Click += new System.EventHandler(this.btnInXem_Click);
            // 
            // btnThemDonHang
            // 
            this.btnThemDonHang.Location = new System.Drawing.Point(223, 480);
            this.btnThemDonHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemDonHang.Name = "btnThemDonHang";
            this.btnThemDonHang.Size = new System.Drawing.Size(171, 27);
            this.btnThemDonHang.TabIndex = 3;
            this.btnThemDonHang.Text = "Thêm Đơn Hàng";
            this.btnThemDonHang.UseVisualStyleBackColor = true;
            this.btnThemDonHang.Click += new System.EventHandler(this.btnThemDonHang_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(717, 480);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tổng cộng:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(821, 476);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 22);
            this.textBox1.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 522);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnThemDonHang);
            this.Controls.Add(this.btnInXem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpThongTinDonHang);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Quản Lý Đơn Hàng";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpThongTinDonHang.ResumeLayout(false);
            this.grpThongTinDonHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stripDonHang;
        private System.Windows.Forms.ToolStripMenuItem stripNhapDonHang;
        private System.Windows.Forms.ToolStripMenuItem stripThoat;
        private System.Windows.Forms.ToolStripMenuItem stripSanPham;
        private System.Windows.Forms.ToolStripMenuItem stripQuanLySP;
        private System.Windows.Forms.ToolStripMenuItem stripBaoGia;
        private System.Windows.Forms.GroupBox grpThongTinDonHang;
        private System.Windows.Forms.DateTimePicker dateKetThuc;
        private System.Windows.Forms.DateTimePicker dateBatDau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkXemTrongThang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNgayGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThanhTien;
        private System.Windows.Forms.Button btnInXem;
        private System.Windows.Forms.Button btnThemDonHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

