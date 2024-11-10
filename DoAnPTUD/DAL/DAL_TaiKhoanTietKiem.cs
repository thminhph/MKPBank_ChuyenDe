using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TaiKhoanTietKiem
    {
        Data_Context db;
        public DAL_TaiKhoanTietKiem()
        {
            this.db = new Data_Context();
        }
        public void ThemTaiKhoanTietKiem(DTO_TaiKhoanTietKiem tk)
        {
            try
            {
                TaiKhoanTietKiem tktk = new TaiKhoanTietKiem
                {
                    IdTaiKhoanTK = tk.IdTaiKhoanTK,
                    IdKhachHang = tk.IdKhachHang,
                    IdLoaiTK = tk.IdLoaiTK,
                    TieuDeTK = tk.TieuDeTK,
                    TienTe = tk.TienTe,
                    SoTienNap = tk.SoTienNap,
                    NgayGiaTri = tk.NgayGiaTri,
                    ThoiHan = tk.ThoiHan,
                    LaiSuat = tk.LaiSuat,
                    IdTaiKhoan = tk.IdTaiKhoan,
                    NgayDaoHan = tk.NgayDaoHan,
                };
                db.Db.TaiKhoanTietKiems.InsertOnSubmit(tktk);
                db.Db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new InvalidOperationException("Thêm thất bại" + ex.Message);
            }
        }
    }
}
