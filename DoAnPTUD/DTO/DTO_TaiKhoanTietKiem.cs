using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TaiKhoanTietKiem
    {
        public long IdTaiKhoanTK { get; set; }
        public int IdKhachHang { get; set; }
        public int IdLoaiTK { get; set; }
        public string TieuDeTK { get; set; }  // nvarchar(255) -> string
        public string TienTe { get; set; }    // nvarchar(100) -> string
        public double SoTienNap { get; set; } // float -> double
        public DateTime NgayGiaTri { get; set; } // date -> DateTime
        public string ThoiHan { get; set; }   // nvarchar(100) -> string
        public float LaiSuat { get; set; }    // float -> float
        public long IdTaiKhoan { get; set; }
        public DateTime NgayDaoHan { get; set; }
        public DTO_TaiKhoanTietKiem()
        {

        }

        public DTO_TaiKhoanTietKiem(long idTaiKhoanTK, int idKhachHang, int idLoaiTK, string tieuDeTK, string tienTe, double soTienNap, DateTime ngayGiaTri, string thoiHan, float laiSuat, long idTaiKhoan,DateTime ngayDaoHan)
        {
            IdTaiKhoanTK = idTaiKhoanTK;
            IdKhachHang = idKhachHang;
            IdLoaiTK = idLoaiTK;
            TieuDeTK = tieuDeTK;
            TienTe = tienTe;
            SoTienNap = soTienNap;
            NgayGiaTri = ngayGiaTri;
            ThoiHan = thoiHan;
            LaiSuat = laiSuat;
            IdTaiKhoan = idTaiKhoan;
            NgayDaoHan = ngayDaoHan;
        }


    }
}
