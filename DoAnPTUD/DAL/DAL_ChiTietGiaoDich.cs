using System;
using System.Collections.Generic;
using System.Data;
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
        public IQueryable laydsCTGD(string userId)
        {
            IQueryable gd = from s in db.ChiTietGDs
                            where s.SoTKNguoiChuyen == long.Parse(userId) || s.SoTKNguoiNhan == long.Parse(userId)
                            select new
                            {
                                s.MaGD,
                                s.SoTKNguoiChuyen,
                                s.SoTKNguoiNhan,
                                s.SoTien,
                                s.NgayGio,
                                s.DienGia
                            };
            return gd;
        }
        public IQueryable laydsCTGDNhan(string userId)
        {
            IQueryable gd = from s in db.ChiTietGDs
                            where s.SoTKNguoiNhan == long.Parse(userId)
                            select new
                            {
                                s.MaGD,
                                s.SoTKNguoiChuyen,
                                s.SoTKNguoiNhan,
                                s.SoTien,
                                s.NgayGio,
                                s.DienGia
                            };
            return gd;
        }
        public IQueryable laydsCTGDChuyen(string userId)
        {
            IQueryable gd = from s in db.ChiTietGDs
                            where s.SoTKNguoiChuyen == long.Parse(userId)
                            select new
                            {
                                s.MaGD,
                                s.SoTKNguoiChuyen,
                                s.SoTKNguoiNhan,
                                s.SoTien,
                                s.NgayGio,
                                s.DienGia
                            };
            return gd;
        }
        public string timsdt(string tk)
        {
            var qr = (from s in db.KhachHangs
                      join b in db.TaiKhoans on s.IdKhachHang equals b.IdKhachHang
                      where s.SoDienThoai == tk
                      select new
                      {
                          s.TenKhachHang
                      }).ToList();
            foreach (var s in qr)
            {
                return s.TenKhachHang;
            }

            return null;
        }
        public DTO_ThongTinKH tim(string tk)
        {
            var qr = (from s in db.KhachHangs
                      join b in db.TaiKhoans on s.IdKhachHang equals b.IdKhachHang
                      where b.IdTaiKhoan == long.Parse(tk)
                      select new DTO_ThongTinKH
                      {
                          TenKhachHang = s.TenKhachHang
                      }).FirstOrDefault();


            return qr;
        }
        public long timMa(DateTime tk)
        {
            var qr = from s in db.ChiTietGDs
                     join b in db.TaiKhoans on s.SoTKNguoiChuyen equals b.IdTaiKhoan
                     where s.NgayGio == DateTime.Parse(tk.ToString("yyyy-MM-dd HH:mm:ss"))
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
        public bool giaoDichsdt(string nc, string nn, float sotien, string diengia)
        {

            var khchuyen = db.TaiKhoans.FirstOrDefault(kh => kh.IdTaiKhoan == long.Parse(nc));
            var khnhan = db.KhachHangs.FirstOrDefault(kh => kh.SoDienThoai == nn);
            var tknguoinhan = khnhan?.TaiKhoans.FirstOrDefault();

            if (khchuyen.SoDuTinDung.SoDuTK.Value >= sotien)
            {
                khchuyen.SoDuTinDung.SoDuTK -= sotien;
                tknguoinhan.SoDuTinDung.SoDuTK += sotien;

                ChiTietGD chiTiet = new ChiTietGD
                {
                    SoTKNguoiChuyen = khchuyen.IdTaiKhoan,
                    SoTKNguoiNhan = tknguoinhan.IdTaiKhoan,
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
        public bool giaoDich(string nc, string nn, float sotien, string diengia)
        {

            var khchuyen = db.TaiKhoans.FirstOrDefault(kh => kh.IdTaiKhoan == long.Parse(nc));
            ////var tknguoichuyen = db.TaiKhoans.FirstOrDefault();
            var khnhan = db.TaiKhoans.FirstOrDefault(kh => kh.IdTaiKhoan == long.Parse(nn));
            //var tknguoinhan = db.TaiKhoans.FirstOrDefault();

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
        public IQueryable timtheosotien(string sotiens, string sotiene)
        {
            var qr = from s in db.ChiTietGDs
                     where s.SoTien >= float.Parse(sotiens) && s.SoTien <= float.Parse(sotiene)
                     select new
                     {
                         s.MaGD,
                         s.SoTKNguoiChuyen,
                         s.SoTKNguoiNhan,
                         s.SoTien,
                         s.NgayGio,
                         s.DienGia
                     };
            return qr;
        }
        public IQueryable timtheongay(DateTime ngaybd, DateTime ngaykt)
        {
            var qr = from s in db.ChiTietGDs
                     where s.NgayGio.Date >= ngaybd.Date && s.NgayGio.Date <= ngaykt.Date
                     select new
                     {
                         s.MaGD,
                         s.SoTKNguoiChuyen,
                         s.SoTKNguoiNhan,
                         s.SoTien,
                         s.NgayGio,
                         s.DienGia
                     };
            return qr;
        }
        public IQueryable timtheodungngay(DateTime ng)
        {
            var qr = from s in db.ChiTietGDs
                     where s.NgayGio.Day == ng.Day
                     select new
                     {
                         s.MaGD,
                         s.SoTKNguoiChuyen,
                         s.SoTKNguoiNhan,
                         s.SoTien,
                         s.NgayGio,
                         s.DienGia
                     };
            return qr;
        }
        public IQueryable timtheodungtien(string ng)
        {
            var qr = from s in db.ChiTietGDs
                     where s.SoTien == float.Parse(ng)
                     select new
                     {
                         s.MaGD,
                         s.SoTKNguoiChuyen,
                         s.SoTKNguoiNhan,
                         s.SoTien,
                         s.NgayGio,
                         s.DienGia
                     };
            return qr;
        }


    }
}
