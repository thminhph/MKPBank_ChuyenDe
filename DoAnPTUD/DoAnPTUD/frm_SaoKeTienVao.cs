using BLL;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using DTO;
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
    public partial class frm_SaoKeTienVao : Form
    {
        DTO_TaiKhoan  id;
        public frm_SaoKeTienVao(DTO_TaiKhoan ids)
        {
            InitializeComponent();
            this.id = ids;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            crpSaoKeTienVao crpTienVao = new crpSaoKeTienVao();
            BLL_ChiTietGiaoDich bllGD = new BLL_ChiTietGiaoDich();
            crpTienVao.SetDataSource(bllGD.SaoKeTienVao(id.IdTaiKhoan,dtpTuNgay.Value,dtpDenNgay.Value));
            crpTienVao.SetParameterValue(0, dtpTuNgay.Value);
            crpTienVao.SetParameterValue(1, dtpDenNgay.Value);
            crpSaoKeTV.ReportSource = crpTienVao;


        }

        private void frm_SaoKeTienVao_Load(object sender, EventArgs e)
        {

        }
    }
}
