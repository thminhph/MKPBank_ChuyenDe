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
    public partial class HomeUser : Form
    {
        public HomeUser()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
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
    }
}
