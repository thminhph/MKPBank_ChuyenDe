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
using System.Xml.Linq;

namespace DoAnPTUD
{

    public partial class frm_Main : Form
    {
        //private BaseGUI baseGUI;
        private frm_KhachHangCaNhan frmKH;
        private frm_KhachHangDoanhNghiep frmKHDN;
        private frm_DanhSachKhachHang frmNhanVien;
        private frm_DanhSachKhachHang frmDSKh;
        private frm_MoTaiKhoan frmMoTaiKhoan;
        private frm_GuiTienMat frmGuiTienMat;
        private Form activeForm = null;
        private string checkBtn = "";
        // Khai báo sự kiện để frmKhachHangCaNhan có thể lắng nghe
        public event EventHandler OnSaveButtonClick, OnRemoveButtonClick;

        

        public frm_Main()
        {
            InitializeComponent();
            pnBtn.Visible = false;
        }
        void OpenChidForm(Form form)
        {
            //if (activeForm != null)
            //{
            //    activeForm.Close(); // Đóng form con đang mở trước đó
            //    activeForm.Dispose();
            //}
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
            pn_Body.Controls.Add(form);
            pn_Body.Tag = form;
            form.BringToFront();
            form.Show();

        }
        int idLoai = 0;
        string selectNode = "";
        private void tvShow_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                selectNode = e.Node.Text;
                if (selectNode == "Mở khách hàng cá nhân")
                {

                    frmKH = new frm_KhachHangCaNhan();
                    OpenChidForm(frmKH);
                    pnBtn.Visible = true;
                    Button[] btn = { btnDone, btnRemove, btnSearch, btnPrint, btnEdit };
                    foreach (var item in btn)
                    {
                        Enablad_Btn(item);
                    }
                    btnSave.Enabled = true;
                    btnSave.BackColor = Color.Red;
                    btnSearchList.Enabled = true;
                    btnSearchList.BackColor = Color.Red;
                }
                if (selectNode == "Mở khách hàng doanh nghiệp")
                {
                    frmKHDN = new frm_KhachHangDoanhNghiep();
                    OpenChidForm(frmKHDN);
                    pnBtn.Visible = true;
                    Button[] btn = { btnDone, btnRemove, btnSearch, btnPrint, btnEdit };
                    foreach (var item in btn)
                    {
                        Enablad_Btn(item);
                    }
                    btnSave.Enabled = true;
                    btnSave.BackColor = Color.Red;
                    btnSearchList.Enabled = true;
                    btnSearchList.BackColor = Color.Red;
                }
                if (selectNode == "Danh sách khách hàng")
                {
                    frmNhanVien = new frm_DanhSachKhachHang();
                    OpenChidForm(frmNhanVien);
                    pnBtn.Visible = true;
                    Button[] btn = { btnDone, btnRemove, btnPrint, btnEdit, btnSearchList, btnSave };
                    foreach (var item in btn)
                    {
                        Enablad_Btn(item);
                    }
                    btnSearch.Enabled = true;
                    btnSearch.BackColor = Color.Red;
                }
                if (selectNode == "Mở tài khoản")
                {
                    frmMoTaiKhoan = new frm_MoTaiKhoan();
                    OpenChidForm(frmMoTaiKhoan);
                    pnBtn.Visible = true;
                    Button[] btn = { btnDone, btnRemove, btnSearch, btnPrint, btnEdit };
                    foreach (var item in btn)
                    {
                        Enablad_Btn(item);
                    }
                    btnSave.Enabled = true;
                    btnSave.BackColor = Color.Red;
                    btnSearchList.Enabled = true;
                    btnSearchList.BackColor = Color.Red;
                }
                if (selectNode == "Tiền gửi tiền mặt")
                {
                    frmGuiTienMat = new frm_GuiTienMat();
                    OpenChidForm(frmGuiTienMat);
                    pnBtn.Visible = true;
                    Button[] btn = { btnDone, btnRemove, btnSearch, btnPrint, btnEdit };
                    foreach (var item in btn)
                    {
                        Enablad_Btn(item);
                    }
                    btnSave.Enabled = true;
                    btnSave.BackColor = Color.Red;
                    btnSearchList.Enabled = true;
                    btnSearchList.BackColor = Color.Red;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (selectNode)
            {
                case "Mở khách hàng cá nhân":

                    if (checkBtn != "Edit")
                    {
                        BLL_KhachHang busKH = new BLL_KhachHang();
                        busKH.ThemKHCaNhan(frmKH.KhachHang());

                        // Khi thêm xong sẽ gọi lại form cập lại giá trị form thành rỗng
                        frmKH = new frm_KhachHangCaNhan();
                        OpenChidForm(frmKH);

                    }
                    else
                    {
                        //Khi checkBtn bằng giá trị Edit thì sẽ cập nhật lại giá trị khách hàng
                        frmKH.SetMainForm(this);
                        OnSaveButtonClick?.Invoke(this, EventArgs.Empty);
                        // Khi thêm xong sẽ gọi lại form cập lại giá trị form thành rỗng
                        frmKH = new frm_KhachHangCaNhan();
                        OpenChidForm(frmKH);

                    }
                    break;
                case "Mở khách hàng doanh nghiệp":
                    if (checkBtn != "Edit")
                    {
                        BLL_KhachHang busKH = new BLL_KhachHang();
                        busKH.ThemKHDoanhNghiep(frmKHDN.KhachHang());

                        // Khi thêm xong sẽ gọi lại form cập lại giá trị form thành rỗng
                        frmKHDN = new frm_KhachHangDoanhNghiep();
                        OpenChidForm(frmKHDN);

                    }
                    else
                    {
                        //Khi checkBtn bằng giá trị Edit thì sẽ cập nhật lại giá trị khách hàng
                        frmKHDN.SetMainForm(this);
                        OnSaveButtonClick?.Invoke(this, EventArgs.Empty);
                        // Khi thêm xong sẽ gọi lại form cập lại giá trị form thành rỗng
                        frmKHDN = new frm_KhachHangDoanhNghiep();
                        OpenChidForm(frmKHDN);

                    }
                    break;
                case "Mở tài khoản":
                    if (checkBtn != "Edit")
                    {
                        BLL_TaiKhoan bllTK = new BLL_TaiKhoan();
                        //bllTK.Them(frmMoTaiKhoan.ThemTaiKhoan());

                        // Khi thêm xong sẽ gọi lại form cập lại giá trị form thành rỗng
                        frmMoTaiKhoan = new frm_MoTaiKhoan();
                        OpenChidForm(frmMoTaiKhoan);

                    }
                    else
                    {
                        //Khi checkBtn bằng giá trị Edit thì sẽ cập nhật lại giá trị khách hàng
                        //frmKHDN.SetMainForm(this);
                        //OnSaveButtonClick?.Invoke(this, EventArgs.Empty);
                        //// Khi thêm xong sẽ gọi lại form cập lại giá trị form thành rỗng
                        //frmKHDN = new frm_KhachHangDoanhNghiep();
                        //OpenChidForm(frmKHDN);

                    }
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
        void Enablad_Btn()
        {
            foreach (Button item in pnBtn.Controls)
            {
                if (item.Name == "btnDone" || item.Name == "btnRemove" || item.Name == "btnEdit")
                {
                    item.Enabled = true;
                    item.BackColor = Color.Red;
                }
                else
                {
                    item.Enabled = false;
                    item.BackColor = Color.LightCoral;
                }
            }
        }

        private void btnSearchList_Click(object sender, EventArgs e)
        {
            switch (selectNode)
            {
                case "Mở khách hàng cá nhân":
                    OpenDanhSachForm();
                    Enablad_Btn();
                    break;
                case "Mở khách hàng doanh nghiệp":
                    OpenDanhSachForm();
                    Enablad_Btn();
                    break;
                default:
                    break;
            }
        }
        void OpenDanhSachForm()
        {
            frm_DanhSach danhSachForm = new frm_DanhSach(selectNode);
            danhSachForm.OnRowSelected -= HandleRowSelected; // Loại bỏ trước khi thêm
            danhSachForm.OnRowSelected += HandleRowSelected;
            OpenChidForm(danhSachForm);

        }
        void HandleRowSelected(int id)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
                activeForm = null;
            }
            if (selectNode == "Mở khách hàng cá nhân")
            {
                // Mở lại frm_KhachHangCaNhan với thông tin từ ID đã chọn
                frmKH = new frm_KhachHangCaNhan(id); // Truyền ID vào form để lấy chi tiết khách hàng
                OpenChidForm(frmKH);
            }
            if (selectNode == "Mở khách hàng doanh nghiệp")
            {
                frmKHDN = new frm_KhachHangDoanhNghiep(id);
                OpenChidForm(frmKHDN);
            }

        }
        void Enabled_Save_Search()
        {
            Enablad_Btn(btnEdit);
            Enablad_Btn(btnSearch);
            Enablad_Btn(btnPrint);
            Enablad_Btn(btnRemove);
            Enablad_Btn(btnDone);
            btnSave.Enabled = true;
            btnSave.BackColor = Color.Red;
            btnSearchList.Enabled = true;
            btnSearchList.BackColor = Color.Red;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBtn != "Remove")
                {
                    checkBtn = "Edit";
                    Enabled_Save_Search();
                    switch (selectNode)
                    {
                        case "Mở khách hàng cá nhân":
                            frmKH.Enabled_Control(this);
                            break;
                        case "Mở khách hàng doanh nghiệp":
                            frmKHDN.Enabled_Control(this);
                            break;
                        default:
                            break;
                    }

                    OnSaveButtonClick?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Enabled_Save_Search();
            frmKH = new frm_KhachHangCaNhan();
            OpenChidForm(frmKH);
            frmKH.Enabled_Control(this);
            OnSaveButtonClick?.Invoke(this, EventArgs.Empty);
        }

        

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Enabled_Save_Search();
            btnEdit.Enabled = true;
            btnEdit.BackColor = Color.Red;
            switch (selectNode)
            {
                case "Mở khách hàng cá nhân":
                    frmKH.Remove_Customer(this);
                    OnRemoveButtonClick?.Invoke(this, EventArgs.Empty);
                    frmKH.Enabled_Control(this);
                    OnSaveButtonClick?.Invoke(this, EventArgs.Empty);
                    break;
                case "Mở khách hàng doanh nghiệp":
                    frmKHDN.Remove_Customer(this);
                    OnRemoveButtonClick?.Invoke(this, EventArgs.Empty);
                    frmKHDN.Enabled_Control(this);
                    OnSaveButtonClick?.Invoke(this, EventArgs.Empty);
                    break;
                default:
                    break;
            }
            checkBtn = "Remove";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //baseGUI = new BaseGUI();
        }

        //void BaseGUI.TimKhachHang(Dictionary<string, string> whereArg)
        //{
        //    BLL_LoadValue kh = new BLL_LoadValue();
        //    frmDSKh = new frm_DanhSachKhachHang();
        //    frmDSKh.dgvKhachHang.DataSource = kh.HienThiDanhSachKH(whereArg);
        //}
    }

}
