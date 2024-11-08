using BLL;
using BUS;
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
    public partial class frm_MoTaiKhoan : Form
    {
        public frm_MoTaiKhoan()
        {
            InitializeComponent();
            loadID();
            writerID();
            loadComboBox();
            
        }
        void writerID()
        {
            try
            {
                using (StreamWriter file = new StreamWriter("ID.txt", false))
                {
                    file.WriteLine(txtIdTaiKhoan.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đọc file thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        void loadID()
        {
            try
            {
                using (StreamReader file = new StreamReader("ID.txt"))
                {
                    string str = file.ReadToEnd();
                    txtIdTaiKhoan.Text = (long.Parse(str) + 13).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đọc file thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void loadComboBox()
        {
            BLL_LoadValue loadV = new BLL_LoadValue();
            cbKhachHang.DataSource = loadV.HienThiDanhSachKH();
            cbKhachHang.DisplayMember = "TenKhachHang"; // Thuộc tính cần hiển thị
            cbKhachHang.ValueMember = "IdKhachHang"; // Giá trị ẩn
            cbNV.DataSource = loadV.XemNhanVien();
            cbNV.DisplayMember = "HoTen";
            cbNV.ValueMember = "IdNhanVien";
            cbLoai.DataSource = loadV.XemDSLoaiTK();
            cbLoai.DisplayMember = "TenLoai";
            cbLoai.ValueMember = "IdLoai";
        }
        int loaiKH = 0;
        private void cbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbKhachHang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbKhachHang.AutoCompleteSource = AutoCompleteSource.ListItems;
            if (cbKhachHang.SelectedItem is DTO_KhachHang selectKhachHang)
            {
                loaiKH = selectKhachHang.IdLoaiKH; ;
            }
        }
        public DTO_TaiKhoan ThemTaiKhoan()
        {
            if (loaiKH == 1)
            {
                //return new DTO_TaiKhoan(
                //    long.Parse(txtIdTaiKhoan.Text),
                //    Convert.ToInt32(cbKhachHang.SelectedValue),
                //     Convert.ToInt32(cbLoai.SelectedValue).ToString(),
                //    cbSP.Text,
                //    cbTienTe.Text,
                //    txtTieuDeTK.Text,
                //    txtTenVietTat.Text,
                //    cbNV.SelectedValue.ToString(),
                //    cbPhi.Text,
                //    "@KHCN123");
            }
            if (loaiKH == 2)
            {
                //return new DTO_TaiKhoan(
                //    long.Parse(txtIdTaiKhoan.Text),
                //    Convert.ToInt32(cbKhachHang.SelectedValue),
                //    Convert.ToInt32(cbLoai.SelectedValue).ToString(),
                //    cbSP.Text,
                //    cbTienTe.Text,
                //    txtTieuDeTK.Text,
                //    txtTenVietTat.Text,
                //    cbNV.SelectedValue.ToString(),
                //    cbPhi.Text,
                //    "@KHDN123");
            }
            return null;
        }

        private void frm_MoTaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}
