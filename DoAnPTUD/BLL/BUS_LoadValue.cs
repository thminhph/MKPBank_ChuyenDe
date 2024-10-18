using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_LoadValue
    {
        DAL_LoadValue load = new DAL_LoadValue();
        public IQueryable XemNganhChinh(string conn)
        {
            return load.XemNganhChinh(conn);
        }
        public IQueryable XemNganh(string conn)
        {
            return load.XemNganh(conn);
        }
        public IQueryable XemNhanVien(string conn)
        {
            return load.XemNhanVien(conn);
        }
        public string LayTenNganhChinh(int id, string conn)
        {
            return load.LayTenNganhChinh(id, conn);
        }
        public string LayTenNganh(int id, string conn)
        {
            return load.LayTenNganh(id, conn);
        }
        public string LayTenNV(string conn, string idNV)
        {
            return load.LayTenNV(conn, idNV);
        }
    }
}
