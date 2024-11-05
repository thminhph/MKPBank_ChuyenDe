using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        //public List<DTO_KhachHang> HienThiDanhSachKH()
        //{
        //    dContext = new Data_Context();
        //    //Đồng bộ các thuộc tính bằng cách sử dụng tên chung
        //    //var khCaNhan = dContext.Db.KhachHangs
        //    //    .Select(kh => new DTO_KhachHang
        //    //    {
        //    //        IdKhachHang = kh.IdKhachHang,
        //    //        Loai = "Cá nhân",
        //    //        Ten = kh.TenKhachHang,
        //    //        SoGiayTo = kh.SoGiayTo,
        //    //        SoDienThoai = kh.SoDienThoai,
        //    //        NganhChinh = kh.NganhChinh,
        //    //        IdNganh = kh.IdNganh,
        //    //        MaTen = kh.IdKhachHang + "-" + kh.TenKhachHang
        //    //    });

        //    //var khDoanhNghiep = dContext.Db.KhachHangs
        //    //    .Select(kh => new DTO_KhachHang
        //    //    {
        //    //        IdKhachHang = kh.IdKhachHang, // Đổi tên thành IdKhachHang
        //    //        Loai = "Doanh Nghiệp",
        //    //        Ten = kh.TenDayDuDN, // Đổi tên thành Ten
        //    //        SoGiayTo = kh.SoGiayTo,
        //    //        SoDienThoai = kh.SoDienThoai,
        //    //        NganhChinh = kh.NganhChinh,
        //    //        IdNganh = kh.IdNganh,
        //    //        MaTen = kh.IdKhachHangDN + "-" + kh.TenDayDuDN
        //    //    });

        //    //var xem = khCaNhan
        //    //    .Union(khDoanhNghiep)
        //    //    .ToList();
        //    return xem;
        //}
        public List<DTO_KhachHang> HienThiDanhSachKH(Dictionary<string, string> whereArg)
        {
            dContext = new Data_Context();
            // Đồng bộ các thuộc tính bằng cách sử dụng tên chung
            var khCaNhan = dContext.Db.KhachHangs
                .Select(kh => new DTO_KhachHang
                {
                    IdKhachHang = kh.IdKhachHang,
                    //Loai = "Cá nhân",
                    //Ten = kh.TenKhachHang,
                    SoGiayTo = kh.SoGiayTo,
                    SoDienThoai = kh.SoDienThoai,
                    NganhChinh = kh.NganhChinh,
                    IdNganh = kh.IdNganh,
                });

            var khDoanhNghiep = dContext.Db.KhachHangs
                .Select(kh => new DTO_KhachHang
                {
                    IdKhachHang = kh.IdKhachHang, // Đổi tên thành IdKhachHang
                    //Loai = "Doanh Nghiệp",
                    //Ten = kh.TenDayDuDN, // Đổi tên thành Ten
                    SoGiayTo = kh.SoGiayTo,
                    SoDienThoai = kh.SoDienThoai,
                    NganhChinh = kh.NganhChinh,
                    IdNganh = kh.IdNganh,
                });
            //var conditionsMet = whereArg.All(item => {
            //    return item.Key == item.Value; });
            var xem = khCaNhan
                .Union(khDoanhNghiep);
            //foreach (var item in whereArg)
            //{
            //    switch (item.Key)
            //    {
            //        case "Loai":
            //            xem = xem.Where(kh => kh.loai == item.Value);
            //            break;
            //        case "IdKhachHang":
            //            xem = xem.Where(kh => kh.IdKhachHang == int.Parse(item.Value));
            //            break;
            //        case "Ten":
            //            xem = xem.Where(kh => kh.Ten == item.Value);
            //            break;
            //        case "SoGiayTo":
            //            xem = xem.Where(kh => kh.SoGiayTo == item.Value);
            //            break;
            //        case "SoDienThoai":
            //            xem = xem.Where(kh => kh.SoDienThoai == item.Value);
            //            break;
            //        case "NganhChinh":
            //            xem = xem.Where(kh => kh.NganhChinh == Convert.ToInt32(item.Value));
            //            break;
            //        case "IdNganh":
            //            xem = xem.Where(kh => kh.IdNganh == Convert.ToInt32(item.Value));
            //            break;
            //    }
            //} 
            
            //foreach (var item in whereArg)
            //{
            //    if (true)
            //    {

            //    }
            //


            return xem.ToList();
        }
        public Func<bool, bool, bool> GetLogicalOperator(string op)
        {
            switch (op)
            {
                case "&&":
                    return (a, b) => a && b; // Logical AND
                case "||":
                    return (a, b) => a || b; // Logical OR
                default:
                    throw new ArgumentException("Invalid operator");
            }
        }
    }
}
