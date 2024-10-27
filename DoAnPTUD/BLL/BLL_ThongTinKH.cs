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
       
        public IQueryable laydsTTKH()
        {
            return dal_thongtinkh.layDSThongTinKH();
        }
        public void capnhat(DTO_ThongTinKH a, DTO_ThongTinKH b)
        {
             dal_thongtinkh.SuaKH(a,b);
        }
        public IQueryable timUserTheostk(DTO_ThongTinKH stk)
        {
            return dal_thongtinkh.timUserTheostk(stk);
        }
    }
}
