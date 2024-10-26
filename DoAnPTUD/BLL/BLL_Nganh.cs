using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public  class BLL_Nganh
    {

        private DAL_Nganh nganh = new  DAL_Nganh();

        public IQueryable laydsN()
        {
            return nganh.laydsNganh();
        }

    }
}
