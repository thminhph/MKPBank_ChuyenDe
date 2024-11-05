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
<<<<<<< HEAD

using BLL;

=======
>>>>>>> Kiet4
using BLL;

namespace DoAnPTUD
{
    public partial class DangNhap : Form
    {
        public static DTO_TaiKhoan user;
        
        private  BLL_TaiKhoan bll_taiKhoan  = new BLL_TaiKhoan();
        public DangNhap()
        {
            InitializeComponent();
        }

 

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        
        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string txtDN = txtDangNhap.Text;
            string txtMK = txtMatKhau.Text;
            if (txtDN.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!"); ;
            }
            else if (txtMK.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!"); ;
            }


<<<<<<< HEAD
            if (bll_taiKhoan.dangNhap(txtDangNhap.Text, txtMatKhau.Text) )
            {
                DTO_ThongTinKH use= bll_taiKhoan.ganthongtin(txtDN, txtMK);
                HomeUser us = new HomeUser(use.SoDienThoai);
                us.Show();
=======
            if (txtDangNhap.Text == "admin" && txtMatKhau.Text == "123")
            {
                frm_Main frm_Main = new frm_Main();
                frm_Main.Show();
>>>>>>> Kiet4
                this.Hide();
            }
            else
            {
<<<<<<< HEAD
                MessageBox.Show("Tai khoan khong ton tai!");
            }
=======
                if (bll_taiKhoan.dangNhap(txtDangNhap.Text, txtMatKhau.Text))
                {
                    DTO_ThongTinKH use = bll_taiKhoan.ganthongtin(txtDN, txtMK);
                    HomeUser us = new HomeUser(use.SoDienThoai);
                    us.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tai khoan khong ton tai!");
                }
            }
         }
           
>>>>>>> Kiet4
            //HomeUser.user = 
            //HomeUser  us=new HomeUser();
            //us.Show();
            //this.Hide();
<<<<<<< HEAD
        }
=======
        
>>>>>>> Kiet4

        private void txtDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void lkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy us = new DangKy();
            us.Show();
            this.Hide();
        }
    }
}
