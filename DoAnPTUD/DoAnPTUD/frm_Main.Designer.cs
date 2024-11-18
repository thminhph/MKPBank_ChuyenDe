namespace DoAnPTUD
{
    partial class frm_Main
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
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Mở khách hàng cá nhân");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Mở khách hàng doanh nghiệp");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Danh sách khách hàng");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("Hệ thống giao dịch", new System.Windows.Forms.TreeNode[] {
            treeNode52,
            treeNode53,
            treeNode54});
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("Mở tài khoản");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("Danh sách tài khoản");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("Tài khoản chính", new System.Windows.Forms.TreeNode[] {
            treeNode56,
            treeNode57});
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("Tiền gửi tiền mặt");
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("Rút tiền mặt");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("Danh sách giao dịch");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("Giao dịch khách hàng", new System.Windows.Forms.TreeNode[] {
            treeNode59,
            treeNode60,
            treeNode61});
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("Giao dịch tài khoản", new System.Windows.Forms.TreeNode[] {
            treeNode62});
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("Tài khoản hiện tại và không kỳ hạn", new System.Windows.Forms.TreeNode[] {
            treeNode58,
            treeNode63});
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("Mở");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("Danh sách tài khoản tiết kiệm");
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("Tài khoản tiết kiệm", new System.Windows.Forms.TreeNode[] {
            treeNode65,
            treeNode66});
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("Quản lý tài khoản", new System.Windows.Forms.TreeNode[] {
            treeNode64,
            treeNode67});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tvShow = new System.Windows.Forms.TreeView();
            this.pn_Body = new System.Windows.Forms.Panel();
            this.pnBtn = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnSearchList = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 167);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(1017, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ĐĂNG XUẤT";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::DoAnPTUD.Properties.Resources.inverted_mkp_commercial_bank_preview_rev_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tvShow);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 551);
            this.panel2.TabIndex = 4;
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
            this.label1.Size = new System.Drawing.Size(232, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "COMMERIAL BANK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tvShow
            // 
            this.tvShow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvShow.Location = new System.Drawing.Point(0, 53);
            this.tvShow.Name = "tvShow";
            treeNode52.Name = "nKhachHangCaNhan";
            treeNode52.Text = "Mở khách hàng cá nhân";
            treeNode53.Name = "Node4";
            treeNode53.Text = "Mở khách hàng doanh nghiệp";
            treeNode54.Name = "Node5";
            treeNode54.Text = "Danh sách khách hàng";
            treeNode55.Name = "Node0";
            treeNode55.Text = "Hệ thống giao dịch";
            treeNode56.Name = "Node10";
            treeNode56.Text = "Mở tài khoản";
            treeNode57.Name = "Node11";
            treeNode57.Text = "Danh sách tài khoản";
            treeNode58.Name = "Node9";
            treeNode58.Text = "Tài khoản chính";
            treeNode59.Name = "Node18";
            treeNode59.Text = "Tiền gửi tiền mặt";
            treeNode60.Name = "Node1";
            treeNode60.Text = "Rút tiền mặt";
            treeNode61.Name = "Node0";
            treeNode61.Text = "Danh sách giao dịch";
            treeNode62.Name = "Node16";
            treeNode62.Text = "Giao dịch khách hàng";
            treeNode63.Name = "Node7";
            treeNode63.Text = "Giao dịch tài khoản";
            treeNode64.Name = "Node6";
            treeNode64.Text = "Tài khoản hiện tại và không kỳ hạn";
            treeNode65.Name = "Node3";
            treeNode65.Text = "Mở";
            treeNode66.Name = "Node0";
            treeNode66.Text = "Danh sách tài khoản tiết kiệm";
            treeNode67.Name = "Node2";
            treeNode67.Text = "Tài khoản tiết kiệm";
            treeNode68.Name = "Node1";
            treeNode68.Text = "Quản lý tài khoản";
            this.tvShow.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode55,
            treeNode68});
            this.tvShow.Size = new System.Drawing.Size(272, 499);
            this.tvShow.TabIndex = 0;
            this.tvShow.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvShow_AfterSelect);
            // 
            // pn_Body
            // 
            this.pn_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_Body.AutoScroll = true;
            this.pn_Body.Location = new System.Drawing.Point(278, 238);
            this.pn_Body.Name = "pn_Body";
            this.pn_Body.Size = new System.Drawing.Size(865, 480);
            this.pn_Body.TabIndex = 7;
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
            this.pnBtn.Location = new System.Drawing.Point(278, 173);
            this.pnBtn.Name = "pnBtn";
            this.pnBtn.Size = new System.Drawing.Size(867, 59);
            this.pnBtn.TabIndex = 6;
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
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
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
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
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
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(21, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 45);
            this.btnSave.TabIndex = 0;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 718);
            this.Controls.Add(this.pn_Body);
            this.Controls.Add(this.pnBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frm_Main";
            this.Text = "frm_Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tvShow;
        private System.Windows.Forms.Panel pn_Body;
        private System.Windows.Forms.Panel pnBtn;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnSearchList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}