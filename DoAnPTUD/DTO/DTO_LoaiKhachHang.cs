using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LoaiKhachHang
    {
        private int idLoai;
        private string tenLoai;

        public int IdLoai { get => idLoai; set => idLoai = value; }
        public string TenLoai { get => tenLoai; set => tenLoai = value; }

        public DTO_LoaiKhachHang(int idLoai, string tenLoai)
        {
            this.IdLoai = idLoai;
            this.TenLoai = tenLoai;
        }
        public DTO_LoaiKhachHang()
        {

        }
    }
}
