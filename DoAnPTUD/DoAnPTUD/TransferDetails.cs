using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace DoAnPTUD
{
    public partial class TransferDetails : Form
    {
        public DTO_TaiKhoan use;
        
        public BLL_TaiKhoan Tk = new BLL_TaiKhoan();
        public BLL_ChiTietGiaoDich giaoDich = new BLL_ChiTietGiaoDich();
        private QLNganHangDataContext db;
        public TransferDetails(DTO_TaiKhoan us, DTO_ChiTietGiaoDich chitiet)
        {
            InitializeComponent();
            this.use = us;
          
            lbTenNguoiChuyen.Text = giaoDich.tim(chitiet.SoTKNguoiChuyen1.ToString()).TenKhachHang;
            lbTenNguoiNhan.Text = giaoDich.tim(chitiet.SoTKNguoiNhan1.ToString()).TenKhachHang;
            lbSTK.Text = chitiet.SoTKNguoiNhan1.ToString("D10");
            lbSoTien.Text = chitiet.SoTien1.ToString();
            lbNgayGio.Text = chitiet.NgayGio1.ToString();
            lbMaGiaoDich.Text = giaoDich.timMaGD(DateTime.Parse(chitiet.NgayGio1.ToString("yyyy-MM-dd HH:mm:ss.000"))).ToString();
            lbDienGia.Text = chitiet.DienGia1;

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

        private void TransferDetails_Load(object sender, EventArgs e)
        {


        }

        private void lbMaGiaoDich_Click(object sender, EventArgs e)
        {

        }
    }
}
