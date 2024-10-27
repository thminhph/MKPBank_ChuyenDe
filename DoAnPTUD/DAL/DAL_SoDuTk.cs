using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_SoDuTk
    {
        private QLNganHangDataContext db;
        public DAL_SoDuTk () { 
            this.db = new QLNganHangDataContext (Properties.Settings.Default.QLNganHangConnectionString);

        }   
        public IQueryable layisSDTk()
        {
            IQueryable layDSSDTK = from s in db.SoDuTinDungs
                                   select s;
            return layDSSDTK;
        }
    }
}
