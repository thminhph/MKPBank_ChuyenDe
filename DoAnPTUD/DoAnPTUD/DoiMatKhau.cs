using BLL;
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
    public partial class DoiMatKhau : Form
    {
        BLL_ThongTinKH bll_ThongTinKH = new BLL_ThongTinKH();
        BLL_TaiKhoan bll_TaiKhoan = new BLL_TaiKhoan();
        private DTO_TaiKhoan tk;
        public DoiMatKhau(DTO_TaiKhoan tk)
        {
            InitializeComponent();
            this.tk = tk;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            Settings st = new Settings();
            st.Show();
            this.Hide();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string mk_old = txtMatKhauCu.Text;
            string mk = txtMatKhau.Text;
            string mk_confirm = txtNhapLaiMatKhau.Text;

            if (txtMatKhauCu.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được để trống!");
            }
            else if (txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu cũ không được để trống!");
            }
            else if (txtNhapLaiMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Nhập lại mật khẩu cũ không được để trống!");
            }
            else
            {
                bool kTra = kiemTraMatKhau(mk_old);
                if (kTra)
                {
                    if (mk_confirm != mk)
                    {
                        MessageBox.Show("Mật khẩu cũ không khớp!");
                    }
                    else
                    {
                        bll_TaiKhoan.SuaMK(mk,tk.IdTaiKhoan.ToString());
                        MessageBox.Show("Sủa thành công!");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ sai. Vui lòng nhập lại!");
                }
            }
        }

       private bool kiemTraMatKhau(string mkCu)
        {
            var th= tk;
            return tk.Matkhau.Trim()==mkCu.Trim();
        }
    }
}
