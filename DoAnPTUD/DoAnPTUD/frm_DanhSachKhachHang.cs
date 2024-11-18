using BUS;
using System;
using System.Collections;
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
    public partial class frm_DanhSachKhachHang : Form, BaseGUI
    {
        public frm_DanhSachKhachHang()
        {
            InitializeComponent();
            loadComboBox();
        }
        void loadComboBox()
        {
            BLL_LoadValue load = new BLL_LoadValue();
            cbNganhChinh.DataSource = load.XemNganhChinh();
            cbNganhChinh.DisplayMember = "TenNganh";
            cbNganhChinh.ValueMember = "IdNganhChinh";
            cbNganh.DataSource = load.XemNganh(Convert.ToInt32(cbNganhChinh.SelectedValue));
            cbNganh.DisplayMember = "TenNganh";
            cbNganh.ValueMember = "IdNganh";
            cbNganhChinh.SelectedIndexChanged -= cbNganhChinh_SelectedIndexChanged;
            cbNganhChinh.SelectedIndexChanged += cbNganhChinh_SelectedIndexChanged;
            cbLoaiKh.DataSource = load.DanhSachLoaiKH();
            cbLoaiKh.DisplayMember = "TenLoai";
            cbLoaiKh.ValueMember = "IdLoaiKH";
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
                    if (cb.Tag.ToString() != "Loai")
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

        private void cbNganhChinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            BLL_LoadValue load = new BLL_LoadValue();
            if (cbNganhChinh.SelectedValue != null)
            {
                //MessageBox.Show(cbNganhChinh.SelectedValue.ToString());
                cbNganh.DataSource = load.XemNganh(int.Parse(cbNganhChinh.SelectedValue.ToString()));
                cbNganh.DisplayMember = "TenNganh";
                cbNganh.ValueMember = "IdNganh";
            }
        }

        public void Tim()
        {
            BLL_LoadValue kh = new BLL_LoadValue();
            dgvKhachHang.DataSource = kh.HienThiDanhSachKH(TimThongTin());
        }
    }
}
