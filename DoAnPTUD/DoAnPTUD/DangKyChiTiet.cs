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
    public partial class DangKyChiTiet : Form
    {
        public BLL_TaiKhoan tk = new BLL_TaiKhoan(); 
        DTO_TaiKhoan t= new DTO_TaiKhoan();
        DTO_ThongTinKH khHang = new DTO_ThongTinKH();
        public DangKyChiTiet(DTO_TaiKhoan tks,DTO_ThongTinKH k)
        {
            InitializeComponent();
           this.t = tks;
           this.khHang = k;
        
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void DangKyChiTiet_Load(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
         
            khHang.TenKhachHang = txtHoVaTen.Text;
             khHang.NgaySinh= dtpNgaySinh.Value;
              khHang.QuocTich= txtQuocTich.Text;
              khHang.SoGiayTo= txtCCCD.Text;
             khHang.DiaChi= txtDiaChi.Text;
            khHang.LoaiGiayTo = "CCCD";
            khHang.Nganh = 2;
            khHang.NganhChinh = 1;
            khHang.NhanVienLV ="NV003";
             khHang.NgayCap= dtpNgayCap.Value ;
             khHang.NoiCap = txtNoiCap.Text ;
            t.NhanVienLV = "NV003";
             khHang.Email= txtEmail.Text;
            t.TienTe = "VND";
            t.LoaiTaiKhoan = "1";
            tk.DangKyCT(khHang,t);
            
        }
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            DangKy us = new DangKy();
            us.Show();
            this.Hide();
        }
    }
}
