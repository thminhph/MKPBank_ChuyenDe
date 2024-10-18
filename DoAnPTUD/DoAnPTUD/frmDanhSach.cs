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
    public partial class frmDanhSach : Form
    {
        string conn, flag;
        public event Action<int> OnRowSelected; // Sự kiện tùy chỉnh để truyền ID hoặc giá trị khác
        public frmDanhSach(string flag, string conn)
        {
            InitializeComponent();
            this.conn = conn;
            this.flag = flag;
            load_List();
        }
        void load_List()
        {
            string str = flag;
            if (str == flag)
            {
                BUS_KhachHangCaNhan kh = new BUS_KhachHangCaNhan();
                dgvDanhSach.DataSource = kh.InDanhSach(conn);
                dgvDanhSach.CellContentClick += DgvDanhSach_CellContentClick;
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
