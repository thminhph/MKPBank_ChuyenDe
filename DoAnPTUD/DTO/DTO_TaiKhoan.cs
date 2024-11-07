using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TaiKhoan
    {
        public long IdTaiKhoan { get; set; }         // bigint
        public int IdKhachHang { get; set; }      // int
        public int LoaiTaiKhoan { get; set; }     // nvarchar(255)
        public string TenTaiKhoan { get; set; }      // nvarchar(255)
        public string TienTe { get; set; }           // nvarchar(50)
        public string TieuDeTK { get; set; }         // nvarchar(255)
        public string TieuDeNgan { get; set; }       // nvarchar(50)
        public string NhanVienLV { get; set; }       // varchar(20)
        public string PhiMa { get; set; }            // nvarchar(255)
        public string Matkhau { get; set; }          // char(255)

        // Parameterized constructor
        public DTO_TaiKhoan(
            long idTaiKhoan,
            int idKhachHang,
            int loaiTaiKhoan,
            string tenTaiKhoan,
            string tienTe,
            string tieuDeTK,
            string tieuDeNgan,
            string nhanVienLV,
            string phiMa,
            string matkhau)
        {
            IdTaiKhoan = idTaiKhoan;
            IdKhachHang = idKhachHang;
            LoaiTaiKhoan = loaiTaiKhoan;
            TenTaiKhoan = tenTaiKhoan;
            TienTe = tienTe;
            TieuDeTK = tieuDeTK;
            TieuDeNgan = tieuDeNgan;
            NhanVienLV = nhanVienLV;
            PhiMa = phiMa;
            Matkhau = matkhau;
        }
        public DTO_TaiKhoan()
        {
        }
    }
}
