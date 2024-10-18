using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LoadValue
    {
        Data_Context dContext;
        public IQueryable XemNganhChinh(string conn)
        {
            dContext = new Data_Context(conn);
            var xem = dContext.Db.NganhChinhs.Select(n => n);
            return xem;
        }
        public IQueryable XemNganh(string conn)
        {
            dContext = new Data_Context(conn);
            var xem = dContext.Db.Nganhs.Select(n => n);
            return xem;
        }
        public IQueryable XemNhanVien(string conn)
        {
            dContext = new Data_Context(conn);
            var xem = dContext.Db.NhanViens.Select(n => n);
            return xem;
        }
        public string LayTenNV(string conn, string idNV)
        {
            dContext = new Data_Context(conn);
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
        public string LayTenNganhChinh(int id, string conn)
        {
            dContext = new Data_Context(conn);
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
        public string LayTenNganh(int id, string conn)
        {
            dContext = new Data_Context(conn);
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
    }
}
