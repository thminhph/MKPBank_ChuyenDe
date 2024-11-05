using BLL;
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
    public partial class TransferDetails : Form
    {
        public string use;
        public BLL_TaiKhoan Tk = new BLL_TaiKhoan();
        public TransferDetails( string us)
        {
            InitializeComponent();
            this.use = us;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            HomeUser homeUser = new HomeUser(use);
            homeUser.Show();
            this.Hide();

        }

        private void btnThemGiaoDich_Click(object sender, EventArgs e)
        {
            Transfer transfer = new Transfer(use);
            transfer.Show();
            this.Hide();
        }
       
    }
}
