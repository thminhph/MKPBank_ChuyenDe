using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietKHCN : DTO_KhachHangCaNhan
    {
        public string GioiTinh { get; set; }
        public string XungHo { get; set; }
        public string TTHonNhan { get; set; }
        public string QuanHe { get; set; }
        public string SoVanPhong { get; set; }
        public int? SoNguoiPT { get; set; }
        public string SoHuuNha { get; set; }
        public string LHCuChu { get; set; }
        public string TinhTrangViecLam { get; set; }
        public string TenCty { get; set; }
        public double? ThuNhapHangThang { get; set; }
        public string DiaChiCty { get; set; }

        // Constructor không tham số

        // Constructor có tham số
        public DTO_ChiTietKHCN(int id, string tenKhachHang, string diaChi, string sdt, string quocGia, string quocTich, string loaiGiayTo, string soGiayTo, string noiCap, string email, int nganhChinh, int nganh, string nhanVienLV, DateTime ngaySinh, DateTime ngayCap, DateTime ngayHetHan, string gioiTinh, string xungHo, string ttHonNhan, string quanHe, string soVanPhong, int? soNguoiPT, string soHuuNha, string lhCuChu, string tinhTrangViecLam, string tenCty, double? thuNhapHangThang, string diaChiCty)
         : base(id, tenKhachHang, diaChi, sdt, quocGia, quocTich, loaiGiayTo, soGiayTo, noiCap, email, nganhChinh, nganh, nhanVienLV, ngaySinh, ngayCap, ngayHetHan)
        {
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
    }
}
