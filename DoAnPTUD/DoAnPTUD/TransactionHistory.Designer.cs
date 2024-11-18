namespace DoAnPTUD
{
    partial class TransactionHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionHistory));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radTienVao = new System.Windows.Forms.RadioButton();
            this.radTienRa = new System.Windows.Forms.RadioButton();
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1046, 359);
            this.dataGridView1.TabIndex = 33;
            // 
            // radTienVao
            // 
            this.radTienVao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radTienVao.AutoSize = true;
            this.radTienVao.Location = new System.Drawing.Point(468, 194);
            this.radTienVao.Name = "radTienVao";
            this.radTienVao.Size = new System.Drawing.Size(97, 24);
            this.radTienVao.TabIndex = 0;
            this.radTienVao.TabStop = true;
            this.radTienVao.Text = "Tiền Vào";
            this.radTienVao.UseVisualStyleBackColor = true;
            this.radTienVao.CheckedChanged += new System.EventHandler(this.radTienVao_CheckedChanged);
            // 
            // radTienRa
            // 
            this.radTienRa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radTienRa.AutoSize = true;
            this.radTienRa.Location = new System.Drawing.Point(132, 194);
            this.radTienRa.Name = "radTienRa";
            this.radTienRa.Size = new System.Drawing.Size(89, 24);
            this.radTienRa.TabIndex = 1;
            this.radTienRa.TabStop = true;
            this.radTienRa.Text = "Tiền Ra";
            this.radTienRa.UseVisualStyleBackColor = true;
            this.radTienRa.CheckedChanged += new System.EventHandler(this.radTienRa_CheckedChanged_1);
            // 
            // radTatCa
            // 
            this.radTatCa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radTatCa.AutoSize = true;
            this.radTatCa.Location = new System.Drawing.Point(821, 194);
            this.radTatCa.Name = "radTatCa";
            this.radTatCa.Size = new System.Drawing.Size(81, 24);
            this.radTatCa.TabIndex = 2;
            this.radTatCa.TabStop = true;
            this.radTatCa.Text = "Tất Cả";
            this.radTatCa.UseVisualStyleBackColor = true;
            this.radTatCa.CheckedChanged += new System.EventHandler(this.radTatCa_CheckedChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageIndex = 16;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(6, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Finance-Bank-Cards-icon.png");
            this.imageList1.Images.SetKeyName(1, "Aniket-Suvarna-Box-Regular-Bx-user.512.png");
            this.imageList1.Images.SetKeyName(2, "Colebemis-Feather-Delete.512.png");
            this.imageList1.Images.SetKeyName(3, "Custom-Icon-Design-Pretty-Office-2-Search.256.png");
            this.imageList1.Images.SetKeyName(4, "Custom-Icon-Design-Pretty-Office-8-Accept.256.png");
            this.imageList1.Images.SetKeyName(5, "Fa-Team-Fontawesome-FontAwesome-Money-Bill-Transfer.512.png");
            this.imageList1.Images.SetKeyName(6, "Github-Octicons-Clock-24.512.png");
            this.imageList1.Images.SetKeyName(7, "Github-Octicons-Eye-24.512.png");
            this.imageList1.Images.SetKeyName(8, "Github-Octicons-Eye-closed-24.512.png");
            this.imageList1.Images.SetKeyName(9, "Github-Octicons-Globe-16.512.png");
            this.imageList1.Images.SetKeyName(10, "Github-Octicons-Graph-16.512.png");
            this.imageList1.Images.SetKeyName(11, "Icons8-Ios7-Finance-Money-Bag.512.png");
            this.imageList1.Images.SetKeyName(12, "Icons8-Windows-8-Animals-Dinosaur.512.png");
            this.imageList1.Images.SetKeyName(13, "Icons8-Windows-8-Finance-Bank-Cards.512.png");
            this.imageList1.Images.SetKeyName(14, "Icons8-Windows-8-Food-List-Ingredients.512.png");
            this.imageList1.Images.SetKeyName(15, "Icons8-Windows-8-Very-Basic-Menu.512.png");
            this.imageList1.Images.SetKeyName(16, "Iconsmind-Outline-Arrow-Back-3.512.png");
            this.imageList1.Images.SetKeyName(17, "Iconsmind-Outline-Bank.512.png");
            this.imageList1.Images.SetKeyName(18, "Ionic-Ionicons-Camera-outline.512.png");
            this.imageList1.Images.SetKeyName(19, "Ionic-Ionicons-Log-out-outline.512.png");
            this.imageList1.Images.SetKeyName(20, "logo.jpg");
            this.imageList1.Images.SetKeyName(21, "mau-hinh-trong-chung-khoan-7.jpg");
            this.imageList1.Images.SetKeyName(22, "Microsoft-Fluentui-Emoji-Mono-Mobile-Phone-With-Arrow.512.png");
            this.imageList1.Images.SetKeyName(23, "Papirus-Team-Papirus-Apps-Preferences-desktop-notification-bell.512.png");
            this.imageList1.Images.SetKeyName(24, "Pictogrammers-Material-Card-account-details.512.png");
            this.imageList1.Images.SetKeyName(25, "Pictogrammers-Material-Crown-circle-outline.512.png");
            this.imageList1.Images.SetKeyName(26, "Pictogrammers-Material-Information.512.png");
            this.imageList1.Images.SetKeyName(27, "Pictogrammers-Material-Light-Chevron-right.512.png");
            this.imageList1.Images.SetKeyName(28, "Pictogrammers-Material-Light-Settings.512.png");
            this.imageList1.Images.SetKeyName(29, "Pictogrammers-Material-Qrcode-scan.512.png");
            this.imageList1.Images.SetKeyName(30, "user.jpg");
            this.imageList1.Images.SetKeyName(31, "z5881071855756_8a0244d0603e51520488a519a5f1ae24.jpg");
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.Location = new System.Drawing.Point(185, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(306, 26);
            this.textBox2.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Từ Ngày ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker2.Location = new System.Drawing.Point(592, 88);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(310, 26);
            this.dateTimePicker2.TabIndex = 27;
            this.dateTimePicker2.Value = new System.DateTime(2024, 11, 9, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Đến Ngày ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Location = new System.Drawing.Point(592, 120);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(310, 26);
            this.dateTimePicker1.TabIndex = 25;
            this.dateTimePicker1.Value = new System.DateTime(2024, 11, 9, 0, 0, 0, 0);
            this.dateTimePicker1.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(789, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Lọc theo";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Từ";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "Số Tiền ",
            "Ngày Giờ"});
            this.comboBox1.Location = new System.Drawing.Point(866, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 28);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Đến ";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.Location = new System.Drawing.Point(185, 120);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(306, 26);
            this.textBox3.TabIndex = 20;
            this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ImageIndex = 3;
            this.button5.ImageList = this.imageList1;
            this.button5.Location = new System.Drawing.Point(247, 18);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 26);
            this.button5.TabIndex = 19;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(345, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 26);
            this.textBox1.TabIndex = 18;
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1052, 607);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.radTienVao);
            this.groupBox2.Controls.Add(this.radTienRa);
            this.groupBox2.Controls.Add(this.radTatCa);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1046, 236);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tra Cứu";
            // 
            // TransactionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnPTUD.Properties.Resources.logoMKP_ver2__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1052, 607);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(500, 56);
            this.Name = "TransactionHistory";
            this.Text = "TransactionHistory";
            this.Load += new System.EventHandler(this.TransactionHistory_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radTienVao;
        private System.Windows.Forms.RadioButton radTienRa;
        private System.Windows.Forms.RadioButton radTatCa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}