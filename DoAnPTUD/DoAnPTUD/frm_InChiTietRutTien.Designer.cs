namespace DoAnPTUD
{
    partial class frm_InChiTietRutTien
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
            this.rptRutTien = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptRutTien
            // 
            this.rptRutTien.ActiveViewIndex = -1;
            this.rptRutTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptRutTien.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptRutTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptRutTien.Location = new System.Drawing.Point(0, 0);
            this.rptRutTien.Name = "rptRutTien";
            this.rptRutTien.Size = new System.Drawing.Size(800, 450);
            this.rptRutTien.TabIndex = 0;
            // 
            // frm_InChiTietRutTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptRutTien);
            this.Name = "frm_InChiTietRutTien";
            this.Text = "frm_RutTien";
            this.Load += new System.EventHandler(this.frm_InChiTietRutTien_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptRutTien;
    }
}