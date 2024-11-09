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
        public Settings()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau();
            doiMatKhau.Show();
            this.Hide();
        }

        private void btnCapNhatTT_Click(object sender, EventArgs e)
        {
            CapNhatThongTin capNhatThongTin = new CapNhatThongTin();
            capNhatThongTin.Show();
            this.Hide();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            HomeUser homeUser = new HomeUser();
            homeUser.Show();
            this.Hide();
        }
    }
}
