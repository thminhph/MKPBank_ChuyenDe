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
        private float SoDuTK;

        public DTO_SoDuTk(int idTaiKhoan, float soDuTK)
        {
            IdTaiKhoan = idTaiKhoan;
            SoDuTK = soDuTK;
        }
        public DTO_SoDuTk() { }

        public int IdTaiKhoan1 { get => IdTaiKhoan; set => IdTaiKhoan = value; }
        public float SoDuTK1 { get => SoDuTK; set => SoDuTK = value; }
    }
}
