using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NganhChinh
    {
        private int IdNganhChinh;
        private string TenNganh;

        public DTO_NganhChinh(int idNganhChinh, string tenNganh)
        {
            IdNganhChinh = idNganhChinh;
            TenNganh = tenNganh;
        }
        public DTO_NganhChinh() { }
        public int IdNganhChinh1 { get => IdNganhChinh; set => IdNganhChinh = value; }
        public string TenNganh1 { get => TenNganh; set => TenNganh = value; }
    }
}
