using BLL;
using DAL;
using DTO;
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
using System.Drawing;
using System.IO;

namespace DoAnPTUD
{
    public partial class HomeUser : Form
    { 
        public static DTO_TaiKhoan user;
        
        public BLL_ThongTinKH bll_ThongTinKH = new BLL_ThongTinKH();
        public HomeUser()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           Loadata();
        }

        private void Loadata()
        {

            
            user = new DTO_TaiKhoan(70000123456, 1, "Checking", "Standard", "VND", "Primary Account", "Main", "NV001", "PM001", "123");
            
            DTO_ThongTinKH th =bll_ThongTinKH.timUserTheostk(user.IdTaiKhoan);


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

                txtTenNguoiDung.Text = th.TenKhachHang;
            
          

        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebar.Visible = !sidebar.Visible;
        }

     

        

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Visible= !textBox1.Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeUser user = new HomeUser();
            if (user.Visible != true)
            {
                user.Show();
                user.Visible = false;
            }
           user.Hide();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
          
                ManagementCard managementCard = new ManagementCard();
                managementCard.Show();
                this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            member.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
            this.Hide();
        }

        private void btnNapDT_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            deposit.Show();
            this.Hide();    
        }

        private void btnMaQR_Click(object sender, EventArgs e)
        {
            // Tạo một form mới
            Form form = new CustomDialogQR("https://api.qrserver.com/v1/create-qr-code/?size=150x150&data=PhongPhu");
            form.StartPosition = FormStartPosition.CenterParent;
            // Hiển thị form
            form.ShowDialog();

        }

        private void btnTienIch_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.exness.com/vi/");
        }

        private void btnChuyenKhoan_Click(object sender, EventArgs e)
        {
            Transfer transfer = new Transfer(); 
            transfer.Show();
            this.Hide();
        }

        private void linkHoSo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonInfor personInfor = new PersonInfor();
            personInfor.Show();
            this.Hide();
        }
    }
}
