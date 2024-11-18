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
    public partial class Settings : Form
    {
        private DTO_ThongTinKH tk;
        private DTO_TaiKhoan user;
        public Settings(DTO_TaiKhoan user,DTO_ThongTinKH tk)
        {
            InitializeComponent();
            this.tk = tk;
            this.user = user;
        }
        public Settings() { 
            InitializeComponent();
        }

        //private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        //{

        //}

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau(user);
            doiMatKhau.TopLevel = false;
            doiMatKhau.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            doiMatKhau.Dock = DockStyle.Fill;
            doiMatKhau.BringToFront();
            panel1.Controls.Add(doiMatKhau);
            doiMatKhau.Show();
        
        }

        private void btnCapNhatTT_Click(object sender, EventArgs e)
        {
            CapNhatThongTin capNhatThongTin = new CapNhatThongTin(user,tk);
            capNhatThongTin.TopLevel = false;
            capNhatThongTin.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            capNhatThongTin.Dock = DockStyle.Fill;
            capNhatThongTin.BringToFront();
            panel1.Controls.Add(capNhatThongTin);
            capNhatThongTin.Show();
            //this.Hide();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            HomeUser homeUser = new HomeUser(user,tk);
            homeUser.Show();
            this.Hide();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
