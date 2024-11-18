using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPTUD
{
    public partial class frm_InChiTietGuiTien : Form
    {
        string id;
        public frm_InChiTietGuiTien(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frm_InChiTietGuiTien_Load(object sender, EventArgs e)
        {
            BLL_LoadValue load = new BLL_LoadValue();
            crpNopTien nt = new crpNopTien();
            nt.SetDataSource(load.InPhieuNopTien(id));
            crystalReportViewer1.ReportSource = nt;
        }
    }
}
