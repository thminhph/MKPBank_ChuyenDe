using BLL;
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
        public static DTO_TaiKhoan user;
        public DTO_SoDuTk sd;
        public BLL_SoDuTk sdtk = new BLL_SoDuTk(); 
        public BLL_ThongTinKH bll_ThongTinKH = new BLL_ThongTinKH();
        public ManagementCard()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {

            if (btnXem.ImageIndex == 7)
            {
                btnXem.ImageIndex = 8;
                lbTien.Text = "   *******   ";
            }
            else {
                btnXem.ImageIndex = 7;
                //thay bảng dữ liệu database
                lbTien.Text=sd.SoDuTK1.ToString(); 
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebar.Visible = !sidebar.Visible;
        }

        private void btnTrangChinh_Click(object sender, EventArgs e)
        {
            HomeUser user = new HomeUser();
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
            history.Show();
            this.Hide();
        }
        public void LoatData()
        {
            user = new DTO_TaiKhoan(70000123456, 1, "Checking", "Standard", "VND", "Primary Account", "Main", "NV001", "PM001", "123");

            DTO_ThongTinKH th = bll_ThongTinKH.timUserTheostk(user.IdTaiKhoan);
            

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
             sd = sdtk.sodu(user.IdTaiKhoan);
            if (sd != null)
            {
                lbTien.Text = sd.SoDuTK1.ToString();
            }
        }

        private void ManagementCard_Load(object sender, EventArgs e)
        {
            
            LoatData();
        }
    }
}
