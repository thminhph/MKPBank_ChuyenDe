using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_Nganh
    {
        private QLNganHangDataContext db;
        public DAL_Nganh() { 
            this.db = new QLNganHangDataContext(Properties.Settings.Default.QLNganHangConnectionString);

        }
        public IQueryable laydsNganh() { 
            IQueryable laydsN = from s in db.Nganhs
                               select s;
            return laydsN;
        }
    }
}
