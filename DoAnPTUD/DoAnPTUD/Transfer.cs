using BLL;
using DoAnPTUD.Properties;
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
    public partial class Transfer : Form
    {
        int pos = 1;
        public DTO_TaiKhoan use;
      
        public DTO_SoDuTk sd;
        public BLL_SoDuTk sdtk = new BLL_SoDuTk();
       public BLL_ChiTietGiaoDich giaoDich=new BLL_ChiTietGiaoDich();
        public DTO_ChiTietGiaoDich dich;
        public Transfer(DTO_TaiKhoan us)
        {
            InitializeComponent();
            this.use = us;  
        }

        private void lbTien_Click(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {

            if (btnXem.ImageIndex == 7)
            {
                btnXem.ImageIndex = 8;
                lbTien.Text = "   *******   ";
            }
            else
            {
                btnXem.ImageIndex = 7;
                //thay bảng dữ liệu database
                lbTien.Text = sd.SoDuTK1.ToString("N") + "VNĐ";
            }
        }
        public void loaddata()
        {
            sd = sdtk.sodu(use.IdTaiKhoan.ToString());
            if (sd != null)
            {
                lbTien.Text = sd.SoDuTK1.ToString("N") + "VNĐ";
            }
            textBox1.Focus();
        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            Bitmap the = new Bitmap(Resources.thenganhang);
            Bitmap tiet = new Bitmap(Resources.tietkiem);
            List<Bitmap> list = new List<Bitmap>();
            list.Add(the);
            list.Add(tiet);
            if (pos >= list.Count - 1)

            {
                pictureBox1.Image = list[pos++];
                pos = 0;
            }
            else
            {
                pictureBox1.Image = list[pos++];

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox1.Text != use.IdTaiKhoan.ToString())
            {
                txtSoTK.Text = giaoDich.tim(textBox1.Text).TenKhachHang;
            }
            else
            {
                MessageBox.Show("Số tài khoản không tồn tại hoặc đây là số tài khoản của bạn vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox1.Clear();
                textBox1.Focus();
            }
           
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (textBox1 == null) {
                MessageBox.Show("Vui lòng nhập số tài khoản!", "Thông báo");
            }
            else
            {
                if (giaoDich.giaoDich(use.IdTaiKhoan.ToString(),textBox1.Text, float.Parse(txtSoTien.Text), rictxtDienGia.Text) == true)
                {
                    DTO_ChiTietGiaoDich ich = new DTO_ChiTietGiaoDich(use.IdTaiKhoan, long.Parse(textBox1.Text), float.Parse(txtSoTien.Text),DateTime.Now, rictxtDienGia.Text);
                    TransferDetails transfer = new TransferDetails(use,ich);
                   if (MessageBox.Show("Giao Dịch Thành Công, ok để xem chi tiết giao dịch","Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)== DialogResult.OK){
                        transfer.Show();
                        this.Hide();
                    }
                    else
                    {
                        textBox1.Clear();
                        txtSoTien.Clear();
                        rictxtDienGia.Clear();
                        textBox1.Focus();
                    }
                   
                }

                else
                {
                    if (MessageBox.Show("Thông báo", "số dư không đủ hoặc thẻ bị khóa vui lòng kiểm tra lại", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        textBox1.Clear();
                        txtSoTien.Clear();
                        rictxtDienGia.Clear();
                        textBox1.Focus();
                    }
                }
            } 
        }
       
    }
}
