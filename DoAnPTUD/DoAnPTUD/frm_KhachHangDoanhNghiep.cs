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
    public partial class frm_KhachHangDoanhNghiep : Form
    {
        int id;
        private frm_Main form_Main;
        public frm_KhachHangDoanhNghiep()
        {
            InitializeComponent();
            loadCIF();
            writerCIF();
            loadComboBox();

        }
        public frm_KhachHangDoanhNghiep(int id)
        {
            this.id = id;
            InitializeComponent();
            loadCIF();
            writerCIF();
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
        public DTO_KhachHang KhachHang()
        {
            int nganhChinh = Convert.ToInt32(cbNganhChinh.SelectedValue);
            int nganh = Convert.ToInt32(cbNganh.SelectedValue);
            string nv = cbNhanVien.SelectedValue.ToString();
            DTO_KhachHang kh = new DTO_KhachHang(
                    int.Parse(txtCif.Text),  // Truyền id vào đây
                    txtTenCty.Text,
                    new byte[0],
                    dtNgayThanhLap.Value,
                    txtDuong.Text + ", " + txtPhuong.Text + ", " + cbThanhPho.Text,
                    txtSDT.Text,
                    cbQuocGia.Text,
                    cbQuocTich.Text,
                    cbLoaiGiayTo.Text,
                    txtSoGiayTo.Text,
                    dtNgayCap.Value,
                    dtNgayHetHan.Value,
                    txtNoiCap.Text,
                    txtEmail.Text,
                    nganhChinh,
                    nganh,
                    nv,
                    3);
            return kh;
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
        private void cbNganhChinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            BLL_LoadValue load = new BLL_LoadValue();
            cbNganh.DataSource = load.XemNganh(Convert.ToInt32(cbNganhChinh.SelectedValue));
            cbNganh.DisplayMember = "TenNganh";
            cbNganh.ValueMember = "IdNganh";
        }
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
        void load_Value()
        {
            BLL_KhachHang busKH = new BLL_KhachHang();
            BLL_LoadValue busValue = new BLL_LoadValue();
            DTO_KhachHang ctKH = busKH.LayGiaTriKHDoanhNghiep(id);
            txtCif.Text = ctKH.IdKhachHang.ToString();
            txtTenCty.Text = ctKH.TenKhachHang;
            dtNgayThanhLap.Value = ctKH.NgaySinh;
            string[] arr = ctKH.DiaChi.Split(',');
            txtDuong.Text = arr[0].Trim();
            txtPhuong.Text = arr[1].Trim();
            cbThanhPho.Text = arr[2].Trim();
            txtSDT.Text = ctKH.SoDienThoai;
            cbQuocGia.Text = ctKH.QuocGia;
            cbQuocTich.Text = ctKH.QuocTich;
            cbLoaiGiayTo.Text = ctKH.LoaiGiayTo;
            txtSoGiayTo.Text = ctKH.SoGiayTo;
            txtNoiCap.Text = ctKH.NoiCap;
            dtNgayCap.Value = ctKH.NgayCap;
            dtNgayHetHan.Value = (DateTime)ctKH.NgayHetHan;
            txtEmail.Text = ctKH.Email;
            cbNganhChinh.Text = busValue.LayTenNganhChinh(ctKH.NganhChinh);
            cbNganh.Text = busValue.LayTenNganh(ctKH.IdNganh);
            cbNhanVien.Text = busValue.LayTenNV(ctKH.NhanVienLV);
        }
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
            BLL_KhachHang busKhachHang = new BLL_KhachHang();
            int nganhChinh = Convert.ToInt32(cbNganhChinh.SelectedValue);
            int nganh = Convert.ToInt32(cbNganh.SelectedValue);
            string nv = cbNhanVien.SelectedValue.ToString();
            DTO_KhachHang kh = new DTO_KhachHang(
                    int.Parse(txtCif.Text),  // Truyền id vào đây
                    txtTenCty.Text,
                    new byte[0],
                    dtNgayThanhLap.Value,
                    txtDuong.Text + ", " + txtPhuong.Text + ", " + cbThanhPho.Text,
                    txtSDT.Text,
                    cbQuocGia.Text,
                    cbQuocTich.Text,
                    cbLoaiGiayTo.Text,
                    txtSoGiayTo.Text,
                    dtNgayCap.Value,
                    dtNgayHetHan.Value,
                    txtNoiCap.Text,
                    txtEmail.Text,
                    nganhChinh,
                    nganh,
                    nv,
                    3);
            busKhachHang.SuaKHDoanhNghiep(kh);
        }
        public void Remove_Customer(frm_Main frm)
        {
            form_Main = frm;
            form_Main.OnRemoveButtonClick += Remove_Customer_OnremoveButtonClick;
        }
        public void Remove_Customer_OnremoveButtonClick(object sender, EventArgs e)
        {
            BLL_KhachHang busKH = new BLL_KhachHang();
            busKH.XoaKhCaNhan(id);
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (!long.TryParse(txtSDT.Text, out _))
            {
                MessageBox.Show("Nội dung nhập không phải là số vui lòng nhập lại", "Thông báo");
                txtSDT.Focus();
            }
        }

        private void txtSoGiayTo_Leave(object sender, EventArgs e)
        {
            if (!long.TryParse(txtSoGiayTo.Text, out _))
            {
                MessageBox.Show("Nội dung nhập không phải là số vui lòng nhập lại", "Thông báo");
                txtSoGiayTo.Focus();
            }
        }
    }
}
