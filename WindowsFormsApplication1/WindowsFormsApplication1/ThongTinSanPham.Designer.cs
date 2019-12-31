namespace WindowsFormsApplication1
{
    partial class frmQuanLySanPham
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
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.datgDanhSach = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.cbxDVT = new System.Windows.Forms.ComboBox();
            this.txtGiaMua = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.clmSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGiaMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datgDanhSach)).BeginInit();
            this.grpChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.txtGiaBan);
            this.grpThongTin.Controls.Add(this.txtGiaMua);
            this.grpThongTin.Controls.Add(this.cbxDVT);
            this.grpThongTin.Controls.Add(this.txtTen);
            this.grpThongTin.Controls.Add(this.txtMa);
            this.grpThongTin.Controls.Add(this.label5);
            this.grpThongTin.Controls.Add(this.label4);
            this.grpThongTin.Controls.Add(this.label3);
            this.grpThongTin.Controls.Add(this.label2);
            this.grpThongTin.Controls.Add(this.label1);
            this.grpThongTin.Location = new System.Drawing.Point(21, 42);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(276, 216);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông Tin Sản Phẩm";
            // 
            // datgDanhSach
            // 
            this.datgDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datgDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSTT,
            this.clmMA,
            this.clmTen,
            this.clmDVT,
            this.clmGiaMua,
            this.clmGiaBan});
            this.datgDanhSach.Location = new System.Drawing.Point(321, 42);
            this.datgDanhSach.Name = "datgDanhSach";
            this.datgDanhSach.Size = new System.Drawing.Size(786, 324);
            this.datgDanhSach.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Sản Phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn Vị Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá Mua";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giá Bán";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(95, 30);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(175, 20);
            this.txtMa.TabIndex = 1;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(95, 62);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(175, 20);
            this.txtTen.TabIndex = 1;
            // 
            // cbxDVT
            // 
            this.cbxDVT.FormattingEnabled = true;
            this.cbxDVT.Location = new System.Drawing.Point(95, 96);
            this.cbxDVT.Name = "cbxDVT";
            this.cbxDVT.Size = new System.Drawing.Size(175, 21);
            this.cbxDVT.TabIndex = 2;
            // 
            // txtGiaMua
            // 
            this.txtGiaMua.Location = new System.Drawing.Point(95, 127);
            this.txtGiaMua.Name = "txtGiaMua";
            this.txtGiaMua.Size = new System.Drawing.Size(175, 20);
            this.txtGiaMua.TabIndex = 3;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(95, 155);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(175, 20);
            this.txtGiaBan.TabIndex = 3;
            // 
            // grpChucNang
            // 
            this.grpChucNang.Controls.Add(this.btnTroVe);
            this.grpChucNang.Controls.Add(this.btnXoa);
            this.grpChucNang.Controls.Add(this.btnCapNhat);
            this.grpChucNang.Location = new System.Drawing.Point(21, 337);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(276, 47);
            this.grpChucNang.TabIndex = 2;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Chức Năng";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(26, 19);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 0;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(107, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(195, 19);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(75, 23);
            this.btnTroVe.TabIndex = 0;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            // 
            // clmSTT
            // 
            this.clmSTT.HeaderText = "STT";
            this.clmSTT.Name = "clmSTT";
            // 
            // clmMA
            // 
            this.clmMA.HeaderText = "Mã SP";
            this.clmMA.Name = "clmMA";
            // 
            // clmTen
            // 
            this.clmTen.HeaderText = "Tên SP";
            this.clmTen.Name = "clmTen";
            // 
            // clmDVT
            // 
            this.clmDVT.HeaderText = "ĐVT";
            this.clmDVT.Name = "clmDVT";
            // 
            // clmGiaMua
            // 
            this.clmGiaMua.HeaderText = "Giá Mua";
            this.clmGiaMua.Name = "clmGiaMua";
            // 
            // clmGiaBan
            // 
            this.clmGiaBan.HeaderText = "Giá Bán";
            this.clmGiaBan.Name = "clmGiaBan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(414, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // frmQuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 387);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.datgDanhSach);
            this.Controls.Add(this.grpThongTin);
            this.Name = "frmQuanLySanPham";
            this.Text = "ThongTinSanPham";
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datgDanhSach)).EndInit();
            this.grpChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView datgDanhSach;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtGiaMua;
        private System.Windows.Forms.ComboBox cbxDVT;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGiaMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGiaBan;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label label6;
    }
}