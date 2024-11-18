using BLL;
using BUS;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPTUD
{
    public partial class frm_TaiKhoanTietKiemCuoiKy : Form
    {
        string[] Units = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
        string[] Tens = { "", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
        string[] BigUnits = { "", "nghìn", "triệu", "tỷ" };
        public frm_TaiKhoanTietKiemCuoiKy()
        {
            InitializeComponent();
            loadCIF();
            writerCIF();
            LoadValue();
        }
        void writerCIF()
        {
            try
            {
                using (StreamWriter file = new StreamWriter("IDTKTK.txt", false))
                {
                    file.WriteLine(txtIDTK.Text);
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
                using (StreamReader file = new StreamReader("IDTKTK.txt"))
                {
                    string str = file.ReadToEnd();
                    txtIDTK.Text = (long.Parse(str) + 1).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đọc file thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void LoadValue()
        {
            BLL_LoadValue bllLoad = new BLL_LoadValue();
            cbMaKH.DataSource = bllLoad.HienThiDanhSachKH();
            cbMaKH.DisplayMember = "TenKhachHang";
            cbMaKH.ValueMember = "IdKhachHang";

            cbNV.DataSource = bllLoad.XemNhanVien();
            cbNV.DisplayMember = "HoTen";
            cbNV.ValueMember = "IdNhanVien";
            //cbLoai.DataSource = bllLoad.DaSachLoaiTK();
            //cbLoai.DisplayMember = "TenLoai";
            //cbLoai.ValueMember = "IdLoaiTK";
        }

        private void cbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            BLL_KhachHang load = new BLL_KhachHang();
            cbMaKH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbMaKH.AutoCompleteSource = AutoCompleteSource.ListItems;
            if (cbMaKH.SelectedItem is DTO_KhachHang selectKhachHang)
            {
                int id = selectKhachHang.IdKhachHang;
                cbTKLV.DataSource = load.HienThiDSTaiKhoanTheoKH(id);
                cbTKLV.DisplayMember = "IdTaiKhoan";
                cbTKLV.ValueMember = "IdTaiKhoan";
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] arr = cbThoiHan.Text.Split(' ');
            dtDaoHan.Value = dtNgayGiaTri.Value.AddMonths(int.Parse(arr[0]));
        }
        public DTO_TaiKhoanTietKiem TaiKhoanTietKiem()
        {
            DTO_TaiKhoanTietKiem tktk = new DTO_TaiKhoanTietKiem(long.Parse(txtIDTK.Text),
                    Convert.ToInt32(cbMaKH.SelectedValue),
                    4,
                    cbTienTe.Text,
                    txtTieuDe.Text,
                    txtTieuDeNgan.Text,
                    cbNV.SelectedValue.ToString(),
                    "",
                    decimal.Parse(txtSoTien.Text),
                    dtNgayGiaTri.Value,
                    dtDaoHan.Value,
                    float.Parse(txtLaiSuat.Text),
                    Convert.ToInt64(cbTKLV.SelectedValue));
            return tktk;
        }

        private void txtSoTien_TextChanged(object sender, EventArgs e)
        {
            double soTien = double.Parse(txtSoTien.Text);
            lbTienChu.Text = ConvertToWords(soTien);

        }
        public string ConvertToWords(double number)
        {
            if (number == 0) return "không đồng";

            string result = "";
            int bigUnitIndex = 0;

            long integerPart = (long)number;
            int fractionPart = (int)((number - integerPart) * 100); // Lấy phần thập phân (2 chữ số)

            // Chuyển đổi phần nguyên
            while (integerPart > 0)
            {
                int threeDigits = (int)(integerPart % 1000);
                integerPart /= 1000;

                if (threeDigits > 0)
                {
                    string threeDigitsText = ConvertThreeDigitsToWords(threeDigits);
                    result = $"{threeDigitsText} {BigUnits[bigUnitIndex]} {result}".Trim();
                }

                bigUnitIndex++;
            }

            result = result.Trim() + " đồng";

            // Thêm phần thập phân nếu có
            if (fractionPart > 0)
            {
                result += $" và {ConvertThreeDigitsToWords(fractionPart)} xu";
            }

            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(result.Trim());
        }

        private string ConvertThreeDigitsToWords(int number)
        {
            int hundreds = number / 100;
            int tens = (number % 100) / 10;
            int units = number % 10;

            string result = "";

            if (hundreds > 0)
            {
                result += Units[hundreds] + " trăm";
            }

            if (tens > 0)
            {
                result += " " + Tens[tens];
            }
            else if (hundreds > 0 && units > 0)
            {
                result += " lẻ";
            }

            if (units > 0)
            {
                result += " " + Units[units];
            }

            return result.Trim();
        }

    }
}
