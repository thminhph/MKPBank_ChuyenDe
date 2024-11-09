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
        public List<DTO_KhachHang> HienThiDanhSachKH()
        {
            dContext = new Data_Context();
            var xem = dContext.Db.KhachHangs
                .Select(kh => new DTO_KhachHang
                {
                    IdKhachHang = kh.IdKhachHang,
                    TenKhachHang = kh.TenKhachHang,
                    IdLoaiKH = (int)kh.IdLoaiKH,
                })
                .ToList();
            return xem;
        }
        public IQueryable HienThiDanhSachKH(Dictionary<string, string> whereArg)
        {
            dContext = new Data_Context();
            // Đồng bộ các thuộc tính bằng cách sử dụng tên chung
            var xem = from kh in dContext.Db.KhachHangs
                      select new
                      {
                          kh.IdKhachHang,
                          kh.IdLoaiKH,
                          kh.TenKhachHang,
                          kh.SoGiayTo,
                          kh.SoDienThoai,
                          kh.NganhChinh,
                          kh.IdNganh
                      };
            //var xem = khCaNhan
            //    .Union(khDoanhNghiep);
            foreach (var item in whereArg)
            {
                switch (item.Key)
                {
                    case "Loai":
                        xem = xem.Where(kh => (int)kh.IdLoaiKH == int.Parse(item.Value));
                        break;
                    case "IdKhachHang":
                        xem = xem.Where(kh => kh.IdKhachHang == int.Parse(item.Value));
                        break;
                    case "Ten":
                        xem = xem.Where(kh => kh.TenKhachHang == item.Value);
                        break;
                    case "SoGiayTo":
                        xem = xem.Where(kh => kh.SoGiayTo == item.Value);
                        break;
                    case "SoDienThoai":
                        xem = xem.Where(kh => kh.SoDienThoai == item.Value);
                        break;
                    case "NganhChinh":
                        xem = xem.Where(kh => kh.NganhChinh == Convert.ToInt32(item.Value));
                        break;
                    case "IdNganh":
                        xem = xem.Where(kh => kh.IdNganh == Convert.ToInt32(item.Value));
                        break;
                }
            }
            return xem;
        }
        public IQueryable XemDSLoaiTK()
        {
            dContext = new Data_Context();
            return dContext.Db.LoaiTaiKhoans.Select(l => l);
        }

        public List<string> LayThongTinKhachHang(long id)
        {
            dContext = new Data_Context();
            var xem = (from kh in dContext.Db.KhachHangs
                      join tk in dContext.Db.TaiKhoans
                      on kh.IdKhachHang equals tk.IdKhachHang
                      where tk.IdTaiKhoan == id
                      select new
                      {
                          kh.IdKhachHang,
                          kh.TenKhachHang,
                          tk.TenTaiKhoan,
                          tk.TienTe,
                          tk.SoDuTinDung.SoDuTK
                      }).FirstOrDefault();
            if (xem != null)
            {
                List<string> list = new List<string>();
                list.Add(xem.IdKhachHang.ToString());
                list.Add(xem.TenKhachHang);
                list.Add(xem.TenTaiKhoan);
                list.Add(xem.TienTe);
                list.Add(xem.SoDuTK.ToString());
                return list;
            }
            
            return null;
        }
    }
}
