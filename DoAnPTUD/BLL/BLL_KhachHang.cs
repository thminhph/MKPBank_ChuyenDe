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
        {
            kh.Them(khachHang);
        }
        public void ThemChiTiet(DTO_ChiTietKHCN khachHang)
        {
            kh.ThemChiTiet(khachHang);
        }
        public DataTable InDanhSach()
        {
            return kh.InDanhSach();
        }
        public DTO_ChiTietKHCN LayGiaTri(int id)
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
        }
    }
}
