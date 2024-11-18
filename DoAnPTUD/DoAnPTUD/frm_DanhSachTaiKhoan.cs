using BLL;
using BUS;
using DAL;
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
    public partial class frm_DanhSachTaiKhoan : Form, BaseGUI
    {
        public frm_DanhSachTaiKhoan()
        {
            InitializeComponent();
            loadComboBox();
        }
        void loadComboBox()
        {
            BLL_LoadValue load = new BLL_LoadValue();
            cbLoaiKh.DataSource = load.DanhSachLoaiKH();
            cbLoaiKh.DisplayMember = "TenLoai";
            cbLoaiKh.ValueMember = "IdLoaiKH";
            cbLoaiTK.DataSource = load.XemDSLoaiTK();
            cbLoaiTK.DisplayMember = "TenLoai";
            cbLoaiTK.ValueMember = "IdLoai";
        }
        private Dictionary<string, string> TimThongTin()
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
                    if (cb.Tag.ToString() != "TienTe")
                    {
                        whereArg.Add(cb.Tag.ToString(), cb.SelectedValue.ToString());
                    }
                    else
                    {
                        whereArg.Add(cb.Tag.ToString(), cb.Text.Trim());
                    }

                }
            }
            return whereArg;
        }

        public void Tim()
        {
            BLL_LoadValue kh = new BLL_LoadValue();
            dgvTaiKhoan.DataSource = kh.HienThiDanhSachTK(TimThongTin());
        }
    }
}
