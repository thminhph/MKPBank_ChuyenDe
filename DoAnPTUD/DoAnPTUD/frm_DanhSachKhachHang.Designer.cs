namespace DoAnPTUD
{
    partial class frm_DanhSachKhachHang
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
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.plThongTin = new System.Windows.Forms.Panel();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.cbNganh = new System.Windows.Forms.ComboBox();
            this.txtSGT = new System.Windows.Forms.TextBox();
            this.cbNganhChinh = new System.Windows.Forms.ComboBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.cbLoaiKh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.plThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKhachHang.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Location = new System.Drawing.Point(12, 195);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(1003, 438);
            this.dgvKhachHang.TabIndex = 32;
            // 
            // plThongTin
            // 
            this.plThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plThongTin.Controls.Add(this.txtSDT);
            this.plThongTin.Controls.Add(this.cbNganh);
            this.plThongTin.Controls.Add(this.txtSGT);
            this.plThongTin.Controls.Add(this.cbNganhChinh);
            this.plThongTin.Controls.Add(this.txtTen);
            this.plThongTin.Controls.Add(this.txtMaKH);
            this.plThongTin.Controls.Add(this.cbLoaiKh);
            this.plThongTin.Controls.Add(this.label7);
            this.plThongTin.Controls.Add(this.label8);
            this.plThongTin.Controls.Add(this.label9);
            this.plThongTin.Controls.Add(this.label4);
            this.plThongTin.Controls.Add(this.label3);
            this.plThongTin.Controls.Add(this.label2);
            this.plThongTin.Controls.Add(this.label1);
            this.plThongTin.Location = new System.Drawing.Point(3, 1);
            this.plThongTin.Name = "plThongTin";
            this.plThongTin.Size = new System.Drawing.Size(1024, 188);
            this.plThongTin.TabIndex = 34;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(566, 61);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(169, 22);
            this.txtSDT.TabIndex = 47;
            this.txtSDT.Tag = "SoDienThoai";
            // 
            // cbNganh
            // 
            this.cbNganh.FormattingEnabled = true;
            this.cbNganh.Location = new System.Drawing.Point(566, 149);
            this.cbNganh.Name = "cbNganh";
            this.cbNganh.Size = new System.Drawing.Size(328, 24);
            this.cbNganh.TabIndex = 46;
            this.cbNganh.Tag = "IdNganh";
            // 
            // txtSGT
            // 
            this.txtSGT.Location = new System.Drawing.Point(566, 105);
            this.txtSGT.Name = "txtSGT";
            this.txtSGT.Size = new System.Drawing.Size(328, 22);
            this.txtSGT.TabIndex = 45;
            this.txtSGT.Tag = "SoGiayTo";
            // 
            // cbNganhChinh
            // 
            this.cbNganhChinh.FormattingEnabled = true;
            this.cbNganhChinh.Location = new System.Drawing.Point(141, 149);
            this.cbNganhChinh.Name = "cbNganhChinh";
            this.cbNganhChinh.Size = new System.Drawing.Size(328, 24);
            this.cbNganhChinh.TabIndex = 44;
            this.cbNganhChinh.Tag = "NganhChinh";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(141, 105);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(328, 22);
            this.txtTen.TabIndex = 43;
            this.txtTen.Tag = "Ten";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(141, 61);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(328, 22);
            this.txtMaKH.TabIndex = 42;
            this.txtMaKH.Tag = "IdKhachHang";
            // 
            // cbLoaiKh
            // 
            this.cbLoaiKh.FormattingEnabled = true;
            this.cbLoaiKh.Items.AddRange(new object[] {
            "Cá nhân",
            "Doanh Nghiệp"});
            this.cbLoaiKh.Location = new System.Drawing.Point(141, 17);
            this.cbLoaiKh.Name = "cbLoaiKh";
            this.cbLoaiKh.Size = new System.Drawing.Size(231, 24);
            this.cbLoaiKh.TabIndex = 41;
            this.cbLoaiKh.Tag = "Loai";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(475, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "Ngành";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(475, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "Số giấy tờ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(475, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 16);
            this.label9.TabIndex = 38;
            this.label9.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ngành chính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tên đầy đủ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Mã khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Loại khách hàng";
            // 
            // frm_DanhSachKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 645);
            this.Controls.Add(this.plThongTin);
            this.Controls.Add(this.dgvKhachHang);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_DanhSachKhachHang";
            this.Text = "frm_DanhSachNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.plThongTin.ResumeLayout(false);
            this.plThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel plThongTin;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.ComboBox cbNganh;
        private System.Windows.Forms.TextBox txtSGT;
        private System.Windows.Forms.ComboBox cbNganhChinh;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.ComboBox cbLoaiKh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvKhachHang;
    }
}