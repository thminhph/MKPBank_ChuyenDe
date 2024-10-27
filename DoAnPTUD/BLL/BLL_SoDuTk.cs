using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_SoDuTk
    {

        private DAL_SoDuTk sdtk = new DAL_SoDuTk();

        public IQueryable laydsSDTK()
        {
            return sdtk.layisSDTk();
        }
        public DTO_SoDuTk sodu(string a)
        {
            return sdtk.TimsoDuTKTheoID(a);
        }
    }
}
