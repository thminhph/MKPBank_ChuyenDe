using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_TaiKhoanTietKiem
    {
        DAL_TaiKhoanTietKiem dalTK = new DAL_TaiKhoanTietKiem();
        public void ThemTaiKhoanTietKiem(DTO_TaiKhoanTietKiem tk)
        {
            dalTK.ThemTaiKhoanTietKiem(tk);
        }
        public void TinhLaiTietKiem(long idTaiKhoan)
        {
            dalTK.TinhLaiTietKiem(idTaiKhoan);
        }
        public List<long> LayTatCaMa()
        {
            return dalTK.LayTatCaMa();
        }
    }
}
