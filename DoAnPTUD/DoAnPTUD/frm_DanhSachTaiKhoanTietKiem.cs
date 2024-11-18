using BUS;
using DAL;
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
    public partial class frm_DanhSachTaiKhoanTietKiem : Form,BaseGUI
    {
        public frm_DanhSachTaiKhoanTietKiem()
        {
            InitializeComponent();
        }

        public void Tim()
        {
            DAL_LoadValue load = new DAL_LoadValue();
            dgvThongTin.DataSource = load.HienThiDanhSachTKTK(TimThongTin());
        }
        public Dictionary<string, string> TimThongTin()
        {
            Dictionary<string, string> whereArg = new Dictionary<string, string>();
            foreach (var item in plThongTin.Controls)
            {
                if (item is TextBox txt && !string.IsNullOrEmpty((item as TextBox).Text))
                {
                    if (whereArg != null)
                    {
                        whereArg.Add(txt.Tag.ToString(), txt.Text);
                    }
                }
                if (item is ComboBox cb && !string.IsNullOrEmpty((item as ComboBox).Text.Trim()))
                {
                    whereArg.Add(cb.Tag.ToString(), cb.SelectedValue.ToString().Trim());
                }
            }
            return whereArg;
        }

        private void frm_DanhSachTaiKhoanTietKiem_Load(object sender, EventArgs e)
        {
            BLL_LoadValue load = new BLL_LoadValue();
            List<DTO_KhachHang> list = load.HienThiDanhSachKH();
            list.Insert(0, new DTO_KhachHang { IdKhachHang = 0, TenKhachHang = "" });
            cbMaKH.DataSource = list;
            cbMaKH.DisplayMember = "TenKhachHang";
            cbMaKH.ValueMember = "IdKhachHang";
            cbMaKH.SelectedIndex = 0;
        }
    }
}
