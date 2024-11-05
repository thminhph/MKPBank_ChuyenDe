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
        public event Action<int> OnRowSelected; // Sự kiện tùy chỉnh để truyền ID hoặc giá trị khác
        public frm_DanhSach(string flag)
        {
            InitializeComponent();
            this.flag = flag;
            load_List();
        }
        void load_List()
        {
            switch (flag)
            {
                case "Mở khách hàng cá nhân":
                    BLL_KhachHang kh = new BLL_KhachHang();
                    dgvDanhSach.DataSource = kh.InDanhSach();
                    this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDanhSach_CellContentClick);
                    break;
                case "Mở khách hàng doanh nghiệp":
                    BLL_KhachHang khDN = new BLL_KhachHang();
                    //dgvDanhSach.DataSource = khDN.LayDuLieu();
                    this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDanhSach_CellContentClick);
                    break;
                default:
                    break;
            }
            string str = flag;
            if (str == flag)
            {

            }

        }

        private void DgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int viTri = e.RowIndex;
            if (viTri >= 0) // Đảm bảo không phải dòng tiêu đề
            {
                DataGridViewRow row = dgvDanhSach.Rows[viTri];
                int id = Convert.ToInt32(row.Cells[0].Value); // Lấy ID hoặc giá trị cần truyền

                // Gọi sự kiện tùy chỉnh và truyền giá trị
                OnRowSelected?.Invoke(id);

                this.Close(); // Đóng form frm_DanhSach sau khi chọn dòng
            }
        }
    }
}
