namespace DoAnPTUD
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Mở khách hàng cá nhân");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Mở khách hàng doanh nghiệp");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Danh sách khách hàng");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Hệ thống giao dịch", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Mở tài khoản");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Danh sách tài khoản");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Danh sách tài khoản đóng");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Danh sách tài khoản chặn");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Danh sách tài khoản bỏ chặn");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Tài khoản chính", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Tài khoản hiện tại và không kỳ hạn", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Tiền gửi tiền mặt");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node19");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node20");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Node21");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Giao dịch tài khoản", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Node17");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Giao dịch tài khoản", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Quản lý tài khoản", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Node2");
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnBtn = new System.Windows.Forms.Panel();
            this.pn_Body = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tvShow = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnSearchList = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnBtn.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 191);
            this.panel1.TabIndex = 6;
            // 
            // pnBtn
            // 
            this.pnBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnBtn.BackColor = System.Drawing.SystemColors.Window;
            this.pnBtn.Controls.Add(this.btnEdit);
            this.pnBtn.Controls.Add(this.btnPrint);
            this.pnBtn.Controls.Add(this.btnSearch);
            this.pnBtn.Controls.Add(this.btnRemove);
            this.pnBtn.Controls.Add(this.btnDone);
            this.pnBtn.Controls.Add(this.btnSearchList);
            this.pnBtn.Controls.Add(this.btnSave);
            this.pnBtn.Location = new System.Drawing.Point(286, 198);
            this.pnBtn.Name = "pnBtn";
            this.pnBtn.Size = new System.Drawing.Size(859, 62);
            this.pnBtn.TabIndex = 7;
            // 
            // pn_Body
            // 
            this.pn_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_Body.Location = new System.Drawing.Point(286, 257);
            this.pn_Body.Name = "pn_Body";
            this.pn_Body.Size = new System.Drawing.Size(859, 461);
            this.pn_Body.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tvShow);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 527);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "COMMERIAL BANK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tvShow
            // 
            this.tvShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvShow.Location = new System.Drawing.Point(0, 53);
            this.tvShow.Name = "tvShow";
            treeNode1.Name = "nKhachHangCaNhan";
            treeNode1.Text = "Mở khách hàng cá nhân";
            treeNode2.Name = "Node4";
            treeNode2.Text = "Mở khách hàng doanh nghiệp";
            treeNode3.Name = "Node5";
            treeNode3.Text = "Danh sách khách hàng";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Hệ thống giao dịch";
            treeNode5.Name = "Node10";
            treeNode5.Text = "Mở tài khoản";
            treeNode6.Name = "Node11";
            treeNode6.Text = "Danh sách tài khoản";
            treeNode7.Name = "Node12";
            treeNode7.Text = "Danh sách tài khoản đóng";
            treeNode8.Name = "Node14";
            treeNode8.Text = "Danh sách tài khoản chặn";
            treeNode9.Name = "Node15";
            treeNode9.Text = "Danh sách tài khoản bỏ chặn";
            treeNode10.Name = "Node9";
            treeNode10.Text = "Tài khoản chính";
            treeNode11.Name = "Node6";
            treeNode11.Text = "Tài khoản hiện tại và không kỳ hạn";
            treeNode12.Name = "Node18";
            treeNode12.Text = "Tiền gửi tiền mặt";
            treeNode13.Name = "Node19";
            treeNode13.Text = "Node19";
            treeNode14.Name = "Node20";
            treeNode14.Text = "Node20";
            treeNode15.Name = "Node21";
            treeNode15.Text = "Node21";
            treeNode16.Name = "Node16";
            treeNode16.Text = "Giao dịch tài khoản";
            treeNode17.Name = "Node17";
            treeNode17.Text = "Node17";
            treeNode18.Name = "Node7";
            treeNode18.Text = "Giao dịch tài khoản";
            treeNode19.Name = "Node1";
            treeNode19.Text = "Quản lý tài khoản";
            treeNode20.Name = "Node2";
            treeNode20.Text = "Node2";
            this.tvShow.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode19,
            treeNode20});
            this.tvShow.Size = new System.Drawing.Size(280, 474);
            this.tvShow.TabIndex = 0;
            this.tvShow.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvShow_AfterSelect);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::DoAnPTUD.Properties.Resources.inverted_mkp_commercial_bank_preview_rev_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Red;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnEdit.FlatAppearance.BorderSize = 2;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.Image = global::DoAnPTUD.Properties.Resources.Edit;
            this.btnEdit.Location = new System.Drawing.Point(327, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(45, 45);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Red;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnPrint.FlatAppearance.BorderSize = 2;
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrint.Image = global::DoAnPTUD.Properties.Resources.Print;
            this.btnPrint.Location = new System.Drawing.Point(276, 8);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(45, 45);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Red;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Image = global::DoAnPTUD.Properties.Resources.Search1;
            this.btnSearch.Location = new System.Drawing.Point(225, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(45, 45);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnRemove.FlatAppearance.BorderSize = 2;
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRemove.Image = global::DoAnPTUD.Properties.Resources.Back;
            this.btnRemove.Location = new System.Drawing.Point(174, 8);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(45, 45);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.Red;
            this.btnDone.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnDone.FlatAppearance.BorderSize = 2;
            this.btnDone.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDone.Image = global::DoAnPTUD.Properties.Resources.Done;
            this.btnDone.Location = new System.Drawing.Point(123, 8);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(45, 45);
            this.btnDone.TabIndex = 2;
            this.btnDone.UseVisualStyleBackColor = false;
            // 
            // btnSearchList
            // 
            this.btnSearchList.BackColor = System.Drawing.Color.Red;
            this.btnSearchList.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnSearchList.FlatAppearance.BorderSize = 2;
            this.btnSearchList.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchList.Image = global::DoAnPTUD.Properties.Resources.Saerch;
            this.btnSearchList.Location = new System.Drawing.Point(72, 8);
            this.btnSearchList.Name = "btnSearchList";
            this.btnSearchList.Size = new System.Drawing.Size(45, 45);
            this.btnSearchList.TabIndex = 1;
            this.btnSearchList.UseVisualStyleBackColor = false;
            this.btnSearchList.Click += new System.EventHandler(this.btnSearchList_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Red;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Image = global::DoAnPTUD.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(21, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 45);
            this.btnSave.TabIndex = 0;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 718);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnBtn);
            this.Controls.Add(this.pn_Body);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.pnBtn.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnBtn;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnSearchList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pn_Body;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tvShow;
    }
}