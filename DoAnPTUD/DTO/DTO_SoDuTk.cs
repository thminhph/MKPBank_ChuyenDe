using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SoDuTk
    {
        private int IdTaiKhoan;
        private decimal SoDuTK;

        public DTO_SoDuTk(int idTaiKhoan, decimal soDuTK)
        {
            IdTaiKhoan = idTaiKhoan;
            SoDuTK = soDuTK;
        }
        public DTO_SoDuTk( decimal soDuTK)
        {
          
            SoDuTK = soDuTK;
        }
        public DTO_SoDuTk() { }

        public int IdTaiKhoan1 { get => IdTaiKhoan; set => IdTaiKhoan = value; }
        public decimal SoDuTK1 { get => SoDuTK; set => SoDuTK = value; }
    }
}
