using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHangDoanhNghiep
    {

        public int IdKhachHangDN { get; set; }
        public string TenVietTatDN { get; set; }
        public string TenDayDuDN { get; set; }
        public DateTime NgayThanhLap { get; set; }
        public string DiaChi { get; set; }
        public string QuocGia { get; set; }
        public string QuocTich { get; set; }
        public string LoaiGiayTo { get; set; }
        public string SoGiayTo { get; set; }
        public DateTime NgayCap { get; set; }
        public DateTime? NgayHetHan { get; set; }
        public string NoiCap { get; set; }
        public string NguoiLH { get; set; }
        public string ChucVu { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public int NganhChinh { get; set; }
        public int Nganh { get; set; }
        public string NhanVienLV { get; set; }

        // Constructor mặc định
        public DTO_KhachHangDoanhNghiep() { }

        // Constructor đầy đủ
        public DTO_KhachHangDoanhNghiep(
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
            string nhanVienLV)
        {
            IdKhachHangDN = idKhachHangDN;
            TenVietTatDN = tenVietTatDN;
            TenDayDuDN = tenDayDuDN;
            NgayThanhLap = ngayThanhLap;
            DiaChi = diaChi;
            QuocGia = quocGia;
            QuocTich = quocTich;
            LoaiGiayTo = loaiGiayTo;
            SoGiayTo = soGiayTo;
            NgayCap = ngayCap;
            NgayHetHan = ngayHetHan;
            NoiCap = noiCap;
            NguoiLH = nguoiLH;
            ChucVu = chucVu;
            Email = email;
            SoDienThoai = soDienThoai;
            NganhChinh = nganhChinh;
            Nganh = nganh;
            NhanVienLV = nhanVienLV;
        }
    }
}
