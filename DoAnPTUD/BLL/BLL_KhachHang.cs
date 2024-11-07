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

        DAL_KhachHang kh = new DAL_KhachHang();
        public void Them(DTO_KhachHang khachHang)

        DAL_KhachHang dalKH = new DAL_KhachHang();
        public DTO_KhachHang LayGiaTriKHCaNhan(int id)

        {
            kh.Them(khachHang);
        }

        public void ThemChiTiet(DTO_ChiTietKHCN khachHang)

        public void ThemKHCaNhan(DTO_KhachHang kh)
        {
            kh.ThemChiTiet(khachHang);
        }
        public DataTable InDanhSach()
        {
            return kh.InDanhSach();
        }
        public DTO_ChiTietKHCN LayGiaTri(int id)
        public void SuaKhCaNhan(DTO_KhachHang kh)
        {
            return kh.LayGiaTri(id);
        }
        public void Sua(DTO_ChiTietKHCN khachHang)
        {
            kh.Sua(khachHang);
        }
        public void Xoa(int id)
        {
            kh.Xoa(id);
            return dalKH.LayDuLieuKHDoanhNghiep();
        }

        public void ThemKHDoanhNghiep(DTO_KhachHang kh)
        {
            dalKH.ThemKHDoanhNghiep(kh);
        }
        public DTO_KhachHang LayGiaTriKHDoanhNghiep(int id)
        {
            return dalKH.LayGiaTriKHDoanhNghiep(id);
        }
        public void SuaKHDoanhNghiep(DTO_KhachHang kh)
        {
            dalKH.SuaKHDoanhNghiep(kh);
        }

        public void XoaKHDoanhNghiep(int id)
        {
            dalKH.XoaKHDoanhNghiep(id);
>>>>>>> Kiet4
        }
    }
}
