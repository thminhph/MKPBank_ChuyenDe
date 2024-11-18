namespace DoAnPTUD
{
    partial class Deposit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSoTien = new System.Windows.Forms.ComboBox();
            this.txtSoTK = new System.Windows.Forms.TextBox();
            this.btnNap = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnNap);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbSoTien);
            this.panel1.Controls.Add(this.txtSoTK);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 623);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Số tài khoản";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Số Tiền Nạp";
            // 
            // cbSoTien
            // 
            this.cbSoTien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSoTien.FormattingEnabled = true;
            this.cbSoTien.Items.AddRange(new object[] {
            "10.000",
            "20.000",
            "50.000",
            "100.000",
            "200.000",
            "500.000"});
            this.cbSoTien.Location = new System.Drawing.Point(268, 330);
            this.cbSoTien.Name = "cbSoTien";
            this.cbSoTien.Size = new System.Drawing.Size(230, 33);
            this.cbSoTien.TabIndex = 12;
            // 
            // txtSoTK
            // 
            this.txtSoTK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoTK.Enabled = false;
            this.txtSoTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTK.Location = new System.Drawing.Point(268, 240);
            this.txtSoTK.Multiline = true;
            this.txtSoTK.Name = "txtSoTK";
            this.txtSoTK.Size = new System.Drawing.Size(230, 38);
            this.txtSoTK.TabIndex = 11;
            // 
            // btnNap
            // 
            this.btnNap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNap.BorderRadius = 15;
            this.btnNap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNap.ForeColor = System.Drawing.Color.Black;
            this.btnNap.Location = new System.Drawing.Point(369, 417);
            this.btnNap.Name = "btnNap";
            this.btnNap.Size = new System.Drawing.Size(138, 55);
            this.btnNap.TabIndex = 15;
            this.btnNap.Text = "Nạp tiền";
            this.btnNap.Click += new System.EventHandler(this.btnNap_Click_2);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnPTUD.Properties.Resources.logoMKP_ver2__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(945, 623);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSoTien;
        private System.Windows.Forms.TextBox txtSoTK;
        private Guna.UI2.WinForms.Guna2Button btnNap;
    }
}