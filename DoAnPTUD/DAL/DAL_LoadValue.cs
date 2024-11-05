using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LoadValue
    {
        Data_Context dContext;
        public IQueryable XemNganhChinh()
        {
            dContext = new Data_Context();
            var xem = dContext.Db.NganhChinhs.Select(n => n);
            return xem;
        }
        public IQueryable XemNganh(int maNganhChinh)
        {
            dContext = new Data_Context();
            var xem = dContext.Db.Nganhs
                .Where(n => n.IdNganhChinh == maNganhChinh)
                .Select(n => n);
            return xem;
        }
        public IQueryable XemNhanVien()
        {
            dContext = new Data_Context();
            var xem = dContext.Db.NhanViens.Select(n => n);
            return xem;
        }
        public string LayTenNV(string idNV)
        {
            dContext = new Data_Context();
            var xem = dContext.Db.NhanViens
                .Where(nv => nv.IdNhanVien == idNV)
                .Select(n => new
                {
                    ten = n.HoTen
                }).ToList();
            if (xem.Any())
            {
                return xem[0].ten;
            }
            else
            {
                return null;
            }
        }
        public string LayTenNganhChinh(int id)
        {
            dContext = new Data_Context();
            var xem = dContext.Db.NganhChinhs
                .Where(n => n.IdNganhChinh == id)
                .Select(n => new
                {
                    tenNganh = n.TenNganh
                }).ToList();
            if (xem.Any())
            {
                return xem[0].tenNganh;
            }
            else
            {
                return null;
            }
        }
        public string LayTenNganh(int id)
        {
            dContext = new Data_Context();
            var xem = dContext.Db.Nganhs
                .Where(n => n.IdNganh == id)
                .Select(n => new
                {
                    tenNganh = n.TenNganh
                }).ToList();
            if (xem.Any())
            {
                return xem[0].tenNganh;
            }
            else
            {
                return null;
            }
        }
        public IQueryable InDSKhachHang(string[] arr)
        {
            dContext = new Data_Context();
            // Đồng bộ các thuộc tính bằng cách sử dụng tên chung
            var khCaNhan = dContext.Db.KhachHangCaNhans
                .Select(kh => new
                {
                    IdKhachHang = kh.IdKhachHangCN, // Đổi tên thành IdKhachHang
                    Loai = "Cá nhân",
                    Ten = kh.TenKhachHang, // Đổi tên thành Ten
                    kh.SoGiayTo,
                    kh.SoDienThoai,
                    kh.NganhChinh,
                    kh.IdNganh
                });

            var khDoanhNghiep = dContext.Db.KhachHangDoanhNghieps
                .Select(kh => new
                {
                    IdKhachHang = kh.IdKhachHangDN, // Đổi tên thành IdKhachHang
                    Loai = "Doanh Nghiệp",
                    Ten = kh.TenDayDuDN, // Đổi tên thành Ten
                    kh.SoGiayTo,
                    kh.SoDienThoai,
                    kh.NganhChinh,
                    kh.IdNganh
                });

            var xem = khCaNhan
                .Union(khDoanhNghiep)
                .Where(x =>
                (string.IsNullOrEmpty(arr[0]) || x.IdKhachHang == int.Parse(arr[0])) &&
                (string.IsNullOrEmpty(arr[1]) || x.Loai == arr[1]));
            //(string.IsNullOrEmpty(arr[2]) || x.SoDienThoai == arr[2])));
            //(string.IsNullOrEmpty(arr[3]) || x.Ten == arr[3]) &&
            //(string.IsNullOrEmpty(arr[4]) || x.SoGiayTo == arr[4]) &&
            //(string.IsNullOrEmpty(arr[5]) || x.NganhChinh == int.Parse(arr[5])) &&
            //(string.IsNullOrEmpty(arr[6]) || x.NganhChinh == int.Parse(arr[6]))));
            return xem.AsQueryable();
        }
    }
}
