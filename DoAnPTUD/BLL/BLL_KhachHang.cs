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
        public DTO_KhachHang LayGiaTriKHCaNhan(int id)
        {
            return dalKH.LayGiaTriKHCaNhan(id);
        }
        public void ThemKHCaNhan(DTO_KhachHang kh)
        {
            dalKH.ThemKHCaNhan(kh);
        }
        public DataTable InDanhSachKhCaNhan()
        {
            return dalKH.InDanhSachKhCaNhan();
        }
        public void SuaKhCaNhan(DTO_KhachHang kh)
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
        }

        public IQueryable HienThiDSTaiKhoanTheoKH(int? idKH)
        {
            return dalKH.HienThiDSTaiKhoanTheoKH(idKH);
        }
        public void ThamGiaTK(long idTK, int idKH, string noiDung)
        {
            dalKH.ThamGiaTK(idTK, idKH, noiDung);
        }
    }
}
