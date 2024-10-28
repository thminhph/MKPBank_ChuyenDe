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
        public DAL_SoDuTk () { 
            this.db = new QLNganHangDataContext (Properties.Settings.Default.QLNganHangConnectionString);

        }   
        public IQueryable layisSDTk()
        {
            IQueryable layDSSDTK = from s in db.SoDuTinDungs
                                   select s;
            return layDSSDTK;
        }
        public DTO_SoDuTk TimsoDuTKTheoID(string  a )
        {
            var qurey = from s in db.SoDuTinDungs
                        join k in db.TaiKhoans on s.IdTaiKhoan equals k.IdTaiKhoan
                        join c in db.KhachHangCaNhans on k.IdKhachHangCN equals c.IdKhachHangCN
                        where c.SoDienThoai == a
                        select new
                        {
                            s.SoDuTK
                        };
            DTO_SoDuTk soDu = null;
            foreach ( var k in qurey )
            {
                float sodu=(float)k.SoDuTK;
                soDu = new DTO_SoDuTk(sodu);
            }
            return soDu;
        }
    }
}
