using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietKHDN : DTO_KhachHang
    {
        public int IdLoaiKH { get; set; }
        public DateTime NgayTao { get; set; }
        public string QuanHe { get; set; }
        public string SoVanPhong { get; set; }
        public float TongVon { get; set; }
        public float TongTaiSan { get; set; }
        public float TongDoanhThu { get; set; }
        public int SoLuongNhanVien { get; set; }
        public string NguoiLH { get; set; } // Người Liên Hệ
        public string ChucVu { get; set; }

        // Constructor không tham số
        public DTO_ChiTietKHDN()
        {
        }

        // Constructor có tham số
        public DTO_ChiTietKHDN(int idKhachHang, string tenKhachHang, byte[] avarta, DateTime ngaySinh, string diaChi,
                           string soDienThoai, string quocGia, string quocTich, string loaiGiayTo, string soGiayTo,
                           DateTime ngayCap, DateTime? ngayHetHan, string noiCap, string email, int nganhChinh,
                           int idNganh, string nhanVienLV, int idLoaiKH, DateTime ngayTao, string quanHe,
                           string soVanPhong, float tongVon, float tongTaiSan, float tongDoanhThu,
                           int soLuongNhanVien, string nguoiLH, string chucVu)
            : base(idKhachHang, tenKhachHang, avarta, ngaySinh, diaChi, soDienThoai, quocGia, quocTich, loaiGiayTo, soGiayTo,
                   ngayCap, ngayHetHan, noiCap, email, nganhChinh, idNganh, nhanVienLV)
        {
            IdLoaiKH = idLoaiKH;
            NgayTao = ngayTao;
            QuanHe = quanHe;
            SoVanPhong = soVanPhong;
            TongVon = tongVon;
            TongTaiSan = tongTaiSan;
            TongDoanhThu = tongDoanhThu;
            SoLuongNhanVien = soLuongNhanVien;
            NguoiLH = nguoiLH;
            ChucVu = chucVu;
        }
    }

}
}
