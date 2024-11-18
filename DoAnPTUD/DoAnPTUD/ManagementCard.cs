using BLL;
using DoAnPTUD.Properties;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace DoAnPTUD
{
    public partial class ManagementCard : Form
    {
        int pos = 1;
        public DTO_TaiKhoan use;
        public BLL_TaiKhoan Tk = new BLL_TaiKhoan();
        public DTO_SoDuTk sd;
        public DTO_TaiKhoan st;
        public DTO_ThongTinKH kh;
        public BLL_SoDuTk sdtk = new BLL_SoDuTk();
        public BLL_ThongTinKH bll_ThongTinKH = new BLL_ThongTinKH();
        public ManagementCard(DTO_TaiKhoan us)
        {
            InitializeComponent();
            this.use = us;
            
        }

        private void btnXem_Click(object sender, EventArgs e)
        {

            if (btnXem.ImageIndex == 7)
            {
                btnXem.ImageIndex = 8;
                lbTien.Text = "*******";
            }
            else {
                btnXem.ImageIndex = 7;
                //thay bảng dữ liệu database
                sd = sdtk.sodu(use.IdTaiKhoan.ToString());
                if (sd != null)
                {
                    lbTien.Text = sd.SoDuTK1.ToString("N") + use.TienTe.ToString();
                }
                else
                {
                    lbTien.Text = "0";
                }

            }
        }
     
        private void btnGiaoDich_Click(object sender, EventArgs e)
        {
            TransactionHistory history = new TransactionHistory(use,kh);
            history.WindowState = FormWindowState.Maximized;
            history.TopLevel = false;
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.Controls.Add(history);
            tableLayoutPanel1.Tag = history;
            history.BringToFront();
            history.Show();
        }
        public void LoatData()
        {
     
                sd = sdtk.sodu(use.IdTaiKhoan.ToString());
                if (sd != null)
                {
                    lbTien.Text = sd.SoDuTK1.ToString("N") + use.TienTe.ToString();
                }
                else
                {
                    lbTien.Text = "0";
                }
        
        }

        private void ManagementCard_Load(object sender, EventArgs e)
        {
            
            LoatData();
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            Bitmap the = new Bitmap(Resources.thenganhang);
            Bitmap tiet = new Bitmap(Resources.tietkiem);
            List<Bitmap> list = new List<Bitmap>();
            list.Add(the);
            list.Add(tiet);    
                if (pos >= list.Count-1)

                {
                pictureBox1.Image = list[pos++];
                pos = 0;
                }
                else
                {
                    pictureBox1.Image = list[pos++];

                }



        }

        private void btnChuyen_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
