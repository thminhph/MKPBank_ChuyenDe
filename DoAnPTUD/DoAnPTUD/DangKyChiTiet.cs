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
    public partial class DangKyChiTiet : Form
    {
        public DangKyChiTiet()
        {
            InitializeComponent();
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void DangKyChiTiet_Load(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {

            //if (txtTen.Text.Trim() == "")
            //{
            //    MessageBox.Show("Vui lòng nhập Email!"); ;
            //}
            //else if (txtSoDienThoai.Text.Trim() == "")
            //{
            //    MessageBox.Show("Vui lòng nhập Số điện thoại!"); ;
            //}
            //else
            //{
            //    //DangKy.taiKhoan.Email = txtEmail.Text;
            //    //taiKhoan.SoDienThoai = txtSoDienThoai.Text;
            //    //DangKyChiTiet us = new DangKyChiTiet();
            //    //us.Show();
            //    //this.Hide();
            //}
            //HomeUser us = new HomeUser();
            //us.Show();
            //this.Hide();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            DangKy us = new DangKy();
            us.Show();
            this.Hide();
        }
    }
}
