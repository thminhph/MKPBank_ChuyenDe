using BLL;
using BUS;
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
    public partial class frm_DanhSach : Form
    {
        string flag;
        public event Action<string> OnRowSelected; // Sự kiện tùy chỉnh để truyền ID hoặc giá trị khác
        public frm_DanhSach(string flag)
        {
            InitializeComponent();
            this.flag = flag;
            load_List();
        }
        void load_List()
        {
            BLL_KhachHang kh = new BLL_KhachHang();
            BLL_LoadValue load = new BLL_LoadValue();
            switch (flag)
            {
                case "Mở khách hàng cá nhân":
                    dgvDanhSach.DataSource = kh.InDanhSachKhCaNhan();
                    this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDanhSach_CellContentClick);
                    break;
                case "Mở khách hàng doanh nghiệp":
                    dgvDanhSach.DataSource = kh.LayDuLieuKHDoanhNghiep();
                    this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDanhSach_CellContentClick);
                    break;
                case "Mở tài khoản":
                    dgvDanhSach.DataSource = load.DanhSachTaiKhoan();
                    this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDanhSach_CellContentClick);
                    break;
                case "Tiền gửi tiền mặt":
                    dgvDanhSach.DataSource = load.XemGuiTienMat();
                    this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDanhSach_CellContentClick);
                    break;
                case "Rút tiền mặt":
                    dgvDanhSach.DataSource = load.DanhSachRutTien();
                    this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDanhSach_CellContentClick);
                    break;
            }
        }

        private void DgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int viTri = e.RowIndex;
            if (viTri >= 0) // Đảm bảo không phải dòng tiêu đề
            {
                DataGridViewRow row = dgvDanhSach.Rows[viTri];

                string id = row.Cells[0].Value.ToString(); // Lấy ID hoặc giá trị cần truyền

                // Gọi sự kiện tùy chỉnh và truyền giá trị
                OnRowSelected?.Invoke(id);

                this.Close(); // Đóng form frm_DanhSach sau khi chọn dòng
            }
        }
    }
}
