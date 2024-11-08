using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_TaiKhoan
    {
        private DAL_TaiKhoan taiKhoan = new DAL_TaiKhoan();

        public DTO_ThongTinKH tim(string  stk)
        {
            return taiKhoan.timUserTheostk(stk);
        }

        public DTO_TaiKhoan dangNhap(string sdt, string mK)
        {
           return taiKhoan.DangNhap(sdt, mK);
        }

        //public DTO_ThongTinKH ganthongtin(string  sdt,string ten)
        //{
        //    return taiKhoan.GanThongTinNguoiDung(sdt,ten);
        //}

    }
}
