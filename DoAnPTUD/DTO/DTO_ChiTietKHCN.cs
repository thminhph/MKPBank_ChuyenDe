using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietKHCN : DTO_KhachHang
    {
        public int IdLoaiKH { get; set; }
        public string GioiTinh { get; set; }
        public string XungHo { get; set; }
        public string TTHonNhan { get; set; }  // Tình Trạng Hôn Nhân
        public string QuanHe { get; set; }
        public string SoVanPhong { get; set; }
        public int SoNguoiPT { get; set; }  // Số Người Phụ Thuộc
        public string SoHuuNha { get; set; }
        public string LHCuChu { get; set; }  // Loại Hình Chủ Chứng
        public string TinhTrangViecLam { get; set; }
        public string TenCty { get; set; }
        public float ThuNhapHangThang { get; set; }
        public string DiaChiCty { get; set; }

        // Constructor không tham số
        public DTO_ChiTietKHCN()
        {
        }

        // Constructor có tham số
        public DTO_ChiTietKHCN(int idKhachHang, string tenKhachHang, byte[] avarta, DateTime ngaySinh, string diaChi,
                           string soDienThoai, string quocGia, string quocTich, string loaiGiayTo, string soGiayTo,
                           DateTime ngayCap, DateTime? ngayHetHan, string noiCap, string email, int nganhChinh,
                           int idNganh, string nhanVienLV, int idLoaiKH, string gioiTinh, string xungHo, string ttHonNhan,
                           string quanHe, string soVanPhong, int soNguoiPT, string soHuuNha, string lhCuChu,
                           string tinhTrangViecLam, string tenCty, float thuNhapHangThang, string diaChiCty)
            : base(idKhachHang, tenKhachHang, avarta, ngaySinh, diaChi, soDienThoai, quocGia, quocTich, loaiGiayTo, soGiayTo,
                   ngayCap, ngayHetHan, noiCap, email, nganhChinh, idNganh, nhanVienLV)
        {
            IdLoaiKH = idLoaiKH;
            GioiTinh = gioiTinh;
            XungHo = xungHo;
            TTHonNhan = ttHonNhan;
            QuanHe = quanHe;
            SoVanPhong = soVanPhong;
            SoNguoiPT = soNguoiPT;
            SoHuuNha = soHuuNha;
            LHCuChu = lhCuChu;
            TinhTrangViecLam = tinhTrangViecLam;
            TenCty = tenCty;
            ThuNhapHangThang = thuNhapHangThang;
            DiaChiCty = diaChiCty;
        }

        public DTO_ChiTietKHCN(int idKhachHang, string tenKhachHang, string diaChi, string soDienThoai, string quocGia, string quocTich, string loaiGiayTo, string soGiayTo, string noiCap, string email, int nganhChinh, int idNganh, string nhanVienLV, DateTime ngaySinh, DateTime ngayCap, DateTime ngayHetHan, string gioiTinh, string xungHo, string tTHonNhan, string quanHe, string soVanPhong, int? soNguoiPT, string soHuuNha, string lHCuChu, string tinhTrangViecLam, string tenCty, double? thuNhapHangThang, string diaChiCty)
        {
            IdKhachHang = idKhachHang;
            TenKhachHang = tenKhachHang;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
            QuocGia = quocGia;
            QuocTich = quocTich;
            LoaiGiayTo = loaiGiayTo;
            SoGiayTo = soGiayTo;
            NoiCap = noiCap;
            Email = email;
            NganhChinh = nganhChinh;
            IdNganh = idNganh;
            NhanVienLV = nhanVienLV;
            NgaySinh = ngaySinh;
            NgayCap = ngayCap;
            NgayHetHan = ngayHetHan;
            GioiTinh = gioiTinh;
            XungHo = xungHo;
            TTHonNhan = tTHonNhan;
            QuanHe = quanHe;
            SoVanPhong = soVanPhong;
            SoHuuNha = soHuuNha;
            LHCuChu = lHCuChu;
            TinhTrangViecLam = tinhTrangViecLam;
            TenCty = tenCty;
            DiaChiCty = diaChiCty;
        }
    }

}

