using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_KhachHangCaNhan
    {
        DAL_KhachHangCaNhan kh = new DAL_KhachHangCaNhan();
        public void Them(DTO_KhachHangCaNhan khachHang, string conn)
        {
            kh.Them(khachHang, conn);
        }
        public void ThemChiTiet(DTO_ChiTietKHCN khachHang, string conn)
        {
            kh.ThemChiTiet(khachHang, conn);
        }
        public DataTable InDanhSach(string conn)
        {
            return kh.InDanhSach(conn);
        }
        public DTO_ChiTietKHCN LayGiaTri(int id, string conn)
        {
            return kh.LayGiaTri(id, conn);
        }
    }
}
