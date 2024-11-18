using DTO;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_SoDuTk
    {
        private QLNganHangDataContext db;
        public DAL_SoDuTk()
        {
            this.db = new QLNganHangDataContext(Properties.Settings.Default.QLNganHangConnectionString);

        }
        public IQueryable layisSDTk()
        {
            IQueryable layDSSDTK = from s in db.SoDuTinDungs
                                   select s;
            return layDSSDTK;
        }
        public DTO_SoDuTk TimsoDuTKTheoID(string a)
        {
            var qurey = (from s in db.SoDuTinDungs
                         join k in db.TaiKhoans on s.IdTaiKhoan equals k.IdTaiKhoan
                         join c in db.KhachHangs on k.IdKhachHang equals c.IdKhachHang
                         where k.IdTaiKhoan == long.Parse(a)
                         select new DTO_SoDuTk
                         {
                             SoDuTK1 =decimal.Parse(s.SoDuTK.ToString()),
                         }).FirstOrDefault();
          
            return qurey;
        }
    }
}
