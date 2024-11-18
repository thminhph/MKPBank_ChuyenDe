using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SoDuTinDung
    {
        private long idTaiKhoan;
        private decimal soTien;

        public long IdTaiKhoan { get => idTaiKhoan; set => idTaiKhoan = value; }
        public decimal SoTien { get => soTien; set => soTien = value; }

        public DTO_SoDuTinDung(long idTaiKhoan, decimal soTien)
        {
            this.IdTaiKhoan = idTaiKhoan;
            this.SoTien = soTien;
        }
        public DTO_SoDuTinDung() { }
    }
}
