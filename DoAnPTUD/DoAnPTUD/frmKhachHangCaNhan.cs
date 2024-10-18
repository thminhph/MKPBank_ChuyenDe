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
using DTO;
using BUS;

namespace DoAnPTUD
{
    public partial class frmKhachHangCaNhan : Form
    {
        string conn;
        int id;
        public frmKhachHangCaNhan(string conn)
        {
            this.conn = conn;
            InitializeComponent();
            loadCIF();
            writerCIF();
            txtHo.Leave += Txt_Leave;
            txtTen.Leave += Txt_Leave;
            loadComboBox();
        }
        public frmKhachHangCaNhan(string conn, int id)
        {
            this.conn = conn;
            this.id = id;
            InitializeComponent();
            loadCIF();
            writerCIF();
            txtHo.Leave += Txt_Leave;
            txtTen.Leave += Txt_Leave;
            loadComboBox();
            load_Value();
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
            BUS_LoadValue load = new BUS_LoadValue();
            cbNganhChinh.DataSource = load.XemNganhChinh(conn);
            cbNganhChinh.DisplayMember = "TenNganh";
            cbNganhChinh.ValueMember = "IdNganhChinh";
            cbNganh.DataSource = load.XemNganh(conn);
            cbNganh.DisplayMember = "TenNganh";
            cbNganh.ValueMember = "IdNganh";
            cbNhanVien.DataSource = load.XemNhanVien(conn);
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
                    mktSDT.Text,
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
            BUS_KhachHangCaNhan busKH = new BUS_KhachHangCaNhan();
            BUS_LoadValue busValue = new BUS_LoadValue();
            DTO_ChiTietKHCN ctKH = busKH.LayGiaTri(id, conn);
            txtCif.Text = ctKH.Id.ToString();
            txtTenDayDu.Text = ctKH.TenKhachHang;
            dtNgaySinh.Value = ctKH.NgaySinh;
            string[] arr = ctKH.DiaChi.Split(',');
            txtDuong.Text = arr[0].Trim();
            txtPhuong.Text = arr[1].Trim();
            cbThanhPho.Text = arr[2].Trim();
            mktSDT.Text = ctKH.Sdt;
            cbQuocGia.Text = ctKH.QuocGia;
            cbQuocTich.Text = ctKH.QuocTich;
            cbLoaiGiayTo.Text = ctKH.LoaiGiayTo;
            txtSoGiayTo.Text = ctKH.SoGiayTo;
            txtNoiCap.Text = ctKH.NoiCap;
            dtNgayCap.Value = ctKH.NgayCap;
            dtNgayHetHan.Value = (DateTime)ctKH.NgayHetHan;
            txtEmai.Text = ctKH.Email;
            cbNganhChinh.Text = busValue.LayTenNganhChinh(ctKH.NganhChinh, conn);
            cbNganh.Text = busValue.LayTenNganh(ctKH.Nganh, conn);
            cbNhanVien.Text = busValue.LayTenNV(conn, ctKH.NhanVienLV);
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
    }
}
