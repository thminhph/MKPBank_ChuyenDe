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
        private String imagePath;
        public CustomDialogQR(string imagePath)
        {
            InitializeComponent();
            this.imagePath = imagePath;
        }

        private void CustomDialogQR_Load(object sender, EventArgs e)
        {
            // Tải hình ảnh từ URL
            try
            {
                using (WebClient client = new WebClient())
                {
                    byte[] imageData = client.DownloadData(imagePath);
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        picQRCode.Image = Image.FromStream(ms);
                    }
                }
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
