using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DoAnPTUD
{
    public partial class DangKy : Form
    {
        private const String MESS_REGISTER="OTP MKP Bank";

        public static DTO_ThongTinKH taiKhoan = new DTO_ThongTinKH();
        

        public DangKy()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

        }

        

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Email!"); ;
            }
            else if (txtSoDienThoai.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Số điện thoại!"); ;
            }
            else
            {
                taiKhoan.Email = txtEmail.Text;
                taiKhoan.SoDienThoai =  txtSoDienThoai.Text;
                DangKyChiTiet us = new DangKyChiTiet();
                us.Show();
                this.Hide();
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            DangNhap us = new DangNhap();
            us.Show();
            this.Hide();
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
