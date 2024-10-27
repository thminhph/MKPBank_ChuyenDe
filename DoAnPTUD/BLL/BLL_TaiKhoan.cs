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

        public bool dangNhap(string sdt, string mK)
        {
            return taiKhoan.DangNhap(sdt,mK)  ;
        }


        public bool dangKy(DTO_TaiKhoan tk, DTO_ThongTinKH kh)
        {
            return taiKhoan.DangKy(tk, kh);
        }
    }
}
