using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_KhachHang
    {
        DAL_KhachHang dalKH = new DAL_KhachHang();
        public DTO_ChiTietKHCN LayGiaTriKHCaNhan(int id)
        {
            return dalKH.LayGiaTriKHCaNhan(id);
        }
        public void ThemKHCaNhan(DTO_ChiTietKHCN kh)
        {
            dalKH.ThemKHCaNhan(kh);
        }
        public DataTable InDanhSachKhCaNhan()
        {
            return dalKH.InDanhSachKhCaNhan();
        }
        public void SuaKhCaNhan(DTO_ChiTietKHCN kh)
        {
            dalKH.SuaKhCaNhan(kh);
        }
        public void XoaKhCaNhan(int id)
        {
            dalKH.XoaKhCaNhan(id);
        }


        //Khách hàng doanh nghiệp
        public DataTable LayDuLieuKHDoanhNghiep()
        {
            return dalKH.LayDuLieuKHDoanhNghiep();
        }

        public void ThemKHDoanhNghiep(DTO_ChiTietKHDN kh)
        {
            dalKH.ThemKHDoanhNghiep(kh);
        }
        public DTO_ChiTietKHDN LayGiaTriKHDoanhNghiep(int id)
        {
            return dalKH.LayGiaTriKHDoanhNghiep(id);
        }
        public void SuaKHDoanhNghiep(DTO_ChiTietKHDN kh)
        {
            dalKH.SuaKHDoanhNghiep(kh);
        }

        public void XoaKHDoanhNghiep(int id)
        {
            dalKH.XoaKHDoanhNghiep(id);
        }
    }
}
