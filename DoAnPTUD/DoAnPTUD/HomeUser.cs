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

        public void Loadata()
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
            user.Show();
            this.Close();
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
            deposit.StartPosition = FormStartPosition.CenterScreen;
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
            form.StartPosition= FormStartPosition.CenterScreen;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None; 
            form.Dock = DockStyle.None; 
            int x = (panel2.Width - form.Width) / 2;
            int y = (panel2.Height - form.Height) / 2;
            form.Location = new Point(x, y);
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
            SaoKeTV.WindowState = FormWindowState.Maximized;
            SaoKeTV.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(SaoKeTV);
            panel2.Tag = SaoKeTV;
            SaoKeTV.BringToFront();
            SaoKeTV.Show();
           
        }

        private void càiĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau(use);
            doiMatKhau.WindowState = FormWindowState.Maximized;
            doiMatKhau.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(doiMatKhau);
            panel2.Tag = doiMatKhau;
            doiMatKhau.BringToFront();
            doiMatKhau.Show();
        }

        private void cậpNhậtThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatThongTin capNhatThongTin = new CapNhatThongTin(use,th);
            capNhatThongTin.WindowState = FormWindowState.Maximized;
            capNhatThongTin.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(capNhatThongTin);
            panel2.Tag = capNhatThongTin;
            capNhatThongTin.BringToFront();
            capNhatThongTin.Show();
        }

        private void picAvatar_Click(object sender, EventArgs e)
        {

        }
    }
}
