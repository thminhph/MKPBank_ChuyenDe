using BLL;
using BUS;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPTUD
{
    public partial class frm_KhachHangCaNhan : Form
    {
        int id;

        private frm_Main form_Main;
        public frm_KhachHangCaNhan()
        {
            InitializeComponent();
            loadCIF();
            writerCIF();
            txtHo.Leave += Txt_Leave;
            txtTen.Leave += Txt_Leave;
            loadComboBox();
        }
        public frm_KhachHangCaNhan(int id)
        {
            this.id = id;
            InitializeComponent();
            loadCIF();
            writerCIF();
            txtHo.Leave += Txt_Leave;
            txtTen.Leave += Txt_Leave;
            loadComboBox();
            load_Value();
            Enabled_Control();
        }
        void Enabled_Control()
        {
            if (id == int.Parse(txtCif.Text))
            {
                txtCif.Enabled = false;
                foreach (Control control in tabPage1.Controls)
                {
                    if (control is TextBox || control is DateTimePicker || control is ComboBox || control is MaskedTextBox)
                    {
                        control.Enabled = false;
                    }
                }
                foreach (Control control in tabPage2.Controls)
                {
                    if (control is TextBox || control is DateTimePicker || control is ComboBox || control is MaskedTextBox)
                    {
                        control.Enabled = false;
                    }
                }
            }
        }
        private void Txt_Leave(object sender, EventArgs e)
        {
            string str = " ";
            TextBox txt = (TextBox)sender;
            if (txt.Name == "txtHo")
            {
                str = txt.Text + " " + txtTen.Text;
            }
            else if (txt.Name == "txtTen")
            {
                str = txtHo.Text + txt.Text;
            }
            txtTenDayDu.Text = str.Trim();
        }
        void writerCIF()
        {
            try
            {
                using (StreamWriter file = new StreamWriter("CIF.txt", false))
                {
                    file.WriteLine(txtCif.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đọc file thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        void loadCIF()
        {
            try
            {
                using (StreamReader file = new StreamReader("CIF.txt"))
                {
                    string str = file.ReadToEnd();
                    txtCif.Text = (int.Parse(str) + 1).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đọc file thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            cbNganhChinh.SelectedIndexChanged += cbNganhChinh_SelectedIndexChanged;
            cbNhanVien.DataSource = load.XemNhanVien();
            cbNhanVien.DisplayMember = "HoTen";
            cbNhanVien.ValueMember = "IdNhanVien";
        }
        public DTO_KhachHangCaNhan KhachHang()
        {
            int nganhChinh = Convert.ToInt32(cbNganhChinh.SelectedValue);
            int nganh = Convert.ToInt32(cbNganh.SelectedValue);
            string nv = cbNhanVien.SelectedValue.ToString();
            DTO_ChiTietKHCN kh = new DTO_ChiTietKHCN(
                    int.Parse(txtCif.Text),  // Truyền id vào đây
                    txtTenDayDu.Text,
                    txtDuong.Text + ", " + txtPhuong.Text + ", " + cbThanhPho.Text,
                    txtSDT.Text,
                    cbQuocGia.Text,
                    cbQuocTich.Text,
                    cbLoaiGiayTo.Text,
                    txtSoGiayTo.Text,
                    txtNoiCap.Text,
                    txtEmai.Text,
                    nganhChinh,
                    nganh,
                    nv,
                    dtNgaySinh.Value,
                    dtNgayCap.Value,
                    dtNgayHetHan.Value,
                    cbGioiTInh.Text,
                    cbXungHo.Text,
                    cbTTHonNhan.Text,
                    cbMaQH.Text,
                    txtSoVP.Text,
                    int.Parse(txtSoNguoi.Text),
                    cbNha.Text,
                    cbCuTru.Text,
                    cbTTViecLam.Text,
                    txtCTY.Text,
                    double.Parse(txtThuNhap.Text),
                    txtDiaChi.Text
                );
            return kh;
        }
        void load_Value()
        {
            BLL_KhachHangCaNhan busKH = new BLL_KhachHangCaNhan();
            BLL_LoadValue busValue = new BLL_LoadValue();
            DTO_ChiTietKHCN ctKH = busKH.LayGiaTri(id);
            txtCif.Text = ctKH.Id.ToString();
            txtTenDayDu.Text = ctKH.TenKhachHang;
            dtNgaySinh.Value = ctKH.NgaySinh;
            string[] arr = ctKH.DiaChi.Split(',');
            txtDuong.Text = arr[0].Trim();
            txtPhuong.Text = arr[1].Trim();
            cbThanhPho.Text = arr[2].Trim();
            txtSDT.Text = ctKH.Sdt;
            cbQuocGia.Text = ctKH.QuocGia;
            cbQuocTich.Text = ctKH.QuocTich;
            cbLoaiGiayTo.Text = ctKH.LoaiGiayTo;
            txtSoGiayTo.Text = ctKH.SoGiayTo;
            txtNoiCap.Text = ctKH.NoiCap;
            dtNgayCap.Value = ctKH.NgayCap;
            dtNgayHetHan.Value = (DateTime)ctKH.NgayHetHan;
            txtEmai.Text = ctKH.Email;
            cbNganhChinh.Text = busValue.LayTenNganhChinh(ctKH.NganhChinh);
            cbNganh.Text = busValue.LayTenNganh(ctKH.Nganh);
            cbNhanVien.Text = busValue.LayTenNV(ctKH.NhanVienLV);
            cbGioiTInh.Text = ctKH.GioiTinh;
            cbXungHo.Text = ctKH.XungHo;
            cbTTHonNhan.Text = ctKH.TTHonNhan;
            cbMaQH.Text = ctKH.QuanHe;
            txtSoVP.Text = ctKH.SoVanPhong;
            txtSoNguoi.Text = ctKH.SoNguoiPT.ToString();
            cbNha.Text = ctKH.SoHuuNha;
            cbCuTru.Text = ctKH.LHCuChu;
            cbTTViecLam.Text = ctKH.TinhTrangViecLam;
            txtCTY.Text = ctKH.TenCty;
            txtThuNhap.Text = ctKH.ThuNhapHangThang.ToString();
            txtDiaChi.Text = ctKH.DiaChiCty;
        }
        /// <summary>
        /// Hàm sự kiện khi frmMain nhấn button save thì hàm này chạy
        /// </summary>
        /// <param name="form"></param>
        public void SetMainForm(frm_Main form)
        {
            if (form_Main != null)
            {
                form_Main.OnSaveButtonClick -= MainForm_OnSaveButtonClick;
            }
            form_Main = form;
            form_Main.OnSaveButtonClick += MainForm_OnSaveButtonClick;
        }
        private void MainForm_OnSaveButtonClick(object sender, EventArgs e)
        {
            // Thực hiện xử lý khi nút Save trên frm_Main được bấm
            BLL_KhachHangCaNhan busKhachHang = new BLL_KhachHangCaNhan();
            int nganhChinh = Convert.ToInt32(cbNganhChinh.SelectedValue);
            int nganh = Convert.ToInt32(cbNganh.SelectedValue);
            string nv = cbNhanVien.SelectedValue.ToString();
            DTO_ChiTietKHCN dtoKH = new DTO_ChiTietKHCN(
                    int.Parse(txtCif.Text),  // Truyền id vào đây
                    txtTenDayDu.Text,
                    txtDuong.Text + ", " + txtPhuong.Text + ", " + cbThanhPho.Text,
                    txtSDT.Text,
                    cbQuocGia.Text,
                    cbQuocTich.Text,
                    cbLoaiGiayTo.Text,
                    txtSoGiayTo.Text,
                    txtNoiCap.Text,
                    txtEmai.Text,
                    nganhChinh,
                    nganh,
                    nv,
                    dtNgaySinh.Value,
                    dtNgayCap.Value,
                    dtNgayHetHan.Value,
                    cbGioiTInh.Text,
                    cbXungHo.Text,
                    cbTTHonNhan.Text,
                    cbMaQH.Text,
                    txtSoVP.Text,
                    int.Parse(txtSoNguoi.Text),
                    cbNha.Text,
                    cbCuTru.Text,
                    cbTTViecLam.Text,
                    txtCTY.Text,
                    double.Parse(txtThuNhap.Text),
                    txtDiaChi.Text
                );
            busKhachHang.Sua(dtoKH);
        }
        /// <summary>
        /// Hàm sự kiện khi frmMain nhấn button save thì hàm này chạy
        /// </summary>
        /// <param name="frm"></param>
        public void Enabled_Control(frm_Main frm)
        {
            form_Main = frm;
            form_Main.OnSaveButtonClick += Enabled_OnSaveButtonClick;
        }

        private void Enabled_OnSaveButtonClick(object sender, EventArgs e)
        {
            foreach (Control control in tabPage1.Controls)
            {
                txtCif.Enabled = true;
                if (control is TextBox || control is DateTimePicker || control is ComboBox || control is MaskedTextBox)
                {
                    control.Enabled = true;
                }
            }
            foreach (Control control in tabPage2.Controls)
            {
                if (control is TextBox || control is DateTimePicker || control is ComboBox || control is MaskedTextBox)
                {
                    control.Enabled = true;
                }
            }
        }

        public void Remove_Customer(frm_Main frm)
        {
            form_Main = frm;
            form_Main.OnRemoveButtonClick += Remove_Customer_OnremoveButtonClick;
        }
        public void Remove_Customer_OnremoveButtonClick(object sender, EventArgs e)
        {
            BLL_KhachHangCaNhan busKH = new BLL_KhachHangCaNhan();
            busKH.Xoa(id);
        }

        private void cbNganhChinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            BLL_LoadValue load = new BLL_LoadValue();
            cbNganh.DataSource = load.XemNganh(Convert.ToInt32(cbNganhChinh.SelectedValue));
            cbNganh.DisplayMember = "TenNganh";
            cbNganh.ValueMember = "IdNganh";
        }

    }
}
