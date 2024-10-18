using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Context
    {
        Data_Context dt;
        public Context(string conn)
        {
            Dt = new Data_Context(conn);
        }

        public Data_Context Dt { get => dt; set => dt = value; }
    }
}
