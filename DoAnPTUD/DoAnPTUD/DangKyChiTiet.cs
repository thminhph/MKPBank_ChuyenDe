using BLL;
using DAL;
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
    public partial class DangKyChiTiet : Form
    {
        public BLL_TaiKhoan tk = new BLL_TaiKhoan();
        BLL_ThongTinKH bll_KhachHang = new BLL_ThongTinKH();
        DTO_TaiKhoan t = new DTO_TaiKhoan();
        DTO_ThongTinKH khHang = new DTO_ThongTinKH();
        DTO_SoDuTk sd = new DTO_SoDuTk();


        public DangKyChiTiet(DTO_TaiKhoan tks, DTO_ThongTinKH kh)
        {
            InitializeComponent();
            this.t = tks;
            this.khHang = kh;
            loadCIF();
            writerCIF();

        }
        string idKhacHang = "";
        void writerCIF()
        {
            try
            {
                using (StreamWriter file = new StreamWriter("CIF.txt", false))
                {
                    file.WriteLine(idKhacHang);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đọc file thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        void loadCIF()
        {
            try
            {
                using (StreamReader file = new StreamReader("CIF.txt"))
                {
                    string str = file.ReadToEnd();
                    idKhacHang = (int.Parse(str) + 1).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đọc file thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void DangKyChiTiet_Load(object sender, EventArgs e)
        {
            cboTienTe.SelectedIndex = 0;
            var data = tk.layDanhSachLoaiTK();
            cboLoaiThe.DataSource = data;
            cboLoaiThe.DisplayMember = "TenLoai";
            cboLoaiThe.ValueMember = "IdLoai";
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
  
        
            try
            {
                khHang.IdKhachHang = int.Parse(idKhacHang);
                khHang.TenKhachHang = txtHoVaTen.Text;
                khHang.NgaySinh = dtpNgaySinh.Value;
                khHang.SoDienThoai = khHang.SoDienThoai;
                khHang.QuocTich = txtQuocTich.Text;
                khHang.SoGiayTo = txtCCCD.Text;
                khHang.DiaChi = txtDiaChi.Text;
                khHang.LoaiGiayTo = "CCCD";
                khHang.Nganh = 2;
                khHang.NganhChinh = 2;
                khHang.NgayCap = dtpNgayCap.Value;
                khHang.NoiCap = txtNoiCap.Text;
                khHang.Email = txtEmail.Text;
                khHang.IdLoaiKH1=int.Parse(cboLoaiThe.SelectedValue.ToString());
                tk.DangKyKH(khHang);
                var dsKH = bll_KhachHang.laydsTTKH();
                t.TienTe = cboTienTe.Text;
                t.MaKhachHang = khHang.IdKhachHang;
                t.IdLoai = khHang.IdLoaiKH1;
                tk.DangKyCT(t);
                MessageBox.Show("Đăng ký thành công !!!!");
                DangNhap dn = new DangNhap();
                dn.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng ký không thành công !!!!");
                throw new Exception("error",ex);
            }

            this.Hide();

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

        private void cboLoaiThe_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
