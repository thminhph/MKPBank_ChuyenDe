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
    public partial class frm_DanhSachKhachHang : Form
    {
        public frm_DanhSachKhachHang()
        {
            InitializeComponent();
        }
        private void frm_DanhSachKhachHang_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] arr =
            {
                txtMaKH.Text,
                cbLoaiKh.Text,
                txtSDT.Text,
                txtTen.Text,
                txtSGT.Text,
                cbNganhChinh.Text,
                cbNganh.Text
            };
            BLL_LoadValue kh = new BLL_LoadValue();
            dgvKhachHang.DataSource = kh.InDSKhachHang(arr);
        }
    }
}
