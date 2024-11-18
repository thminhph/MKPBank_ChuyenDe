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
        public long timid(string nc)
        {
            var qr = from s in db.TaiKhoans
                     where s.IdTaiKhoan == long.Parse(nc)
                     select new
                     {
                         s.IdTaiKhoan,
                     };
            foreach (var s in qr)
            {
                return s.IdTaiKhoan;
            }
            return 0;
        }
        public bool giaoDichsdt(string nc, string nn, decimal sotien, string diengia)
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
        public bool giaoDich(string nc, string nn, decimal sotien, string diengia)
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
                     where s.SoTien >= decimal.Parse(sotiens) && s.SoTien <= decimal.Parse(sotiene)
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
                     where s.SoTien == decimal.Parse(ng)
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
        public void naptien(string ng, decimal sotien)
        {
            var khchuyen = db.TaiKhoans.FirstOrDefault(kh => kh.IdTaiKhoan == long.Parse(ng));
            ////var tknguoichuyen = db.TaiKhoans.FirstOrDefault();

            //var tknguoinhan = db.TaiKhoans.FirstOrDefault();


            khchuyen.SoDuTinDung.SoDuTK += sotien;


            ChiTietGD chiTiet = new ChiTietGD
            {
                SoTKNguoiChuyen = khchuyen.IdTaiKhoan,
                SoTien = sotien,
                NgayGio = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
            };
            db.ChiTietGDs.InsertOnSubmit(chiTiet);
            db.SubmitChanges();
            Console.WriteLine("Giao Dịch Thành Công");
        }

        public string laytenNN(long soTKNguoiNhan)
        {
            var khachHang = db.TaiKhoans
                .Where(tk => tk.IdTaiKhoan == soTKNguoiNhan)
                .Select(tk => tk.KhachHang.TenKhachHang)
                .FirstOrDefault();

            return khachHang;
        }

        public DataTable LayChiTietGD()
        {
            var lay = db.ChiTietGDs
      .OrderByDescending(gd => gd.NgayGio)
      .Select(gd => new
      {
          magd = gd.MaGD,
          tenKhachHang = gd.TaiKhoan.KhachHang.TenKhachHang,
          tenKhachNhan = laytenNN(gd.SoTKNguoiNhan),
          SotkNguoiNhan = gd.SoTKNguoiNhan,
          sotien = gd.SoTien,
          ngaygio = gd.NgayGio,
          noidung = gd.DienGia
      }).FirstOrDefault();

            DataTable data = new DataTable();
            data.Columns.Add("MaGD", typeof(long));
            data.Columns.Add("TenKhachHangChuyen", typeof(string));
            data.Columns.Add("TenKhachHangNhan", typeof(string));
            data.Columns.Add("SoTKNguoiNhan", typeof(long));
            data.Columns.Add("SoTien", typeof(decimal));
            data.Columns.Add("NgayGio", typeof(DateTime));
            data.Columns.Add("DienGia", typeof(string));

            if (lay != null)
            {
                data.Rows.Add(lay.magd, lay.tenKhachHang, lay.tenKhachNhan, lay.SotkNguoiNhan, lay.sotien, lay.ngaygio, lay.noidung);
            }

            return data;
        }
        //public DataTable SaoKeTienVao(long id, DateTime tuNgay, DateTime denNgay)
        //{
        //    var chiTietGD = from ct in db.ChiTietGDs
        //                    select new
        //                    {
        //                        TenNguoiNhan = ct.TaiKhoan.KhachHang.TenKhachHang,
        //                        SoTien = ct.SoTien,
        //                        Ngay = ct.NgayGio,
        //                        NoiDung = ct.DienGia,
        //                        LoaiTK = ct.TaiKhoan.LoaiTaiKhoan.TenLoai,
        //                        Id = ct.SoTKNguoiNhan
        //                    };
        //    var guiTienMat = from gt in db.GUITIENMATs
        //                     select new
        //                     {
        //                         TenNguoiNhan = gt.TaiKhoan.KhachHang.TenKhachHang,
        //                         SoTien = (decimal)gt.SoGiaoDich,
        //                         Ngay = (DateTime)gt.NgayGiaoDich,
        //                         NoiDung = gt.NoiDung,
        //                         LoaiTK = gt.TaiKhoan.LoaiTaiKhoan.TenLoai,
        //                         Id = (long)gt.IdTaiKhoan
        //                     };
        //    var tienVao = guiTienMat.Union(chiTietGD)
        //        .Where(tv => tv.Id == id || (tv.Ngay == tuNgay && tv.Ngay == denNgay));
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("TenNguoiNhan");
        //    dt.Columns.Add("SoTien");
        //    dt.Columns.Add("Ngay");
        //    dt.Columns.Add("NoiDung");
        //    dt.Columns.Add("LoaiTK");
        //    dt.Columns.Add("Id");
        //    foreach (var item in tienVao)
        //    {
        //        dt.Rows.Add(item.TenNguoiNhan, item.SoTien, item.Ngay, item.NoiDung, item.LoaiTK, item.Id);

        //    }
        //    return dt;

        //}
        public DataTable SaoKeToanBoGiaoDich(long id, DateTime tuNgay, DateTime denNgay)
        {
            // Lấy dữ liệu từ bảng ChiTietGDs
            var chiTietGD = from ct in db.ChiTietGDs
                            select new
                            {
                                TenNguoiNhan = ct.TaiKhoan.KhachHang.TenKhachHang,
                                SoTien = ct.SoTien,
                                Ngay = ct.NgayGio.Date,
                                NoiDung = ct.DienGia,
                                LoaiTK = ct.TaiKhoan.LoaiTaiKhoan.TenLoai,
                                Id = ct.SoTKNguoiChuyen
                            };

            // Lấy dữ liệu từ bảng GUITIENMATs
            var guiTienMat = from gt in db.GiaoDiches
                             select new
                             {
                                 TenNguoiNhan = gt.TaiKhoan.KhachHang.TenKhachHang,
                                 SoTien = (decimal)gt.SoGiaoDich,
                                 Ngay = gt.NgayGiaoDich.Value.Date,
                                 NoiDung = gt.NoiDung,
                                 LoaiTK = gt.TaiKhoan.LoaiTaiKhoan.TenLoai,
                                 Id = (long)gt.IdTaiKhoan
                             };

            // Hợp nhất dữ liệu từ hai bảng
            var tienVao = guiTienMat.Union(chiTietGD)
             .Where(tv => tv.Id == id  && ( tv.Ngay >= tuNgay.Date && tv.Ngay <= denNgay.Date));
            // Tạo DataTable và thêm cột
            DataTable dt = new DataTable();
            dt.Columns.Add("TenNguoiNhan");
            dt.Columns.Add("SoTien");
            dt.Columns.Add("Ngay",typeof(DateTime));
            dt.Columns.Add("NoiDung");
            dt.Columns.Add("LoaiTK");
            dt.Columns.Add("Id");

            // Thêm dữ liệu từ truy vấn vào DataTable
            foreach (var item in tienVao)
            {
                dt.Rows.Add(item.TenNguoiNhan, item.SoTien, item.Ngay, item.NoiDung, item.LoaiTK, item.Id);
            }

            return dt;
        }

    }
}
