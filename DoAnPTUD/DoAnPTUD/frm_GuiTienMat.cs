using BLL;
using BUS;
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
    public partial class frm_GuiTienMat : Form
    {
        public frm_GuiTienMat()
        {
            InitializeComponent();
        }

        private void IdTK_Leave(object sender, EventArgs e)
        {
            BLL_LoadValue bllKH = new BLL_LoadValue();
            long number;
            bool isParsed = long.TryParse(txtIdTaiKhoan.Text, out number);
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
    }
}
