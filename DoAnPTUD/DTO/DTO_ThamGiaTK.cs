using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ThamGiaTK
    {
        private int idTK;
        private string noiDung;

        public DTO_ThamGiaTK()
        {

        }
        public DTO_ThamGiaTK(int idTK, string noiDung)
        {
            this.idTK = idTK;
            this.noiDung = noiDung;
        }

        public int IdTK { get => idTK; set => idTK = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
    }
}
