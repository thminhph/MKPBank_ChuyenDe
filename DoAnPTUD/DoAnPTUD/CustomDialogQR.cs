using BLL;
using DTO;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPTUD
{
    public partial class CustomDialogQR : Form
    {

        public DTO_TaiKhoan user;
        public BLL_TaiKhoan Tk = new BLL_TaiKhoan();
        public CustomDialogQR(DTO_TaiKhoan user)
        {
            InitializeComponent();

            this.user = user;
        }

        private void CustomDialogQR_Load(object sender, EventArgs e)
        {
            // Tải hình ảnh từ URL
            try
            {
                DTO_ThongTinKH th = Tk.tim(user.IdTaiKhoan.ToString());
                string data = "Tên :" + th.TenKhachHang + "\n STk :" + user.IdTaiKhoan + "\n SĐT :" + th.SoDienThoai + "\n Email :" + th.Email;
                QRCodeGenerator qr = new QRCodeGenerator();
                QRCodeData qrdata = qr.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
                QRCode qRCode = new QRCode(qrdata);
                Bitmap qrImage = qRCode.GetGraphic(50);
                picQRCode.Image = qrImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
            }
        }

        private void picQRCode_Click(object sender, EventArgs e)
        {

        }
    }
}
