using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPTUD
{

    public partial class Member : Form
    {
        DTO_ChiTietGiaoDich gd;
        BLL_ChiTietGiaoDich chitiet;
        public Member(DTO_ChiTietGiaoDich a)
        {
            InitializeComponent();
            this.gd = a;
            this.chitiet = new BLL_ChiTietGiaoDich();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
           
        }

      
        private void Member_Load(object sender, EventArgs e)
        {
           
            inBill inBill = new inBill();
            DataTable data = chitiet.reprot();
            inBill.SetDataSource(data);
            crystalReportViewer1.ReportSource = inBill;
        }


    }
}
