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
        private DataNganHangDataContext db;
        public Data_Context(string conn)
        {
            Db = new DataNganHangDataContext(conn);
            if (!db.DatabaseExists())
            {
                throw new InvalidOperationException("Kết nối thất bại!!!");
            }
        }

        public DataNganHangDataContext Db { get => db; set => db = value; }
    }
}
