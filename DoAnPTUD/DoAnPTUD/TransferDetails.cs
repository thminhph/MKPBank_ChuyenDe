using BLL;
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
    public partial class TransferDetails : Form
    {
        public DTO_TaiKhoan use;
        public BLL_TaiKhoan Tk = new BLL_TaiKhoan();
        
        public TransferDetails(DTO_TaiKhoan us, DTO_ChiTietGiaoDich chitiet)
        {
            InitializeComponent();
            this.use = us;
            lbTenNguoiChuyen.Text= chitiet.SoTKNguoiChuyen1.ToString();
            lbTenNguoiNhan.Text = chitiet.SoTKNguoiNhan1.ToString();
            lbSTK.Text = chitiet.SoTKNguoiNhan1.ToString() ;
            lbSoTien.Text = chitiet.SoTien1.ToString();
            lbNgayGio.Text = chitiet.NgayGio1.ToString();
            lbMaGiaoDich.Text = chitiet.MaGD1.ToString();
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
    }
}
