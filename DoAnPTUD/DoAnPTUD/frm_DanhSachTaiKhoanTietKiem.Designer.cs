namespace DoAnPTUD
{
    partial class frm_DanhSachTaiKhoanTietKiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaTK = new System.Windows.Forms.TextBox();
            this.cbMaKH = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTu = new System.Windows.Forms.TextBox();
            this.txtDen = new System.Windows.Forms.TextBox();
            this.dgvThongTin = new System.Windows.Forms.DataGridView();
            this.plThongTin = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).BeginInit();
            this.plThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(525, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hiệu trưởng";
            // 
            // txtMaTK
            // 
            this.txtMaTK.Location = new System.Drawing.Point(211, 40);
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.Size = new System.Drawing.Size(234, 22);
            this.txtMaTK.TabIndex = 3;
            this.txtMaTK.Tag = "TietKiem";
            // 
            // cbMaKH
            // 
            this.cbMaKH.FormattingEnabled = true;
            this.cbMaKH.Location = new System.Drawing.Point(211, 97);
            this.cbMaKH.Name = "cbMaKH";
            this.cbMaKH.Size = new System.Drawing.Size(234, 24);
            this.cbMaKH.TabIndex = 4;
            this.cbMaKH.Tag = "KhachHang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Từ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(629, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Đến";
            // 
            // txtTu
            // 
            this.txtTu.Location = new System.Drawing.Point(680, 40);
            this.txtTu.Name = "txtTu";
            this.txtTu.Size = new System.Drawing.Size(234, 22);
            this.txtTu.TabIndex = 7;
            this.txtTu.Tag = "Tu";
            // 
            // txtDen
            // 
            this.txtDen.Location = new System.Drawing.Point(680, 97);
            this.txtDen.Name = "txtDen";
            this.txtDen.Size = new System.Drawing.Size(234, 22);
            this.txtDen.TabIndex = 8;
            this.txtDen.Tag = "Den";
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
            this.dgvThongTin.Location = new System.Drawing.Point(3, 189);
            this.dgvThongTin.Name = "dgvThongTin";
            this.dgvThongTin.RowHeadersWidth = 51;
            this.dgvThongTin.RowTemplate.Height = 24;
            this.dgvThongTin.Size = new System.Drawing.Size(1029, 367);
            this.dgvThongTin.TabIndex = 9;
            // 
            // plThongTin
            // 
            this.plThongTin.Controls.Add(this.txtDen);
            this.plThongTin.Controls.Add(this.label1);
            this.plThongTin.Controls.Add(this.label2);
            this.plThongTin.Controls.Add(this.txtTu);
            this.plThongTin.Controls.Add(this.label3);
            this.plThongTin.Controls.Add(this.label5);
            this.plThongTin.Controls.Add(this.txtMaTK);
            this.plThongTin.Controls.Add(this.label4);
            this.plThongTin.Controls.Add(this.cbMaKH);
            this.plThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.plThongTin.Location = new System.Drawing.Point(0, 0);
            this.plThongTin.Name = "plThongTin";
            this.plThongTin.Size = new System.Drawing.Size(1031, 183);
            this.plThongTin.TabIndex = 10;
            // 
            // frm_DanhSachTaiKhoanTietKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 557);
            this.Controls.Add(this.plThongTin);
            this.Controls.Add(this.dgvThongTin);
            this.Name = "frm_DanhSachTaiKhoanTietKiem";
            this.Text = "frm_DanhSachTaiKhoanTietKiem";
            this.Load += new System.EventHandler(this.frm_DanhSachTaiKhoanTietKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).EndInit();
            this.plThongTin.ResumeLayout(false);
            this.plThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaTK;
        private System.Windows.Forms.ComboBox cbMaKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTu;
        private System.Windows.Forms.TextBox txtDen;
        private System.Windows.Forms.DataGridView dgvThongTin;
        private System.Windows.Forms.Panel plThongTin;
    }
}