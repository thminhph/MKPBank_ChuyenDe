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
    public partial class frm_GuiTienMat : Form
    {
        public frm_GuiTienMat()
        {
            InitializeComponent();
            loadCIF();
            writerCIF();
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
        private void IdTK_Leave(object sender, EventArgs e)
        {
            BLL_LoadValue bllKH = new BLL_LoadValue();
            long number;
            bool isParsed = long.TryParse(txtIdTk.Text, out number);
            if (cbLoaiTK.SelectedIndex == 0)
            {
                List<string> list = bllKH.LayThongTinKhachHang(number);
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
        }
        public DTO_GuiTienMat GuiTienMat()
        {
            DTO_GuiTienMat tm = new DTO_GuiTienMat(
                txtIDGuiTienMat.Text,
                cbLoaiTK.Text,
                txtNoiDung.Text,
                long.Parse(txtIdTk.Text),
                float.Parse(lbCust.Text),
                float.Parse(lbCustMoi.Text));
            return tm;
        }
        private void txtSoTien_Leave(object sender, EventArgs e)
        {
            lbSoTienKH.Text = txtSoTien.Text;
            lbCustMoi.Text = (int.Parse(lbCust.Text) + int.Parse(txtSoTien.Text)) .ToString();
        }
    }
}
