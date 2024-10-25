using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_ChiTietGiaoDich
    {
        private QLNganHangDataContext db;
        public DAL_ChiTietGiaoDich() {
            this.db = new QLNganHangDataContext(Properties.Settings.Default.QLNganHangConnectionString);
        }
        public IQueryable laydsCTGD(){
            IQueryable gd = from s in db.ChiTietGDs
                            select s;
            return gd;
            }

    }
}
