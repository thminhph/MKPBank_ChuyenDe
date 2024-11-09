using DAL;
using DTO;
using System;
using System.Collections.Generic;
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
        public void capnhat(DTO_ThongTinKH a, DTO_ThongTinKH b)
        {
             dal_thongtinkh.SuaKH(a,b);
        }
       
        public DTO_ThongTinKH timTHKHTheostk(long stk)
        {
            return dal_thongtinkh.timTHKHstk(stk);
        }
        public  bool ktraSDT(string sDT)
        {
            return dal_thongtinkh.ktraSDT(sDT);
        }

    }
}
