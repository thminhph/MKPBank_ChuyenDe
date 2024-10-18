using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace DoAnPTUD
{
    public partial class frmConnect : Form
    {
        public frmConnect()
        {
            InitializeComponent();
        }
        void loadform()
        {
            txbTenMayChu.Text = Environment.MachineName + @"\SQLEXPRESS";
            if (cbXacThuc.Text == "Windows authentication")
            {
                lbTen.Enabled = false;
                lbMK.Enabled = false;
                txbTenNguoiDung.Enabled = false;
                txbMatKhau.Enabled = false;
            }
            else
            {
                lbTen.Enabled = true;
                lbMK.Enabled = true;
                txbTenNguoiDung.Enabled = true;
                txbMatKhau.Enabled = true;
            }
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                Connect conn = new Connect(txbTenMayChu.Text, txbCSDL.Text);
                BUS.Context context = new BUS.Context(conn.SqlConnectionWindows());
                frmMain f = new frmMain(conn.SqlConnectionWindows());
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_Connect_Load(object sender, EventArgs e)
        {
            cbXacThuc.Text = "Windows authentication";
            loadform();
            txbCSDL.Text = "QLNganHang";
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            Connect conn = new Connect(txbTenMayChu.Text, txbCSDL.Text);
            try
            {
                BUS.Context context = new BUS.Context(conn.SqlConnectionWindowsAuthentication());
                MessageBox.Show("Kết nối thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
