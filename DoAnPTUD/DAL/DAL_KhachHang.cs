using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DAL
{
    public class DAL_KhachHang
    {
        Data_Context dContext;

        public IQueryable XemKhachHangCaNhan()
        {
            dContext = new Data_Context();
            var xem = dContext.Db.KhachHangs.Select(kh => kh);
            return xem;
        }
        public DTO_KhachHang LayGiaTriKHCaNhan(int id)
        {
            dContext = new Data_Context();

            // Retrieve the customer details based on the provided ID
            var khachHang = (from kh in dContext.Db.KhachHangs
                             where kh.IdKhachHang == id // Use the parameter id
                             select kh).FirstOrDefault(); // Directly get the first matching record or null

            // Check if a customer was found
            if (khachHang != null)
            {
                // Create and return the DTO_KhachHang object
                DTO_KhachHang kh = new DTO_KhachHang();
                kh.IdKhachHang = khachHang.IdKhachHang;
                kh.TenKhachHang = khachHang.TenKhachHang;
                //kh.Avarta = khachHang.Avarta.ToArray();
                kh.NgaySinh = khachHang.NgaySinh;
                kh.DiaChi = khachHang.DiaChi;
                kh.SoDienThoai = khachHang.SoDienThoai;
                kh.QuocGia = khachHang.QuocGia;
                kh.QuocTich = khachHang.QuocTich;
                kh.LoaiGiayTo = khachHang.LoaiGiayTo;
                kh.SoGiayTo = khachHang.SoGiayTo;
                kh.NgayCap = khachHang.NgayCap;
                kh.NgayHetHan = (DateTime)khachHang.NgayHetHan;
                kh.NoiCap = khachHang.NoiCap;
                kh.Email = khachHang.Email;
                kh.NganhChinh = khachHang.NganhChinh;
                kh.IdNganh = khachHang.IdNganh;
                kh.NhanVienLV = khachHang.NhanVienLV;
                kh.IdLoaiKH = (int)khachHang.IdLoaiKH;
                return kh;
            }

            // Return null if no record was found
            return null;
        }

        public void ThemKHCaNhan(DTO_KhachHang kh)
        {
            dContext = new Data_Context();
            try
            {
                KhachHang khachHang = new KhachHang
                {
                    IdKhachHang = kh.IdKhachHang,
                    DiaChi = kh.DiaChi,
                    Email = kh.Email,
                    LoaiGiayTo = kh.LoaiGiayTo,
                    IdNganh = kh.IdNganh,
                    NgayCap = kh.NgayCap,
                    NganhChinh = kh.NganhChinh,
                    NgaySinh = kh.NgaySinh,
                    NgayHetHan = kh.NgayHetHan,
                    QuocGia = string.IsNullOrEmpty(kh.QuocGia) ? null : kh.QuocGia,
                    NoiCap = kh.NoiCap,
                    SoDienThoai = string.IsNullOrEmpty(kh.SoDienThoai) ? null : kh.SoDienThoai,
                    QuocTich = string.IsNullOrEmpty(kh.QuocTich) ? null : kh.QuocTich,
                    TenKhachHang = kh.TenKhachHang,
                    NhanVienLV = string.IsNullOrEmpty(kh.NhanVienLV) ? null : kh.NhanVienLV,
                    SoGiayTo = kh.SoGiayTo,
                    IdLoaiKH = kh.IdLoaiKH
                };
                dContext.Db.KhachHangs.InsertOnSubmit(khachHang);

            }
            finally
            {
                dContext.Db.SubmitChanges();
            }
        }
        public DataTable InDanhSachKhCaNhan()
        {
            dContext = new Data_Context();
            var xem = dContext.Db.KhachHangs
                .Where(k => k.IdLoaiKH == 1)
            .Join(dContext.Db.NganhChinhs,
                  khachHang => khachHang.NganhChinh,
                  n => n.IdNganhChinh,
                  (khachHang, n) => new
                  {
                      Id = khachHang.IdKhachHang,
                      Ten = khachHang.TenKhachHang,
                      DiaChi = khachHang.DiaChi,
                      QuocTich = khachHang.QuocTich,
                      Nganhcn = n.TenNganh,
                      SoGiayTo = khachHang.SoGiayTo
                  })
            .AsEnumerable() // Chuyển đổi sang kiểu IEnumerable để xử lý chuỗi trong C#
            .Select(x => new
            {
                x.Id,
                x.Ten,
                DiaChi = x.DiaChi.Split(',').Length > 2 ? x.DiaChi.Split(',')[2].Trim() : string.Empty,
                x.QuocTich,
                x.Nganhcn,
                x.SoGiayTo
            });
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã khách hàng");
            dt.Columns.Add("Tên khách hàng");
            dt.Columns.Add("Thành phố/Tỉnh");
            dt.Columns.Add("Quốc tịch");
            dt.Columns.Add("Ngành công nghiệp chính");
            dt.Columns.Add("Số giấy tờ");
            foreach (var item in xem)
            {
                dt.Rows.Add(item.Id, item.Ten, item.DiaChi, item.QuocTich, item.Nganhcn, item.SoGiayTo);
            }
            return dt;
        }
        public void SuaKhCaNhan(DTO_KhachHang kh)
        {
            dContext = new Data_Context();
            var sua = dContext.Db.KhachHangs.Single(khachHang => khachHang.IdKhachHang == kh.IdKhachHang);
            sua.TenKhachHang = kh.TenKhachHang;
            sua.DiaChi = kh.DiaChi;
            sua.SoDienThoai = kh.SoDienThoai;
            sua.QuocGia = kh.QuocGia;
            sua.QuocTich = kh.QuocTich;
            sua.LoaiGiayTo = kh.LoaiGiayTo;
            sua.NoiCap = kh.NoiCap;
            sua.NgayCap = kh.NgayCap;
            sua.NgayHetHan = kh.NgayHetHan;
            sua.Email = kh.Email;
            sua.NganhChinh = kh.NganhChinh;
            sua.IdNganh = kh.IdNganh;
            sua.NhanVienLV = kh.NhanVienLV;
            dContext.Db.SubmitChanges();
        }
        public void XoaKhCaNhan(int id)
        {
            dContext = new Data_Context();
            var xoa = dContext.Db.KhachHangs
                .Where(kh => kh.IdKhachHang == id)
                .Select(kh => kh);
            foreach (var item in xoa)
            {
                dContext.Db.KhachHangs.DeleteOnSubmit(item);
            }
            dContext.Db.SubmitChanges();
        }


        //Khách hàng doanh nghiệp
        public DataTable LayDuLieuKHDoanhNghiep()
        {
            dContext = new Data_Context();
            var xem = dContext.Db.KhachHangs
                .Where(kh => kh.IdLoaiKH == 2)
                .Join(dContext.Db.NganhChinhs,
                kh => kh.NganhChinh,
                n => n.IdNganhChinh,
                (kh, n) => new
                {
                    id = kh.IdKhachHang,
                    ten = kh.TenKhachHang,
                    tp = kh.DiaChi,
                    quocTich = kh.QuocTich,
                    nganh = n.TenNganh,
                    soGiayTo = kh.SoGiayTo
                })
                .AsEnumerable()
                .Select(x => new
                {
                    x.id,
                    x.ten,
                    DiaChi = x.tp.Split(',').Length > 2 ? x.tp.Split(',')[2].Trim() : string.Empty,
                    x.quocTich,
                    x.nganh,
                    x.soGiayTo
                });
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã khách hàng");
            dt.Columns.Add("Tên khách hàng");
            dt.Columns.Add("Thành phố/Tỉnh");
            dt.Columns.Add("Quốc tịch");
            dt.Columns.Add("Ngành công nghiệp chính");
            dt.Columns.Add("Số giấy tờ");
            foreach (var item in xem)
            {
                dt.Rows.Add(item.id, item.ten, item.DiaChi, item.quocTich, item.nganh, item.soGiayTo);
            }
            return dt;
        }
        public void ThemKHDoanhNghiep(DTO_KhachHang kh)
        {
            dContext = new Data_Context();
            try
            {
                // Tạo đối tượng KhachHangDoanhNghiep mới từ dữ liệu của BUS_KhachHangDoanhNghiep
                KhachHang khachHangDN = new KhachHang
                {
                    IdKhachHang = kh.IdKhachHang,
                    TenKhachHang = kh.TenKhachHang,
                    NgaySinh = kh.NgaySinh,
                    DiaChi = kh.DiaChi,
                    QuocGia = string.IsNullOrEmpty(kh.QuocGia) ? null : kh.QuocGia,
                    QuocTich = string.IsNullOrEmpty(kh.QuocTich) ? null : kh.QuocTich,
                    LoaiGiayTo = kh.LoaiGiayTo,
                    SoGiayTo = kh.SoGiayTo,
                    NgayCap = kh.NgayCap,
                    NgayHetHan = kh.NgayHetHan,
                    NoiCap = kh.NoiCap,
                    Email = string.IsNullOrEmpty(kh.Email) ? null : kh.Email,
                    SoDienThoai = string.IsNullOrEmpty(kh.SoDienThoai) ? null : kh.SoDienThoai,
                    NganhChinh = kh.NganhChinh,
                    IdNganh = kh.IdNganh,
                    NhanVienLV = kh.NhanVienLV,
                    IdLoaiKH = kh.IdLoaiKH,
                };

                // Thêm đối tượng vào cơ sở dữ liệu
                dContext.Db.KhachHangs.InsertOnSubmit(khachHangDN);
                dContext.Db.SubmitChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }
        public DTO_KhachHang LayGiaTriKHDoanhNghiep(int id)
        {
            dContext = new Data_Context();
            // Retrieve the customer details based on the provided ID
            var khachHang = (from kh in dContext.Db.KhachHangs
                             where kh.IdKhachHang == id // Use the parameter id
                             select kh).FirstOrDefault(); // Directly get the first matching record or null

            // Check if a customer was found
            if (khachHang != null)
            {
                // Create and return the DTO_KhachHang object
                DTO_KhachHang kh = new DTO_KhachHang();
                kh.IdKhachHang = khachHang.IdKhachHang;
                kh.TenKhachHang = khachHang.TenKhachHang;
                //kh.Avarta = khachHang.Avarta.ToArray();
                kh.NgaySinh = khachHang.NgaySinh;
                kh.DiaChi = khachHang.DiaChi;
                kh.SoDienThoai = khachHang.SoDienThoai;
                kh.QuocGia = khachHang.QuocGia;
                kh.QuocTich = khachHang.QuocTich;
                kh.LoaiGiayTo = khachHang.LoaiGiayTo;
                kh.SoGiayTo = khachHang.SoGiayTo;
                kh.NgayCap = khachHang.NgayCap;
                kh.NgayHetHan = (DateTime)khachHang.NgayHetHan;
                kh.NoiCap = khachHang.NoiCap;
                kh.Email = khachHang.Email;
                kh.NganhChinh = khachHang.NganhChinh;
                kh.IdNganh = khachHang.IdNganh;
                kh.NhanVienLV = khachHang.NhanVienLV;
                kh.IdLoaiKH = (int)khachHang.IdLoaiKH;
                return kh;
            }
            return null;
        }
        public void SuaKHDoanhNghiep(DTO_KhachHang kh)
        {
            dContext = new Data_Context();
            try
            {
                // Tìm đối tượng KhachHangDoanhNghiep cần sửa
                var sua = dContext.Db.KhachHangs.Single(khachHang => khachHang.IdNganh == kh.IdKhachHang);
                sua.TenKhachHang = kh.TenKhachHang;
                sua.NgaySinh = kh.NgaySinh;
                sua.DiaChi = kh.DiaChi;
                sua.QuocGia = kh.QuocGia;
                sua.QuocTich = kh.QuocTich;
                sua.LoaiGiayTo = kh.LoaiGiayTo;
                sua.SoGiayTo = kh.SoGiayTo;
                sua.NgayCap = kh.NgayCap;
                sua.NgayHetHan = kh.NgayHetHan;
                sua.NoiCap = kh.NoiCap;
                sua.Email = kh.Email;
                sua.SoDienThoai = kh.SoDienThoai;
                sua.NganhChinh = kh.NganhChinh;
                sua.IdNganh = kh.IdNganh;
                sua.NhanVienLV = kh.NhanVienLV;

                // Lưu thay đổi vào cơ sở dữ liệu
                dContext.Db.SubmitChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }
        public void XoaKHDoanhNghiep(int id)
        {
            dContext = new Data_Context();
            var xoa = dContext.Db.KhachHangs
                .Where(kh => kh.IdKhachHang == id)
                .Select(kh => kh);
            foreach (var item in xoa)
            {
                dContext.Db.KhachHangs.DeleteOnSubmit(item);
            }
            dContext.Db.SubmitChanges();
        }
    }
}
