using BUS;
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
    public partial class frm_RutTienMat : Form
    {
        string id;
        public event Action<string> InPhieuGT;
        public frm_RutTienMat()
        {
            InitializeComponent();
            loadCIF();
            writerCIF();
            loadLoaiTK();
        }
        public frm_RutTienMat(string id)
        {
            InitializeComponent();
            this.id = id;
            InPhieuGT?.Invoke(id);
            loadCIF();
            writerCIF();
            loadLoaiTK();
            LoadChiTietGuiTien();

        }
        void writerCIF()
        {
            try
            {
                using (StreamWriter file = new StreamWriter("GuiTienMat.txt", false))
                {
                    file.WriteLine(txtIDGuiTienMat.Text);
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
                using (StreamReader file = new StreamReader("GuiTienMat.txt"))
                {
                    string str = file.ReadToEnd();
                    string[] arr = str.Split('.');
                    int t = int.Parse(arr[2]) + 1;
                    txtIDGuiTienMat.Text = $"{arr[0]}.{arr[1]}.{t}";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đọc file thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void LoadChiTietGuiTien()
        {
            BLL_LoadValue bllGT = new BLL_LoadValue();
            DTO_GiaoDich gt = bllGT.LayChiTietGT(id);
            txtIDGuiTienMat.Text = gt.IdGuiTien;
            txtIdTk.Text = gt.IdTK.ToString();
            cbLoaiTK.SelectedValue = bllGT.LayIdLoaiTK(gt.IdTK);
            List<string> list = bllGT.LayThongTinKhachHang(gt.IdTK, Convert.ToInt32(cbLoaiTK.SelectedValue));
            lbCIF.Text = list[0];
            lbTenKH.Text = list[1];
            lbTenTK.Text = list[2];
            lbTienTe.Text = list[3];
            lbCust.Text = list[4];
            lbCustMoi.Text = gt.SoDu.ToString();
            txtNoiDung.Text = gt.NoiDung;
            lbSoTienKH.Text = gt.SoGiaoDich.ToString();
            txtSoTien.Text = gt.SoGiaoDich.ToString();

        }
        private void IdTK_Leave(object sender, EventArgs e)
        {
            BLL_LoadValue bllKH = new BLL_LoadValue();
            long number;
            bool isParsed = long.TryParse(txtIdTk.Text, out number);
            List<string> list = bllKH.LayThongTinKhachHang(number, Convert.ToInt32(cbLoaiTK.SelectedValue));
            if (list != null)
            {
                lbCIF.Text = list[0];
                lbTenKH.Text = list[1];
                lbTenTK.Text = list[2];
                lbTienTe.Text = list[3];
                lbCust.Text = list[4];
            }
            else
            {
                lbCIF.Text = "";
                lbTenKH.Text = "";
                lbTenTK.ForeColor = Color.Red;
                lbTenTK.Text = "Không tìm thấy trong dữ liệu";
                lbTienTe.Text = "";
                lbCust.Text = "";
                lbCustMoi.Text = "";
            }
        }
        public DTO_GiaoDich RutTienMat()
        {
            DTO_GiaoDich tm = new DTO_GiaoDich(
                txtIDGuiTienMat.Text,
                txtNoiDung.Text,
                long.Parse(txtIdTk.Text),
                decimal.Parse(lbSoTienKH.Text),
                decimal.Parse(lbCustMoi.Text));
            return tm;
        }
        void loadLoaiTK()
        {
            BLL_LoadValue load = new BLL_LoadValue();
            cbLoaiTK.DataSource = load.DanhSachLoaiTK();
            cbLoaiTK.DisplayMember = "TenLoai";
            cbLoaiTK.ValueMember = "IdLoai";
        }
        string[] Units = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
        string[] Tens = { "", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
        string[] BigUnits = { "", "nghìn", "triệu", "tỷ" };
        private void txtSoTien_TextChanged(object sender, EventArgs e)
        {
            if (txtSoTien.Text != "" && decimal.TryParse(txtSoTien.Text, out _))
            {
                double soTien = double.Parse(txtSoTien.Text);
                lbSoTienChu.Text = ConvertToWords(soTien);
            }

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

        private void txtSoTien_Leave(object sender, EventArgs e)
        {
            if (txtSoTien.Text != "" && decimal.TryParse(txtSoTien.Text,out _))
            {
                lbSoTienKH.Text = txtSoTien.Text;
                if (lbCust.Text != "")
                {
                    decimal tong = (decimal.Parse(lbCust.Text) - decimal.Parse(txtSoTien.Text));
                    if (tong < 0)
                    {
                        txtSoTien.Text = "";
                        
                        lbSoTienKH.Text = "";
                        MessageBox.Show("Số dư không dủ để thực hiện");
                        txtSoTien.Focus();
                    }
                    else
                    {
                        lbCustMoi.Text = Math.Floor(tong).ToString();
                    }
                }

            }
            else
            {
                MessageBox.Show("Nội dung nhập không phải là số vui lòng nhập lại", "Thông báo");
                txtSoTien.Clear();
                txtSoTien.Focus();
            }
        }
    }
}
