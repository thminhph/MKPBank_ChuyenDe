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
       public  DTO_ThongTinKH a;
        public DTO_SoDuTk sd;
        public BLL_SoDuTk sdtk = new BLL_SoDuTk();
        public BLL_ChiTietGiaoDich giaoDich = new BLL_ChiTietGiaoDich();
        public DTO_ChiTietGiaoDich dich;
        public Transfer(DTO_TaiKhoan us,DTO_ThongTinKH th)
        {
            InitializeComponent();
            this.use = us;
            this.a = th;
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
                sd = sdtk.sodu(use.IdTaiKhoan.ToString());
                if (sd != null)
                {
                    lbTien.Text = sd.SoDuTK1.ToString("N");
                }
                else
                {
                    lbTien.Text = "0";
                }

            }
        }
        public void loaddata()
        {
            sd = sdtk.sodu(use.IdTaiKhoan.ToString());
            if (sd != null)
            {
                lbTien.Text = sd.SoDuTK1.ToString("N");
            }
            else
            {
                lbTien.Text = "0";
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
            if (textBox1.Text != string.Empty && textBox1.Text != use.IdTaiKhoan.ToString() && textBox1.Text !=a.SoDienThoai  )
            {
                a = giaoDich.tim(textBox1.Text);
                if (a != null)
                    txtSoTK.Text = a.TenKhachHang;
                else
                {
                    txtSoTK.Text = giaoDich.timsdt(textBox1.Text);
                }
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
            if (textBox1 == null)
            {
                MessageBox.Show("Vui lòng nhập số tài khoản!", "Thông báo");
            }
            else
            {
                if (a != null)
                {
                    if (giaoDich.giaoDich(use.IdTaiKhoan.ToString(), textBox1.Text, float.Parse(txtSoTien.Text), rictxtDienGia.Text) == true)
                    {

                        DTO_ChiTietGiaoDich ich = new DTO_ChiTietGiaoDich(use.IdTaiKhoan, long.Parse(textBox1.Text), float.Parse(txtSoTien.Text), DateTime.Now, rictxtDienGia.Text);
                        TransferDetails transfer = new TransferDetails(use, ich);
                        if (MessageBox.Show("Giao Dịch Thành Công, ok để xem chi tiết giao dịch", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
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

                }
                else
                {
                    if (giaoDich.giaoDichsdt(use.IdTaiKhoan.ToString(), textBox1.Text, float.Parse(txtSoTien.Text), rictxtDienGia.Text) == true)
                    {

                        DTO_ChiTietGiaoDich ich = new DTO_ChiTietGiaoDich(use.IdTaiKhoan, long.Parse(textBox1.Text), float.Parse(txtSoTien.Text), DateTime.Now, rictxtDienGia.Text);
                        TransferDetails transfer = new TransferDetails(use, ich);
                        if (MessageBox.Show("Giao Dịch Thành Công, ok để xem chi tiết giao dịch", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
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
                        if (MessageBox.Show("số dư không đủ vui lòng kiểm tra lại hoặc bạn có muốn trở về trang chủ không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            HomeUser home = new HomeUser(use,a);
                            home.Show();
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
                }

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

