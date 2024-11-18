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
        private frm_KhachHangCaNhan frmKH;
        private frm_KhachHangDoanhNghiep frmKHDN;
        private frm_DanhSachKhachHang frmDSKh;
        private frm_MoTaiKhoan frmMoTaiKhoan;
        private frm_GuiTienMat frmGuiTienMat;
        private frm_TaiKhoanTietKiemCuoiKy frmTKTKCK;
        private frm_DanhSachTaiKhoan frmDSTK;
        private Form activeForm = null;
        private string checkBtn = "";
        private frm_InChiTietGuiTien frmInCTGT;
        private frm_DanhSachTaiKhoanTietKiem frmDSTKTK;
        // Khai báo sự kiện để frmKhachHangCaNhan có thể lắng nghe
        public event EventHandler OnSaveButtonClick, OnRemoveButtonClick;

        

        public frm_Main()
        {
           
            InitializeComponent();
            pnBtn.Visible = false;
            timer1.Start();
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
                    frmDSKh = new frm_DanhSachKhachHang();
                    OpenChidForm(frmDSKh);
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
                    Button[] btn = { btnDone, btnRemove, btnSearch, btnEdit };
                    foreach (var item in btn)
                    {
                        Enablad_Btn(item);
                    }
                    btnSave.Enabled = true;
                    btnSave.BackColor = Color.Red;
                    btnSearchList.Enabled = true;
                    btnSearchList.BackColor = Color.Red;
                    btnPrint.Enabled = true;
                    btnPrint.BackColor = Color.Red;
                }
                if (selectNode == "Mở")
                {
                    frmTKTKCK = new frm_TaiKhoanTietKiemCuoiKy();
                    OpenChidForm(frmTKTKCK);
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
                if (selectNode == "Danh sách tài khoản")
                {
                    frmDSTK = new frm_DanhSachTaiKhoan();
                    OpenChidForm(frmDSTK);
                    pnBtn.Visible = true;
                    Button[] btn = { btnDone, btnRemove, btnPrint, btnEdit, btnSearchList, btnSave };
                    foreach (var item in btn)
                    {
                        Enablad_Btn(item);
                    }
                    btnSearch.Enabled = true;
                    btnSearch.BackColor = Color.Red;
                }
                if (selectNode == "Danh sách tài khoản tiết kiệm")
                {
                    frmDSTKTK = new frm_DanhSachTaiKhoanTietKiem();
                    OpenChidForm(frmDSTKTK);
                    pnBtn.Visible = true;
                    Button[] btn = { btnDone, btnRemove, btnPrint, btnEdit, btnSearchList, btnSave };
                    foreach (var item in btn)
                    {
                        Enablad_Btn(item);
                    }
                    btnSearch.Enabled = true;
                    btnSearch.BackColor = Color.Red;
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
                        List<string> list = frmMoTaiKhoan.ThamGiaTK();
                        BLL_KhachHang bllKH = new BLL_KhachHang();
                        BLL_TaiKhoan bllTK = new BLL_TaiKhoan();
                        bllTK.Them(frmMoTaiKhoan.ThemTaiKhoan());
                        if (list[1].Length > 1)
                        {
                            bllKH.ThamGiaTK(long.Parse(list[0]), int.Parse(list[1]), list[2]);
                        }
                        

                        // Khi thêm xong sẽ gọi lại form cập lại giá trị form thành rỗng
                        frmMoTaiKhoan = new frm_MoTaiKhoan();
                        OpenChidForm(frmMoTaiKhoan);

                    }
                    else
                    {
                        //Khi checkBtn bằng giá trị Edit thì sẽ cập nhật lại giá trị khách hàng
                        frmMoTaiKhoan.SetMainForm(this);
                        OnSaveButtonClick?.Invoke(this, EventArgs.Empty);
                        // Khi thêm xong sẽ gọi lại form cập lại giá trị form thành rỗng
                        frmMoTaiKhoan = new frm_MoTaiKhoan();
                        OpenChidForm(frmMoTaiKhoan);

                    }
                    break;
                case "Mở":
                    if (checkBtn != "Edit")
                    {
                        BLL_TaiKhoanTietKiem bllTK = new BLL_TaiKhoanTietKiem();
                        bllTK.ThemTaiKhoanTietKiem(frmTKTKCK.TaiKhoanTietKiem());

                        // Khi thêm xong sẽ gọi lại form cập lại giá trị form thành rỗng
                        frmTKTKCK = new frm_TaiKhoanTietKiemCuoiKy();
                        OpenChidForm(frmTKTKCK);

                    }
                    else
                    {
                        

                    }
                    break;
                case "Tiền gửi tiền mặt":

                        BLL_GuiTienMat bllTM = new BLL_GuiTienMat();
                        DTO_GuiTienMat tm = frmGuiTienMat.GuiTienMat();
                        bllTM.Them(tm);
                        bllTM.CapNhatTien(tm.IdTK, tm.SoDu);

                        // Khi thêm xong sẽ gọi lại form cập lại giá trị form thành rỗng
                        frmGuiTienMat = new frm_GuiTienMat();
                        OpenChidForm(frmGuiTienMat);
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
        void Enablad_Btnn()
        {
            foreach (Button item in pnBtn.Controls)
            {
                if (item.Name == "btnDone" || item.Name == "btnRemove" || item.Name == "btnPrint")
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
                case "Mở tài khoản":
                    OpenDanhSachForm();
                    Enablad_Btn();
                    break;
                case "Tiền gửi tiền mặt":
                    OpenDanhSachForm();
                    Enablad_Btnn();
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
        void HandleRowSelected(string id)
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
                frmKH = new frm_KhachHangCaNhan(int.Parse(id)); // Truyền ID vào form để lấy chi tiết khách hàng
                OpenChidForm(frmKH);
            }
            if (selectNode == "Mở khách hàng doanh nghiệp")
            {
                frmKHDN = new frm_KhachHangDoanhNghiep(int.Parse(id));
                OpenChidForm(frmKHDN);
            }
            if (selectNode == "Mở tài khoản")
            {
                frmMoTaiKhoan = new frm_MoTaiKhoan(long.Parse(id));
                OpenChidForm(frmMoTaiKhoan);
            }
            if (selectNode == "Tiền gửi tiền mặt")
            {
                idTG = id;
                frmGuiTienMat = new frm_GuiTienMat(id);
                OpenChidForm(frmGuiTienMat);
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
                        case "Mở tài khoản":
                            frmMoTaiKhoan.Enabled_Control(this);
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
            //OnSaveButtonClick?.Invoke(this, EventArgs.Empty);
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
        string idTG = "";
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (selectNode == "Tiền gửi tiền mặt")
            {
                frmInCTGT = new frm_InChiTietGuiTien(idTG);
                OpenChidForm(frmInCTGT);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
            this.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BLL_TaiKhoanTietKiem bllTKTK = new BLL_TaiKhoanTietKiem();
            foreach (var item in bllTKTK.LayTatCaMa())
            {
                bllTKTK.TinhLaiTietKiem(item);
            }
            timer1.Stop();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (selectNode == "Danh sách tài khoản tiết kiệm")
            {
                frmDSTKTK.Tim();
            }
        }
    }

}
