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
    public partial class frm_MoTaiKhoan : Form
    {
        long id;
        private frm_Main form_Main;
        public frm_MoTaiKhoan()
        {
            InitializeComponent();
            loadID();
            writerID();
            loadComboBox();
        }
        public frm_MoTaiKhoan(long id)
        {
            InitializeComponent();
            loadID();
            writerID();
            loadComboBox();
            this.id = id;
            LoadTaiKhoan();
            Enabled_Control();
        }
        void writerID()
        {
            try
            {
                using (StreamWriter file = new StreamWriter("ID.txt", false))
                {
                    file.WriteLine(txtIdTaiKhoan.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đọc file thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        void loadID()
        {
            try
            {
                using (StreamReader file = new StreamReader("ID.txt"))
                {
                    string str = file.ReadToEnd();
                    txtIdTaiKhoan.Text = (long.Parse(str) + 13).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đọc file thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void Enabled_Control()
        {
            if (id == long.Parse(txtIdTaiKhoan.Text))
            {
                txtIdTaiKhoan.Enabled = false;
                foreach (Control control in Controls)
                {
                    if (control is TextBox || control is DateTimePicker || control is ComboBox || control is MaskedTextBox)
                    {
                        control.Enabled = false;
                    }
                }
            }
        }
        void LoadTaiKhoan()
        {
            BLL_LoadValue load = new BLL_LoadValue();
            DTO_TaiKhoan tk = load.LayThongTinTK(id);
            txtIdTaiKhoan.Text = tk.IdTaiKhoan.ToString();
            cbKhachHang.SelectedValue = tk.IdKhachHang;
            cbLoai.SelectedValue = tk.LoaiTaiKhoan;
            cbTienTe.Text = tk.TienTe;
            txtTieuDeTK.Text = tk.TieuDeTK;
            txtTenVietTat.Text = tk.TieuDeNgan;
            cbNV.SelectedValue = tk.NhanVienLV;
            cbPhi.Text = tk.PhiMa;
        }
        void loadComboBox()
        {
            BLL_LoadValue loadV = new BLL_LoadValue();
            cbKhachHang.DataSource = loadV.HienThiDanhSachKH();
            cbKhachHang.DisplayMember = "TenKhachHang"; // Thuộc tính cần hiển thị
            cbKhachHang.ValueMember = "IdKhachHang"; // Giá trị ẩn
            cbNV.DataSource = loadV.XemNhanVien();
            cbNV.DisplayMember = "HoTen";
            cbNV.ValueMember = "IdNhanVien";
            cbLoai.DataSource = loadV.XemDSLoaiTK();
            cbLoai.DisplayMember = "TenLoai";
            cbLoai.ValueMember = "IdLoai";
        }
        int loaiKH = 0;
        private void cbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbKhachHang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbKhachHang.AutoCompleteSource = AutoCompleteSource.ListItems;
            if (cbKhachHang.SelectedItem is DTO_KhachHang selectKhachHang)
            {
                loaiKH = selectKhachHang.IdLoaiKH; ;
            }
        }
        public DTO_TaiKhoan ThemTaiKhoan()
        {
            if (loaiKH == 1)
            {
                return new DTO_TaiKhoan(
                    long.Parse(txtIdTaiKhoan.Text),
                    Convert.ToInt32(cbKhachHang.SelectedValue),
                    Convert.ToInt32(cbLoai.SelectedValue),
                    cbTienTe.Text,
                    txtTieuDeTK.Text,
                    txtTenVietTat.Text,
                    cbNV.SelectedValue.ToString(),
                    cbPhi.Text,
                    "@KHCN123");
            }
            if (loaiKH == 2)
            {
                return new DTO_TaiKhoan(
                    long.Parse(txtIdTaiKhoan.Text),
                    Convert.ToInt32(cbKhachHang.SelectedValue),
                    Convert.ToInt32(cbLoai.SelectedValue),
                    cbTienTe.Text,
                    txtTieuDeTK.Text,
                    txtTenVietTat.Text,
                    cbNV.SelectedValue.ToString(),
                    cbPhi.Text,
                    "@KHDN123");
            }
            return null;
        }
        public void Enabled_Control(frm_Main frm)
        {
            form_Main = frm;
            form_Main.OnSaveButtonClick += Enabled_OnSaveButtonClick;
        }

        private void Enabled_OnSaveButtonClick(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                txtIdTaiKhoan.Enabled = true;
                if (control is TextBox || control is DateTimePicker || control is ComboBox || control is MaskedTextBox)
                {
                    control.Enabled = true;
                }
            }
            cbKhachHang.Enabled = false;
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
            BLL_TaiKhoan tk = new BLL_TaiKhoan();
            // Thực hiện xử lý khi nút Save trên frm_Main được bấm
            DTO_TaiKhoan dt = new DTO_TaiKhoan(
                    long.Parse(txtIdTaiKhoan.Text),
                    Convert.ToInt32(cbLoai.SelectedValue),
                    cbTienTe.Text,
                    txtTieuDeTK.Text,
                    txtTenVietTat.Text,
                    cbNV.SelectedValue.ToString(),
                    cbPhi.Text);
            tk.SuaTK(dt);
        }
    }
}
