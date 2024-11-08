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

namespace DoAnPTUD
{
    public partial class HomeUser : Form
    { 
        public  DTO_TaiKhoan  use ;
        public BLL_TaiKhoan Tk = new BLL_TaiKhoan();
        public BLL_ThongTinKH bll_ThongTinKH = new BLL_ThongTinKH();
        public HomeUser(DTO_TaiKhoan tk)
        {
            InitializeComponent();
            this.use =tk ;
        }
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

           
            if (use != null) {

                DTO_ThongTinKH th = Tk.tim(use.IdTaiKhoan.ToString());
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
            else
            {
                MessageBox.Show("không tồn tại");
            }
               


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
            HomeUser user = new HomeUser(use);
            if (user.Visible != true)
            {
                user.Show();
                user.Visible = false;
            }
           user.Hide();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {

            ManagementCard managementCard = new ManagementCard(use);
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
            Form form = new CustomDialogQR(use);
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
            Transfer transfer = new Transfer(use); 
            transfer.Show();
            this.Hide();
        }

        private void linkHoSo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonInfor personInfor = new PersonInfor(use);
            personInfor.Show();
            this.Hide();
        }

        
    }
}
