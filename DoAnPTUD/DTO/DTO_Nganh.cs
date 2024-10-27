using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Nganh
    {
        private int IdNganh;
        private string TenNganh;
        private int IdNganhChinh;
        public DTO_Nganh() { }

        public DTO_Nganh(int idNganh, string tenNganh, int idNganhChinh)
        {
            IdNganh = idNganh;
            TenNganh = tenNganh;
            IdNganhChinh = idNganhChinh;
        }

        public int IdNganh1 { get => IdNganh; set => IdNganh = value; }
        public string TenNganh1 { get => TenNganh; set => TenNganh = value; }
        public int IdNganhChinh1 { get => IdNganhChinh; set => IdNganhChinh = value; }
    }
}
