using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_ChiTietGiaoDich
    {
        private QLNganHangDataContext db;
        public DAL_ChiTietGiaoDich()
        {
            this.db = new QLNganHangDataContext(Properties.Settings.Default.QLNganHangConnectionString);
        }
        public IQueryable laydsCTGD(string  userId)
        {
            IQueryable gd = from s in db.ChiTietGDs
                            where s.SoTKNguoiChuyen == long.Parse(userId) || s.SoTKNguoiNhan == long.Parse(userId)
                            select new
                            {
                                s.MaGD,
                                s.SoTKNguoiChuyen,
                                s.SoTKNguoiNhan,
                                s.NgayGio,
                                s.DienGia
                            };
            return gd;
        }
        public IQueryable laydsCTGDNhan(string userId)
        {
            IQueryable gd = from s in db.ChiTietGDs
                            join tk in db.TaiKhoans on s.SoTKNguoiChuyen equals tk.IdTaiKhoan
                            where s.SoTKNguoiNhan == long.Parse(userId)
                            select new
                            {
                                s.MaGD,
                                s.SoTKNguoiChuyen,
                                s.SoTKNguoiNhan,
                                s.NgayGio,
                                s.DienGia
                            };
            return gd;
        }
        public IQueryable laydsCTGDChuyen(string userId)
        {
            IQueryable gd = from s in db.ChiTietGDs
                            join tk in db.TaiKhoans on s.SoTKNguoiChuyen equals tk.IdTaiKhoan
                            where s.SoTKNguoiChuyen == long.Parse(userId)
                            select new
                            {
                                s.MaGD,
                                s.SoTKNguoiChuyen,
                                s.SoTKNguoiNhan,
                                s.NgayGio,
                                s.DienGia
                            };
            return gd;
        }
        public DTO_ThongTinKH tim(string  tk)
        {
            var qr = (from s in db.KhachHangs
                      join b in db.TaiKhoans on s.IdKhachHang equals b.IdKhachHang
                      where b.IdTaiKhoan == long.Parse(tk)
                      select new DTO_ThongTinKH
                      {
                         TenKhachHang= s.TenKhachHang
                      }).FirstOrDefault();
           

            return qr;
        }
        public long timMa(DateTime tk)
        {
            var qr = from s in db.ChiTietGDs
                     join b in db.TaiKhoans on s.SoTKNguoiChuyen equals b.IdTaiKhoan
                     where s.NgayGio == DateTime.Parse(tk.ToString("yyyy-MM-dd HH:mm:ss.000"))
                     select new
                     {
                         s.MaGD
                     };
            foreach (var s in qr)
            {
                return s.MaGD;
            }

            return 0;
        }

        public bool giaoDich(string  nc, string nn, float sotien, string diengia)
        {

            var khchuyen = db.TaiKhoans.FirstOrDefault(kh => kh.IdTaiKhoan == long.Parse(nc));
            ////var tknguoichuyen = db.TaiKhoans.FirstOrDefault();
            var khnhan = db.TaiKhoans.FirstOrDefault(kh => kh.IdTaiKhoan == long.Parse(nn));
            ////var tknguoinhan = db.TaiKhoans.FirstOrDefault();

            if (khchuyen.SoDuTinDung.SoDuTK.Value >= sotien)
            {
                khchuyen.SoDuTinDung.SoDuTK -= sotien;
                khnhan.SoDuTinDung.SoDuTK += sotien;

                ChiTietGD chiTiet = new ChiTietGD
                {
                    SoTKNguoiChuyen = khchuyen.IdTaiKhoan,
                    SoTKNguoiNhan = khnhan.IdTaiKhoan,
                    SoTien = sotien,
                    NgayGio = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                    DienGia = diengia
                };
                db.ChiTietGDs.InsertOnSubmit(chiTiet);
                db.SubmitChanges();
                Console.WriteLine("Giao Dịch Thành Công");
                return true;
            }
            else
            {
                Console.WriteLine("Giao Dịch Thất Bại ");
            }
            return false;

        }
    }
}
