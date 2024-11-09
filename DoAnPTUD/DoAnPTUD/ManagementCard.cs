using BLL;
using DoAnPTUD.Properties;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPTUD
{
    public partial class ManagementCard : Form
    {
        int  pos = 1;
        public string use;
        public DTO_TaiKhoan use;
        public BLL_TaiKhoan Tk = new BLL_TaiKhoan();
        public DTO_SoDuTk sd;
        public DTO_TaiKhoan st;
        public BLL_SoDuTk sdtk = new BLL_SoDuTk(); 
        public BLL_ThongTinKH bll_ThongTinKH = new BLL_ThongTinKH();
        public ManagementCard(string us)
        public ManagementCard(DTO_TaiKhoan us)
        {
            InitializeComponent();
            this.use = us;
            
        }

        private void btnXem_Click(object sender, EventArgs e)
        {

            if (btnXem.ImageIndex == 7)
            {
                btnXem.ImageIndex = 8;
                lbTien.Text = "*******";
            }
            else {
                btnXem.ImageIndex = 7;
                //thay bảng dữ liệu database
                lbTien.Text=sd.SoDuTK1.ToString()+"VNĐ"; 
                lbTien.Text=sd.SoDuTK1.ToString("N")+"VNĐ"; 
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebar.Visible = !sidebar.Visible;
        }

        private void btnTrangChinh_Click(object sender, EventArgs e)
        {
            HomeUser user = new HomeUser(use);
                user.Show();   
                this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Member member = new Member();   
            member.Show();
            this.Hide();
           
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thông Báo", "Bạn đang ở trang này");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
            this.Hide();
        }

        private void btnGiaoDich_Click(object sender, EventArgs e)
        {
            TransactionHistory history = new TransactionHistory();  
            TransactionHistory history = new TransactionHistory(use);  
            history.Show();
            this.Hide();
        }
        public void LoatData()
        {
           
            DTO_ThongTinKH th = Tk.tim(use);
            DTO_ThongTinKH th = Tk.tim(use.IdTaiKhoan.ToString());
            if (th != null) {
                if (picAvatar.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream(th.Avarta))
                    {
                        // Sử dụng phương thức FromStream của lớp Image để tạo một đối tượng hình ảnh từ MemoryStream
                        Image image = Image.FromStream(ms);

                        // Đặt hình ảnh vào pictureBox1
                        picAvatar.Image = image;
                    }

                }
                else
                {
                    picAvatar.Image = null;
                }
                lblTenNgDung.Text = th.TenKhachHang;
                sd = sdtk.sodu(use);
                sd = sdtk.sodu(use.IdTaiKhoan.ToString());
                if (sd != null)
                {
                    lbTien.Text = sd.SoDuTK1.ToString("N");
                }
               
            }
        }

        private void ManagementCard_Load(object sender, EventArgs e)
        {
            
            LoatData();
        }

        private void linkHoSo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonInfor personInfor = new PersonInfor(use);
            personInfor.Show();
            this.Hide();
        }

        private void picAvatar_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            
        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            Bitmap the = new Bitmap(Resources.thenganhang);
            Bitmap tiet = new Bitmap(Resources.tietkiem);
            List<Bitmap> list = new List<Bitmap>();
            list.Add(the);
            list.Add(tiet);    
                if (pos >= list.Count-1)

                {
                pictureBox1.Image = list[pos++];
                pos = 0;
                }
                else
                {
                    pictureBox1.Image = list[pos++];

                }



        }

        private void btnChuyen_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
