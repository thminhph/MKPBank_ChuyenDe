using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    
    public class BLL_ChiTietGiaoDich
    {
        DAL_ChiTietGiaoDich gd =new DAL_ChiTietGiaoDich();
        public IQueryable laydanhsach()
        {
            return gd.laydsCTGD();
        }
        public string  tim(string   st)
        {
            return gd.tim(st);  
        }
        public bool giaoDich(string nc, string nn, float sotien, string diengia)
        {
          return gd.giaoDich(nc, nn, sotien, diengia);
        }
    }

     
}
