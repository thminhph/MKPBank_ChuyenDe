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
        public DTO_ThongTinKH kh;

        public BLL_TaiKhoan Tk = new BLL_TaiKhoan();
        public BLL_ChiTietGiaoDich giaoDich = new BLL_ChiTietGiaoDich();
        DTO_ChiTietGiaoDich chitie;
        public TransferDetails(DTO_TaiKhoan us, DTO_ChiTietGiaoDich chitiet)
        {
            InitializeComponent();
            this.use = us;
            this.chitie = chitiet;

            lbTenNguoiChuyen.Text = giaoDich.tim(chitiet.SoTKNguoiChuyen1.ToString()).TenKhachHang;
            if (giaoDich.tim(chitiet.SoTKNguoiNhan1.ToString()) != giaoDich.tim(chitiet.SoTKNguoiNhan1.ToString()))
            {
                lbTenNguoiNhan.Text = giaoDich.tim(chitiet.SoTKNguoiNhan1.ToString()).TenKhachHang;
            }
            else
            {
                lbTenNguoiNhan.Text = giaoDich.timsdt(chitiet.SoTKNguoiNhan1.ToString("D10")).TenKhachHang;
            }

            lbSTK.Text = chitiet.SoTKNguoiNhan1.ToString("D10");
            lbSoTien.Text = chitiet.SoTien1.ToString();
            lbNgayGio.Text = chitiet.NgayGio1.ToString();
            lbMaGiaoDich.Text = giaoDich.timMaGD(DateTime.Parse(chitiet.NgayGio1.ToString("yyyy-MM-dd HH:mm:ss.000"))).ToString();
            lbDienGia.Text = chitiet.DienGia1;

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quý khách có muốn in giao dịch không ","Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Member member = new Member(chitie);
                member.Show();
            }
            else
            {
                TransferDetails transfer = new TransferDetails(use,chitie);
                transfer.WindowState = FormWindowState.Maximized;
                transfer.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(transfer);
                panel1.Tag = transfer;
                transfer.BringToFront();
                transfer.Show();
            }
       

        }

        private void btnThemGiaoDich_Click(object sender, EventArgs e)
        {
            Transfer transfer = new Transfer(use,kh);
            transfer.WindowState = FormWindowState.Maximized;
            transfer.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(transfer);
            panel1.Tag = transfer;
            transfer.BringToFront();
            transfer.Show();

        }

        private void TransferDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
