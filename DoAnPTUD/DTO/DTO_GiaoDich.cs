using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_GiaoDich
    {
        private string idGuiTien, noiDung;
        private int idLoaiGD;
        private long idTK;
        private decimal soGiaoDich;
        private decimal soDu;
        public DTO_GiaoDich()
        {

        }
        public DTO_GiaoDich(string idGuiTien, string noiDung, long idTK, decimal soGiaoDich, decimal soDu)
        {
            this.idGuiTien = idGuiTien;
            this.noiDung = noiDung;
            this.idTK = idTK;
            this.soGiaoDich = soGiaoDich;
            this.soDu = soDu;
        }

        public string IdGuiTien { get => idGuiTien; set => idGuiTien = value; }
        public int IdLoaiGD { get => idLoaiGD; set => idLoaiGD = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public long IdTK { get => idTK; set => idTK = value; }
        public decimal SoGiaoDich { get => soGiaoDich; set => soGiaoDich = value; }
        public decimal SoDu { get => soDu; set => soDu = value; }
    }
}
