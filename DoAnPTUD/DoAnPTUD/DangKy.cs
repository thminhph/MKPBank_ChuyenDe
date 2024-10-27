using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD

=======
>>>>>>> Minh
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

<<<<<<< HEAD
        private async void btnSendOTP_Click(object sender, EventArgs e)
        {
            //string accountSid = "AC7fe66962094830ea138aa465da97de14";
            //string authToken = "c68130a094a0106c3723a5a0768ae806";
            //string fromNumber = "+16612207030";
            //string toNumber = txtSoDienThoai.Text;

            //Random random = new Random();
            //int randomNumber = random.Next(100000, 999999);
            //string message = MESS_REGISTER + randomNumber.ToString();

            //TwilioClient.Init(accountSid, authToken);


            //var messageOptions = new CreateMessageOptions(
            //      new PhoneNumber(toNumber));
            //messageOptions.From = new PhoneNumber(fromNumber);
            //messageOptions.Body = "test";
            //try
            //{
            //    var sendMessage = MessageResource.Create(messageOptions);
            //    MessageBox.Show("Message sent successfully!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex) {
            //    MessageBox.Show("Message sent fail!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}


        }
=======
        
>>>>>>> Minh

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
