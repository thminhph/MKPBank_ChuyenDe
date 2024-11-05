using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Data_Context
    {
        private QLNganHangDataContext db;
        public Data_Context()
        {
            Db = new QLNganHangDataContext(Properties.Settings.Default.QLNganHangConnectionString);
            if (!db.DatabaseExists())
            {
                throw new InvalidOperationException("Kết nối thất bại!!!");
            }
        }

        public QLNganHangDataContext Db { get => db; set => db = value; }
    }
}
