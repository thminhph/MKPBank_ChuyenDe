using DAL;
using DTO;
using System.Collections.Generic;
using System.Data.Common;

namespace BLL
{
    public class BLL_TaiKhoan
    {
        private DAL_TaiKhoan taiKhoan = new DAL_TaiKhoan();

        public List<DTO_LoaiKhachHang> layDanhSachLoaiTK()
        {
            return taiKhoan.LayDanhSachLoaiTK();
        }
        public DTO_ThongTinKH tim(string stk)
        {
            return taiKhoan.timUserTheostk(stk);
        }
        public void Them(DTO_TaiKhoan tk)
        {
            taiKhoan.Them(tk);
        }
        public void SuaTK(DTO_TaiKhoan tk)
        {
            taiKhoan.SuaTK(tk);
        }
        public DTO_TaiKhoan dangNhap(string sdt, string mK)
        {
            return taiKhoan.DangNhap(sdt, mK);
        }

        //public DTO_ThongTinKH ganthongtin(string sdt, string ten)
        //{
        //    return taiKhoan.GanThongTinNguoiDung(sdt, ten);
        //}
        public bool DangKy(string soDienThoai)
        {
            return taiKhoan.DangKy(soDienThoai);
        }
        public void DangKyCT(DTO_TaiKhoan tk)
        {
            taiKhoan.CreateTK(tk);
        }
   
        public void DangKyKH(DTO_ThongTinKH tk) { 
             taiKhoan.CreateKH(tk);
        }
        public void SuaMK(string mk,string idTK)
        {
            taiKhoan.SuaMK(mk,idTK);
        }
        
    }
}
