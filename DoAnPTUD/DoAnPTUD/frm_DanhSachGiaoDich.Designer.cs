namespace DoAnPTUD
{
    partial class frm_DanhSachGiaoDich
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
            this.plThongTin = new System.Windows.Forms.Panel();
            this.txtTKKH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTienTe = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbLoaiTK = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTu = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtMaGD = new System.Windows.Forms.TextBox();
            this.cbLoaiGD = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvThongTin = new System.Windows.Forms.DataGridView();
            this.plThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).BeginInit();
            this.SuspendLayout();
            // 
            // plThongTin
            // 
            this.plThongTin.Controls.Add(this.txtTKKH);
            this.plThongTin.Controls.Add(this.label9);
            this.plThongTin.Controls.Add(this.txtMaKH);
            this.plThongTin.Controls.Add(this.label8);
            this.plThongTin.Controls.Add(this.cbTienTe);
            this.plThongTin.Controls.Add(this.label7);
            this.plThongTin.Controls.Add(this.cbLoaiTK);
            this.plThongTin.Controls.Add(this.label3);
            this.plThongTin.Controls.Add(this.txtDen);
            this.plThongTin.Controls.Add(this.label6);
            this.plThongTin.Controls.Add(this.txtTu);
            this.plThongTin.Controls.Add(this.txtHoten);
            this.plThongTin.Controls.Add(this.txtMaGD);
            this.plThongTin.Controls.Add(this.cbLoaiGD);
            this.plThongTin.Controls.Add(this.label5);
            this.plThongTin.Controls.Add(this.label4);
            this.plThongTin.Controls.Add(this.label2);
            this.plThongTin.Controls.Add(this.label1);
            this.plThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.plThongTin.Location = new System.Drawing.Point(0, 0);
            this.plThongTin.Name = "plThongTin";
            this.plThongTin.Size = new System.Drawing.Size(1079, 221);
            this.plThongTin.TabIndex = 0;
            // 
            // txtTKKH
            // 
            this.txtTKKH.Location = new System.Drawing.Point(720, 170);
            this.txtTKKH.Name = "txtTKKH";
            this.txtTKKH.Size = new System.Drawing.Size(299, 22);
            this.txtTKKH.TabIndex = 19;
            this.txtTKKH.Tag = "TaiKhoan";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(532, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tài khoản khách hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(720, 124);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(299, 22);
            this.txtMaKH.TabIndex = 17;
            this.txtMaKH.Tag = "MaKhachHang";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(532, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Mã khách hàng";
            // 
            // cbTienTe
            // 
            this.cbTienTe.FormattingEnabled = true;
            this.cbTienTe.Items.AddRange(new object[] {
            "",
            "USD",
            "EUR",
            "GBP",
            "JPY",
            "VND"});
            this.cbTienTe.Location = new System.Drawing.Point(720, 75);
            this.cbTienTe.Name = "cbTienTe";
            this.cbTienTe.Size = new System.Drawing.Size(83, 24);
            this.cbTienTe.TabIndex = 15;
            this.cbTienTe.Tag = "TienTe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(532, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tiền tệ";
            // 
            // cbLoaiTK
            // 
            this.cbLoaiTK.FormattingEnabled = true;
            this.cbLoaiTK.Location = new System.Drawing.Point(720, 29);
            this.cbLoaiTK.Name = "cbLoaiTK";
            this.cbLoaiTK.Size = new System.Drawing.Size(218, 24);
            this.cbLoaiTK.TabIndex = 13;
            this.cbLoaiTK.Tag = "LoaiTaiKhoan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(532, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Loại tài khoản";
            // 
            // txtDen
            // 
            this.txtDen.Location = new System.Drawing.Point(355, 170);
            this.txtDen.Name = "txtDen";
            this.txtDen.Size = new System.Drawing.Size(126, 22);
            this.txtDen.TabIndex = 11;
            this.txtDen.Tag = "Den";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "ĐẾN";
            // 
            // txtTu
            // 
            this.txtTu.Location = new System.Drawing.Point(182, 170);
            this.txtTu.Name = "txtTu";
            this.txtTu.Size = new System.Drawing.Size(126, 22);
            this.txtTu.TabIndex = 9;
            this.txtTu.Tag = "Tu";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(182, 124);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(299, 22);
            this.txtHoten.TabIndex = 8;
            this.txtHoten.Tag = "HoTen";
            // 
            // txtMaGD
            // 
            this.txtMaGD.Location = new System.Drawing.Point(182, 75);
            this.txtMaGD.Name = "txtMaGD";
            this.txtMaGD.Size = new System.Drawing.Size(218, 22);
            this.txtMaGD.TabIndex = 6;
            this.txtMaGD.Tag = "MaGiaoDich";
            // 
            // cbLoaiGD
            // 
            this.cbLoaiGD.FormattingEnabled = true;
            this.cbLoaiGD.Location = new System.Drawing.Point(182, 29);
            this.cbLoaiGD.Name = "cbLoaiGD";
            this.cbLoaiGD.Size = new System.Drawing.Size(218, 24);
            this.cbLoaiGD.TabIndex = 5;
            this.cbLoaiGD.Tag = "LoaiGiaoDich";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Họ và Tên ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã giao dịch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại giao dịch";
            // 
            // dgvThongTin
            // 
            this.dgvThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThongTin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvThongTin.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTin.Location = new System.Drawing.Point(0, 220);
            this.dgvThongTin.Name = "dgvThongTin";
            this.dgvThongTin.RowHeadersWidth = 51;
            this.dgvThongTin.RowTemplate.Height = 24;
            this.dgvThongTin.Size = new System.Drawing.Size(1079, 376);
            this.dgvThongTin.TabIndex = 1;
            // 
            // frm_DanhSachGiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 596);
            this.Controls.Add(this.dgvThongTin);
            this.Controls.Add(this.plThongTin);
            this.Name = "frm_DanhSachGiaoDich";
            this.Text = "frm_DanhSachGiaoDich";
            this.Load += new System.EventHandler(this.frm_DanhSachGiaoDich_Load);
            this.plThongTin.ResumeLayout(false);
            this.plThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plThongTin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTu;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtMaGD;
        private System.Windows.Forms.ComboBox cbLoaiGD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTKKH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTienTe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbLoaiTK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvThongTin;
    }
}