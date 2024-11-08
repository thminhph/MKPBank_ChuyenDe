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

        public static DTO_ThongTinKH taiKhoan = new DTO_ThongTinKH();


        private bool IsPasswordMatch(string password, string confirmPassword)
        { 
            // Kiểm tra xem mật khẩu có trùng khớp
                 return password == confirmPassword;
         }
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
        //private bool check10so (string phoneNumber)
        //{
        //    return phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit);
        //}
        private bool ConfirmPass(string password, string confirmPassword)
        { // Kiểm tra xem mật khẩu có trùng khớp
          return password == confirmPassword; 
        }
            private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string password = txtMatKhau.Text;
            string confirmPassword = txtNhapLaiMK.Text;



            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Email!"); ;
            }
            else if (txtSoDienThoai.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Số điện thoại!"); ;
            }
            else if (txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!"); ;
            }
            else if (txtNhapLaiMK.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không trùng khớp!"); ;
            }
            else if (!IsPasswordMatch(password,confirmPassword))
            {
                errorProvider1.SetError(txtNhapLaiMK, "Mật khẩu không trùng khớp.");
            }
            else
            {
                errorProvider1.SetError(txtNhapLaiMK, string.Empty); // Không có lỗi
                MessageBox.Show("Mật khẩu trùng khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string phoneNumber = txtSoDienThoai.Text;
            if (phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit))
            { errorProvider1.SetError(txtSoDienThoai, string.Empty); }
            else { errorProvider1.SetError(txtSoDienThoai, "Số điện thoại phải có 10 số."); }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (email.EndsWith("@gmail.com"))
            {
                errorProvider1.SetError(txtEmail, string.Empty);
            }
            else
            {
                errorProvider1.SetError(txtEmail, "Email phải có đuôi '@gmail.com'.");
            }
                
        }
        private void txtNhapLaiMK_TextChanged(object sender, EventArgs e)
        {
            string password = txtMatKhau.Text; 
            string confirmPassword = txtNhapLaiMK.Text;
            txtNhapLaiMK.PasswordChar = '*';
            if (IsPasswordMatch(password, confirmPassword)) 
            { 
                errorProvider1.SetError(txtNhapLaiMK, string.Empty); 
            } else 
            { 
                errorProvider1.SetError(txtNhapLaiMK, "Mật khẩu không trùng khớp."); 
            }
        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            
        }

        private bool IsPasswordValid(string password)
        { // Kiểm tra xem mật khẩu có chứa ít nhất một chữ in hoa, một số và một ký tự đặc biệt
            bool hasUpperCase = password.Any(char.IsUpper);
            bool hasDigit = password.Any(char.IsDigit);
            bool hasSpecialChar = password.Any(ch => !char.IsLetterOrDigit(ch));
            return hasUpperCase && hasDigit && hasSpecialChar;
           }

            private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            string password = txtMatKhau.Text;
            txtMatKhau.PasswordChar = '*';
            if (IsPasswordValid(password)) 
            {
                errorProvider1.SetError(txtMatKhau, string.Empty); 
            }
            else {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu phải chứa ít nhất một chữ in hoa, một số và một ký tự đặc biệt."); 
            }
        }
    }
}
