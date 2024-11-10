using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_ThongTinKH
    {
     
        private DAL_ThongTinKH dal_thongtinkh = new DAL_ThongTinKH(); 
       
        public List<KhachHang> laydsTTKH()
        {
            return dal_thongtinkh.layDSThongTinKH();
        }
        public void capnhat(DTO_ThongTinKH a)
        {
             dal_thongtinkh.SuaKH(a);
        }
       
        public DTO_ThongTinKH timTHKHTheostk(long stk)
        {
            return dal_thongtinkh.timTHKHstk(stk);
        }
        public  bool ktraSDT(string sDT)
        {
            return dal_thongtinkh.ktraSDT(sDT);
        }
        //public bool ktraMK(string mk)
        //{
        //    return dal_thongtinkh.ktraMatKhau(mk);
        //}
    }
}
