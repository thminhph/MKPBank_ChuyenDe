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
    public class BLL_KhachHangDoanhNghiep
    {
        DAL_KhachHangDoanhNghiep dalDoanhNghiep = new DAL_KhachHangDoanhNghiep();
        public void Them(DTO_KhachHangDoanhNghiep kh)
        {
            dalDoanhNghiep.Them(kh);
        }
        public void ThemChiTiet(DTO_ChiTietKHDN kh)
        {
            dalDoanhNghiep.ThemChiTiet(kh);
        }
        public DTO_ChiTietKHDN LayGiaTri(int id)
        {
            return dalDoanhNghiep.LayGiaTri(id);
        }
        public DataTable LayDuLieu()
        {
            return dalDoanhNghiep.LayDuLieu();
        }
        public void Sua(DTO_ChiTietKHDN kh)
        {
            dalDoanhNghiep.Sua(kh);
        }
        public void Xoa(int id)
        {
            dalDoanhNghiep.Xoa(id);
        }
    }
}
