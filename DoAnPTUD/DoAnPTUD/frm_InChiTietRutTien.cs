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
    public partial class frm_InChiTietRutTien : Form
    {
        string maRutTien;
        public frm_InChiTietRutTien(string maRutTien)
        {
            InitializeComponent();
            this.maRutTien = maRutTien;
        }

        private void frm_InChiTietRutTien_Load(object sender, EventArgs e)
        {
            BLL_LoadValue load = new BLL_LoadValue();
            crpRutTien nt = new crpRutTien();
            nt.SetDataSource(load.InPhieuNopTien(maRutTien));
            rptRutTien.ReportSource = nt;
        }
    }
}
