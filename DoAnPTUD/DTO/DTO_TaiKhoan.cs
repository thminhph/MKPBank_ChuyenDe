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
        public int? IdKhachHangCN { get; set; }       // int
        public int? IdKhachHangDN { get; set; }       // int
        public string LoaiTaiKhoan { get; set; }     // nvarchar(255)
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
            int? idKhachHangCN,
            int? idKhachHangDN,
            string loaiTaiKhoan,
            string tenTaiKhoan,
            string tienTe,
            string tieuDeTK,
            string tieuDeNgan,
            string nhanVienLV,
            string phiMa,
            string matkhau)
        {
            IdTaiKhoan = idTaiKhoan;
            IdKhachHangCN = idKhachHangCN;
            IdKhachHangDN = idKhachHangDN;
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
