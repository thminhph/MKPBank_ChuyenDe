using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietKHDN : DTO_KhachHangDoanhNghiep
    {
        public DateTime NgayTao { get; set; }
        public string QuanHe { get; set; }
        public string SoVanPhong { get; set; }
        public float TongVon { get; set; }
        public float TongTaiSan { get; set; }
        public float TongDoanhThu { get; set; }
        public int SoLuongNhanVien { get; set; }

        // Constructor mặc định
        public DTO_ChiTietKHDN() { }

        // Constructor đầy đủ
        public DTO_ChiTietKHDN(
            int idKhachHangDN,
            string tenVietTatDN,
            string tenDayDuDN,
            DateTime ngayThanhLap,
            string diaChi,
            string quocGia,
            string quocTich,
            string loaiGiayTo,
            string soGiayTo,
            DateTime ngayCap,
            DateTime? ngayHetHan,
            string noiCap,
            string nguoiLH,
            string chucVu,
            string email,
            string soDienThoai,
            int nganhChinh,
            int nganh,
            string nhanVienLV,
            DateTime ngayTao,
            string quanHe,
            string soVanPhong,
            float tongVon,
            float tongTaiSan,
            float tongDoanhThu,
            int soLuongNhanVien)
            : base(
                idKhachHangDN, tenVietTatDN, tenDayDuDN, ngayThanhLap, diaChi,
                quocGia, quocTich, loaiGiayTo, soGiayTo, ngayCap,
                ngayHetHan, noiCap, nguoiLH, chucVu, email, soDienThoai,
                nganhChinh, nganh, nhanVienLV)
        {
            NgayTao = ngayTao;
            QuanHe = quanHe;
            SoVanPhong = soVanPhong;
            TongVon = tongVon;
            TongTaiSan = tongTaiSan;
            TongDoanhThu = tongDoanhThu;
            SoLuongNhanVien = soLuongNhanVien;
        }
    }
}
