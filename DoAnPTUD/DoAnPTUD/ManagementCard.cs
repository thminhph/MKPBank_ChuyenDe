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
    public partial class ManagementCard : Form
    {
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
                lbTien.Text="100,000,000"; 
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
    }
}
