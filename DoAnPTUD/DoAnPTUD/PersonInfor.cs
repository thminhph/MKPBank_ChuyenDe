using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPTUD
{
    public partial class PersonInfor : Form
    {
        public DTO_TaiKhoan use;
        public BLL_TaiKhoan Tk = new BLL_TaiKhoan();
        public BLL_ThongTinKH bll_ThongTinKH = new BLL_ThongTinKH();
        

        public PersonInfor( DTO_TaiKhoan us)
        {
            InitializeComponent();
            this.use = us;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebar.Visible = !sidebar.Visible;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeUser homeUser = new HomeUser(use);
            homeUser.Show();
            this.Hide();
        }

    
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            member.Show();
            this.Hide();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            ManagementCard mc = new ManagementCard(use);
            mc.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();    
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
            this.Hide();
        }

        private void PersonInfor_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData() {
           
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
            textBox1.Text = th.TenKhachHang;
            txtHoTen.Text = th.TenKhachHang;
            txtCCCD.Text = th.SoGiayTo;
            txtDiaChi.Text = th.DiaChi;
            txtEmail.Text = th.Email;
            txtSDT.Text=th.SoDienThoai;
            txtNgayCap.Text=th.NgayCap.ToString();
            txtNgaysinh.Text=th.NgaySinh.ToString();
            txtGioiTinh.Text= "Nam";



        
    }

    }
}
