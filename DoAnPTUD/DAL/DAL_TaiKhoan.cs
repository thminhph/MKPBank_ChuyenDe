using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Collections;


namespace DAL
{
    public class DAL_TaiKhoan
    {
        
        
        private QLNganHangDataContext  db;

        public DAL_TaiKhoan()
        {
            this.db = new QLNganHangDataContext(Properties.Settings.Default.QLNganHangConnectionString);
        }
        public IQueryable layDSTaiKhoan()
        {
            IQueryable taiKhoan = from s in db.TaiKhoans
                                   select new
                                   {
                                       s.IdTaiKhoan,
                                       s.MaKhachHang,
                                       s.LoaiTaiKhoan,
                                       s.TenTaiKhoan,
                                       s.TienTe,
                                       s.TieuDeTK,
                                       s.TieuDeNgan,
                                       s.NhanVienLV,
                                       s.PhiMa,
                                       s.Matkhau
                                   };
            return taiKhoan;
        }

        public IQueryable DangNhap(char sDT )
        {
            IQueryable temp = from s in db.KhachHangCaNhans
                              join tk in db.TaiKhoans on s.IdKhachHangCN equals tk.MaKhachHang
                              where s.SoDienThoai.CompareTo(sDT) == 0
                              select tk;
            return temp;

        }
    }
}
