using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BLL_LoadValue
    {
        DAL_LoadValue load = new DAL_LoadValue();
        public IQueryable XemNganhChinh()
        {
            return load.XemNganhChinh();
        }
        public IQueryable XemNganh(int maNganhChinh)
        {
            return load.XemNganh(maNganhChinh);
        }
        public IQueryable XemNhanVien()
        {
            return load.XemNhanVien();
        }
        public string LayTenNganhChinh(int id)
        {
            return load.LayTenNganhChinh(id);
        }
        public string LayTenNganh(int id)
        {
            return load.LayTenNganh(id);
        }
        public string LayTenNV(string idNV)
        {
            return load.LayTenNV(idNV);
        }
        public List<DTO_KhachHang> HienThiDanhSachKH()
        {
            return load.HienThiDanhSachKH();
        }
        public List<DTO_KhachHang> HienThiDanhSachKH(Dictionary<string, string> whereArg)
        {
            return load.HienThiDanhSachKH(whereArg);
        }
    }
}
