using BLL;
using BUS;
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
    public partial class frm_DanhSachGiaoDich : Form, BaseGUI
    {
        public frm_DanhSachGiaoDich()
        {
            InitializeComponent();
        }

        private void frm_DanhSachGiaoDich_Load(object sender, EventArgs e)
        {
            BLL_LoadValue load = new BLL_LoadValue();
            cbLoaiGD.DataSource = load.DanhSachLoaiGD();
            cbLoaiGD.DisplayMember = "TenLoaiGD";
            cbLoaiGD.ValueMember = "IdLoaiGD";

            cbLoaiTK.DataSource = load.DanhSachLoaiTK();
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

        public void Tim()
        {
            BLL_GiaoDich gd = new BLL_GiaoDich();
            dgvThongTin.DataSource = gd.HienThiDanhSachGiaoDich(TimThongTin());
        }
    }
}
