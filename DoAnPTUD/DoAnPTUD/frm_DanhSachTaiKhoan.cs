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
    public partial class frm_DanhSachTaiKhoan : Form
    {
        public frm_DanhSachTaiKhoan()
        {
            InitializeComponent();
            loadComboBox();
        }
        void loadComboBox()
        {
            BLL_LoadValue load = new BLL_LoadValue();
            //cbLoaiKh.DataSource = load.DanhSachLoaiKH();
            cbLoaiKh.DisplayMember = "TenLoai";
            cbLoaiKh.ValueMember = "IdLoaiKH";
            cbLoaiTK.DataSource = load.XemDSLoaiTK();
            cbLoaiTK.DisplayMember = "TenLoai";
            cbLoaiTK.ValueMember = "IdLoai";
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

        private void button1_Click(object sender, EventArgs e)
        {
            BLL_LoadValue kh = new BLL_LoadValue();
            dgvTaiKhoan.DataSource = kh.HienThiDanhSachKH(TimThongTin());
        }
    }
}
