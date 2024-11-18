namespace DoAnPTUD
{
    partial class frm_DanhSachTaiKhoan
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
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtSGT = new System.Windows.Forms.TextBox();
            this.cbLoaiTK = new System.Windows.Forms.ComboBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plThongTin = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbLoaiKh = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.plThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(625, 60);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(169, 22);
            this.txtSDT.TabIndex = 47;
            this.txtSDT.Tag = "MaKH";
            // 
            // txtSGT
            // 
            this.txtSGT.Location = new System.Drawing.Point(625, 149);
            this.txtSGT.Name = "txtSGT";
            this.txtSGT.Size = new System.Drawing.Size(328, 22);
            this.txtSGT.TabIndex = 45;
            this.txtSGT.Tag = "SoGiayTo";
            // 
            // cbLoaiTK
            // 
            this.cbLoaiTK.FormattingEnabled = true;
            this.cbLoaiTK.Location = new System.Drawing.Point(153, 149);
            this.cbLoaiTK.Name = "cbLoaiTK";
            this.cbLoaiTK.Size = new System.Drawing.Size(328, 24);
            this.cbLoaiTK.TabIndex = 44;
            this.cbLoaiTK.Tag = "LoaiTK";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(153, 105);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(328, 22);
            this.txtTen.TabIndex = 43;
            this.txtTen.Tag = "Ten";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(510, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "Số giấy tờ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(510, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 38;
            this.label9.Text = "Mã khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Loại tài khoản";
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
            this.label2.Location = new System.Drawing.Point(25, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Mã tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Loại khách hàng";
            // 
            // plThongTin
            // 
            this.plThongTin.Controls.Add(this.comboBox2);
            this.plThongTin.Controls.Add(this.label5);
            this.plThongTin.Controls.Add(this.cbLoaiKh);
            this.plThongTin.Controls.Add(this.textBox1);
            this.plThongTin.Controls.Add(this.txtSDT);
            this.plThongTin.Controls.Add(this.txtSGT);
            this.plThongTin.Controls.Add(this.cbLoaiTK);
            this.plThongTin.Controls.Add(this.txtTen);
            this.plThongTin.Controls.Add(this.label8);
            this.plThongTin.Controls.Add(this.label9);
            this.plThongTin.Controls.Add(this.label4);
            this.plThongTin.Controls.Add(this.label3);
            this.plThongTin.Controls.Add(this.label2);
            this.plThongTin.Controls.Add(this.label1);
            this.plThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.plThongTin.Location = new System.Drawing.Point(0, 0);
            this.plThongTin.Name = "plThongTin";
            this.plThongTin.Size = new System.Drawing.Size(994, 189);
            this.plThongTin.TabIndex = 36;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "GBP",
            "JPY",
            "VND"});
            this.comboBox2.Location = new System.Drawing.Point(625, 105);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(169, 24);
            this.comboBox2.TabIndex = 52;
            this.comboBox2.Tag = "TienTe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Tiền tệ";
            // 
            // cbLoaiKh
            // 
            this.cbLoaiKh.FormattingEnabled = true;
            this.cbLoaiKh.Location = new System.Drawing.Point(153, 58);
            this.cbLoaiKh.Name = "cbLoaiKh";
            this.cbLoaiKh.Size = new System.Drawing.Size(200, 24);
            this.cbLoaiKh.TabIndex = 50;
            this.cbLoaiKh.Tag = "LoaiKH";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 49;
            this.textBox1.Tag = "MaTK";
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTaiKhoan.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(0, 195);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RowHeadersWidth = 51;
            this.dgvTaiKhoan.RowTemplate.Height = 24;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(994, 429);
            this.dgvTaiKhoan.TabIndex = 35;
            // 
            // frm_DanhSachTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 617);
            this.Controls.Add(this.plThongTin);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Name = "frm_DanhSachTaiKhoan";
            this.Text = "frm_DanhSachTaiKhoan";
            this.plThongTin.ResumeLayout(false);
            this.plThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtSGT;
        private System.Windows.Forms.ComboBox cbLoaiTK;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel plThongTin;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbLoaiKh;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.DataGridView dgvTaiKhoan;
    }
}