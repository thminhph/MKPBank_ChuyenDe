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
    public partial class frm_DanhSachKhachHang : Form,BaseGUI
    {
        public frm_DanhSachKhachHang()
        {
            InitializeComponent();
            loadComboBox();
        }
        private void frm_DanhSachKhachHang_Load(object sender, EventArgs e)
        {
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
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] arr =
            {
                txtMaKH.Text,
                cbLoaiKh.Text,
                txtSDT.Text,
                txtTen.Text,
                txtSGT.Text,
                cbNganhChinh.Text,
                cbNganh.Text
            };
            //BLL_LoadValue kh = new BLL_LoadValue();
            //dgvKhachHang.DataSource = kh.HienThiDanhSachKH(arr);
            BLL_LoadValue kh = new BLL_LoadValue();
            dgvKhachHang.DataSource = kh.HienThiDanhSachKH(TimThongTin());
        }
        public Dictionary<string,string> TimThongTin()
        {
            Dictionary<string,string> whereArg = new Dictionary<string, string>();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            BLL_LoadValue kh = new BLL_LoadValue();
            dgvKhachHang.DataSource = kh.HienThiDanhSachKH(TimThongTin());
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

        public void TimKhachHang()
        {
            BLL_LoadValue kh = new BLL_LoadValue();
            dgvKhachHang.DataSource = kh.HienThiDanhSachKH(TimThongTin());
        }
    }
}
