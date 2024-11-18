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
using System.Drawing.Imaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.UI;



namespace DoAnPTUD
{
    public partial class HomeUser : Form
    { 
        public  DTO_TaiKhoan  use ;
       public DTO_ThongTinKH th;
        public BLL_TaiKhoan Tk = new BLL_TaiKhoan();
        public BLL_ThongTinKH bll_ThongTinKH = new BLL_ThongTinKH();

        public HomeUser(DTO_TaiKhoan use,DTO_ThongTinKH b)
        {
            InitializeComponent();
            this.use =use ;
            this.th = b ;
          
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {

            Loadata();
        }

        private void Loadata()
        {
            if (use != null) {
                 th = Tk.tim(use.IdTaiKhoan.ToString());
                if (th.Avarta != null && th.Avarta.Length>0)
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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeUser user = new HomeUser(use, th);
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
            managementCard.WindowState = FormWindowState.Maximized;
           managementCard.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(managementCard);    
            panel2.Tag=managementCard;
            managementCard.BringToFront();
            managementCard.Show();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("chức năng hiện đang bảo trì và năng cấp xin vui lòng quay lại sau");
            //Member member = new Member();
            //member.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(use, th);
            settings.WindowState = FormWindowState.Minimized;
            settings.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(settings);
            panel2.Tag = settings;
            settings.BringToFront();
            settings.Show();
     
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
            this.Hide();
        }

        private void btnNapDT_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("chức năng hiện đang bảo trì và năng cấp xin vui lòng quay lại sau");
            Deposit deposit = new Deposit(use);
            deposit.WindowState  = FormWindowState.Maximized;
            deposit.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(deposit);
            panel2.Tag = deposit;
            deposit.BringToFront();
            deposit.Show();
            
        }

        private void btnMaQR_Click(object sender, EventArgs e)
        {
            // Tạo một form mới
            CustomDialogQR form = new CustomDialogQR(use);
            form.StartPosition= FormStartPosition.CenterParent;
            form.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add( form);
            panel2.Tag = form;
            form.BringToFront();
            // Hiển thị form
          
            //// Tạo một form mới
            //Form form = new CustomDialogQR(use);
            //form.StartPosition = FormStartPosition.CenterParent;
            //// Hiển thị form
            form.Show();

        }

        private void btnTienIch_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.exness.com/vi/");
        }

        private void btnChuyenKhoan_Click(object sender, EventArgs e)
        {
            Transfer transfer = new Transfer(use,th);
            transfer.WindowState = FormWindowState.Maximized;   
            transfer.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(transfer);
            panel2.Tag = transfer;
            transfer.BringToFront();
            transfer.Show();
         
        }

        private void linkHoSo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonInfor personInfor = new PersonInfor(use,th);
            personInfor.WindowState = FormWindowState.Maximized;
            personInfor.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(personInfor);
            panel2.Tag = personInfor;
            personInfor.BringToFront();
            personInfor.Show();
          
        }

        private void btnSaoKe_Click(object sender, EventArgs e)
        {
            frm_SaoKeTienVao SaoKeTV = new frm_SaoKeTienVao(use);
            SaoKeTV.ShowDialog();
        }
    }
}
