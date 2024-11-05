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
        public string use;
        public DTO_SoDuTk sd;
        public BLL_SoDuTk sdtk = new BLL_SoDuTk();
       public BLL_ChiTietGiaoDich giaoDich=new BLL_ChiTietGiaoDich();
        public DTO_ChiTietGiaoDich dich;
        public Transfer(string us)
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
                lbTien.Text = sd.SoDuTK1.ToString("N");
            }
        }
        public void loaddata()
        {
            sd = sdtk.sodu(use);
            if (sd != null)
            {
                lbTien.Text = sd.SoDuTK1.ToString("N");
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
            if (giaoDich.tim(textBox1.Text) != string.Empty)
            {
                txtSoTK.Text = giaoDich.tim(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Thông báo", "Số tài khoản không tồn tại vui lòng nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox1.Clear();
                textBox1.Focus();
            }
           
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(giaoDich.giaoDich(use, textBox1.Text, float.Parse(txtSoTien.Text), rictxtDienGia.Text) == true)
            {
               TransferDetails transfer=new TransferDetails(use);
                MessageBox.Show("Thông báo ", "Giao Dịch Thành Công");
                transfer.Show();
                this.Hide(); 
            }
            else
            {
                if(MessageBox.Show("Thông báo","số dư không đủ hoặc thẻ bị khóa vui lòng kiểm tra lại", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK){
                    textBox1.Clear();
                    txtSoTien.Clear();
                    rictxtDienGia.Clear();
                    textBox1.Focus();
                }
            }
            
        }
    }
}
