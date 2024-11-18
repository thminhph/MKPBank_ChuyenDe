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
        public DTO_ThongTinKH ttkh;

        public PersonInfor(DTO_TaiKhoan us, DTO_ThongTinKH ttkh)
        {
            InitializeComponent();
            this.use = us;
            this.ttkh = ttkh;
        }

      
        private void PersonInfor_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData() {
           
            DTO_ThongTinKH th = Tk.tim(use.IdTaiKhoan.ToString());
            if (th.Avarta != null && th.Avarta.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(th.Avarta))
                {
                    // Sử dụng phương thức FromStream của lớp Image để tạo một đối tượng hình ảnh từ MemoryStream
                    Image image = Image.FromStream(ms);
                    // Đặt hình ảnh vào pictureBox1
                    picAvata1.Image = image;
                }
            }
            else
            {
                picAvata1.Image = null;
            }
          
            txtHoTen.Text = th.TenKhachHang;
            txtCCCD.Text = th.SoGiayTo;
            txtDiaChi.Text = th.DiaChi;
            txtEmail.Text = th.Email;
            txtSDT.Text=th.SoDienThoai;
            txtNgayCap.Text=th.NgayCap.ToString("dd-MM--yyyy");
            txtNgaysinh.Text=th.NgaySinh.ToString("dd-MM--yyyy");
            txtGioiTinh.Text= "Nam";
    }

        private void picAvata1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
            picAvata1.Size = new  Size(200,200);
            //picAvata1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         
        }
    }
}
