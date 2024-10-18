using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace DoAnPTUD
{
    public partial class frmMain : Form
    {
        string conn;
        private frmKhachHangCaNhan frmKH;
        private Form activeForm = null;

        public frmMain(string conn)
        {
            InitializeComponent();
            this.conn = conn;
            pnBtn.Visible = false;
        }
        void OpenChidForm(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close(); // Đóng form con đang mở trước đó
            }
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
            pn_Body.Controls.Add(form);
            pn_Body.Tag = form;
            form.BringToFront();
            form.Show();
        }

        string selectNode = "";
        private void tvShow_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                selectNode = e.Node.Text;
                if (selectNode == "Mở khách hàng cá nhân")
                {

                    frmKH = new frmKhachHangCaNhan(conn);
                    OpenChidForm(frmKH);
                    pnBtn.Visible = true;
                    Button[] btn = { btnDone, btnRemove, btnSearch, btnPrint, btnEdit };
                    foreach (var item in btn)
                    {
                        Enablad_Btn(item);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (selectNode)
            {
                case "Mở khách hàng cá nhân":
                    BUS_KhachHangCaNhan busKH = new BUS_KhachHangCaNhan();
                    busKH.Them(frmKH.KhachHang(), conn);
                    busKH.ThemChiTiet((DTO_ChiTietKHCN)frmKH.KhachHang(), conn);
                    frmKH = new frmKhachHangCaNhan(conn);
                    OpenChidForm(frmKH);
                    break;
                default:
                    break;
            }
        }
        void Enablad_Btn(Button btn)
        {
            btn.Enabled = false;
            btn.BackColor = Color.LightCoral;

        }

        private void btnSearchList_Click(object sender, EventArgs e)
        {
            switch (selectNode)
            {
                case "Mở khách hàng cá nhân":
                    OpenDanhSachForm();
                    break;
                default:
                    break;
            }
        }
        void OpenDanhSachForm()
        {
            frmDanhSach danhSachForm = new frmDanhSach(selectNode, conn);
            danhSachForm.OnRowSelected += HandleRowSelected;
            OpenChidForm(danhSachForm);
        }
        void HandleRowSelected(int id)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }

            // Mở lại frm_KhachHangCaNhan với thông tin từ ID đã chọn
            frmKH = new frmKhachHangCaNhan(conn, id); // Truyền ID vào form để lấy chi tiết khách hàng
            OpenChidForm(frmKH);

        }
    }
}
