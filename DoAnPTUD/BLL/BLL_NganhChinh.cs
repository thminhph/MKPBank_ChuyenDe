using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_NganhChinh
    {

        private DAL_NganhChinh nganhChinh = new DAL_NganhChinh();

        public IQueryable laydsNC()
        {
            return nganhChinh.laydsNganhChinh();
        }
    }
}
