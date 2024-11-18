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
                TaiKhoan tktk = new TaiKhoan
                {
                    IdTaiKhoan = tk.IdTaiKhoan,
                    IdKhachHang = tk.MaKhachHang,
                    IdLoai = tk.IdLoai,
                    TieuDeTK = tk.TieuDeTK,
                    TienTe = tk.TienTe,
                    TieuDeNgan = tk.TieuDeNgan,
                    NhanVienLV = tk.NhanVienLV,
                    Matkhau = tk.Matkhau,
                    IdTaiKhoanLV = tk.IdTaiKhoanLV,
                };
                db.Db.TaiKhoans.InsertOnSubmit(tktk);
                db.Db.SubmitChanges();
                // Kiểm tra IdTaiKhoan đã được tạo
                if (tktk.IdTaiKhoan <= 0)
                {
                    throw new InvalidOperationException("IdTaiKhoan không được tạo đúng.");
                }

                // Chèn SoDuTinDung với IdTaiKhoan vừa tạo
                SoDuTinDung sd = new SoDuTinDung
                {
                    IdTaiKhoan = tk.IdTaiKhoan, // Khóa ngoại từ TaiKhoan
                    SoDuTK = tk.SoDu,
                    NgayGiaTri = tk.NgayGiaTri,
                    NgayDaoHan = tk.NgayDaoHan,
                    LaiSuat = tk.LaiSuat,
                };

                db.Db.SoDuTinDungs.InsertOnSubmit(sd);
                db.Db.SubmitChanges();
            }
            catch
            {

                throw new InvalidOperationException("Thêm thất bại");
            }
        }

        public void TinhLaiTietKiem(long idTaiKhoan)
        {
            var tinhLai = from tk in db.Db.TaiKhoans
                          where tk.IdTaiKhoan == idTaiKhoan && tk.SoDuTinDung.NgayDaoHan == new DateTime(2025, 01, 16)
                          select tk;
            var sua = tinhLai.FirstOrDefault();
            int tongNgay = (sua.SoDuTinDung.NgayDaoHan.Value - sua.SoDuTinDung.NgayGiaTri.Value).Days;
            sua.TaiKhoan1.SoDuTinDung.SoDuTK += Math.Floor((decimal)sua.SoDuTinDung.SoDuTK * (decimal)sua.SoDuTinDung.LaiSuat * tongNgay / 365);
            db.Db.SubmitChanges();
        }
        public List<long> LayTatCaMa()
        {
            var list = (from tk in db.Db.TaiKhoans
                       where tk.IdLoai == 3
                       select new
                       {
                           tk.IdTaiKhoan
                       }).ToList();
            List<long> l = new List<long>();
            foreach (var item in list)
            {
                l.Add(item.IdTaiKhoan);
            }
            return l;
        }
    }
}
