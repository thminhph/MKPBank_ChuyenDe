using BLL;
using DAL;
using DTO;
using System;
﻿using System;
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
        BLL_ThongTinKH bll_KhachHang = new BLL_ThongTinKH();
        DTO_TaiKhoan t = new DTO_TaiKhoan();
        DTO_ThongTinKH khHang = new DTO_ThongTinKH();


        public DangKyChiTiet(DTO_TaiKhoan tks, DTO_ThongTinKH kh)
        {
            InitializeComponent();
            this.t = tks;
            this.khHang = kh;

        public DangKyChiTiet()
        {
            InitializeComponent();
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void DangKyChiTiet_Load(object sender, EventArgs e)
        {
            cboTienTe.SelectedIndex = 0;

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                khHang.TenKhachHang = txtHoVaTen.Text;
                khHang.NgaySinh = dtpNgaySinh.Value;
                khHang.SoDienThoai = khHang.SoDienThoai;
                khHang.QuocTich = txtQuocTich.Text;
                khHang.SoGiayTo = txtCCCD.Text;
                khHang.DiaChi = txtDiaChi.Text;
                khHang.LoaiGiayTo = "CCCD";
                khHang.Nganh = 2;
                khHang.NganhChinh = 1;
                khHang.NgayCap = dtpNgayCap.Value;
                khHang.NoiCap = txtNoiCap.Text;
                khHang.Email = txtEmail.Text;
                t.TienTe = cboTienTe.Text;
                tk.DangKyKH(khHang);
                var dsKH = bll_KhachHang.laydsTTKH();
                t.MaKhachHang = dsKH.Count;
                tk.DangKyCT(t);

            }
            catch (Exception)
            {

                throw;
            }
            MessageBox.Show("Đăng ký thành công !!!!");
            DangNhap dn = new DangNhap();   
            dn.Show();

            this.Hide();

        }

            //if (txtTen.Text.Trim() == "")
            //{
            //    MessageBox.Show("Vui lòng nhập Email!"); ;
            //}
            //else if (txtSoDienThoai.Text.Trim() == "")
            //{
            //    MessageBox.Show("Vui lòng nhập Số điện thoại!"); ;
            //}
            //else
            //{
            //    //DangKy.taiKhoan.Email = txtEmail.Text;
            //    //taiKhoan.SoDienThoai = txtSoDienThoai.Text;
            //    //DangKyChiTiet us = new DangKyChiTiet();
            //    //us.Show();
            //    //this.Hide();
            //}
            //HomeUser us = new HomeUser();
            //us.Show();
            //this.Hide();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            DangKy us = new DangKy();
            us.Show();
            this.Hide();
        }

        private void cboLoaiThe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
