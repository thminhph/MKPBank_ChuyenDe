using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NganhChinh
    {
        private QLNganHangDataContext db;
        public DAL_NganhChinh()
        {
            this.db= new QLNganHangDataContext(Properties.Settings.Default.QLNganHangConnectionString);
        }
        public IQueryable laydsNganhChinh()
        {
            IQueryable laydsNC = from s in db.NganhChinhs
                                 select s;
            return laydsNC;
        }
    }
}
