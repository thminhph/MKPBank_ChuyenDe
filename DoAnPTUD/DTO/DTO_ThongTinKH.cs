using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ThongTinKH
    {
        private int IdKhachHangCN;
        private string TenKhachHang;
        private DateTime NgaySinh;
        private string DiaChi;
        private char SoDienThoai;
        private string QuocGia;
        private string QuocTich;
        private string LoaiGiayTo;
        private string SoGiayTo;
        private DateTime NgayCap;
        private DateTime NgayHetHan;
        private string NoiCap;
        private string Email;
        private int NganhChinh;
        private int Nganh;
        private string NhanVienLV;

        public DTO_ThongTinKH(int idKhachHangCN, string tenKhachHang, DateTime ngaySinh, string diaChi, char soDienThoai, string quocGia, string quocTich, string loaiGiayTo, string soGiayTo, DateTime ngayCap, DateTime ngayHetHan, string noiCap, string email, int nganhChinh, int nganh, string nhanVienLV)
        {
            IdKhachHangCN = idKhachHangCN;
            TenKhachHang = tenKhachHang;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
            QuocGia = quocGia;
            QuocTich = quocTich;
            LoaiGiayTo = loaiGiayTo;
            SoGiayTo = soGiayTo;
            NgayCap = ngayCap;
            NgayHetHan = ngayHetHan;
            NoiCap = noiCap;
            Email = email;
            NganhChinh = nganhChinh;
            Nganh = nganh;
            NhanVienLV = nhanVienLV;
        }
        public DTO_ThongTinKH()
        {

        }
        public int IdKhachHangCN1 { get => IdKhachHangCN; set => IdKhachHangCN = value; }
        public string TenKhachHang1 { get => TenKhachHang; set => TenKhachHang = value; }
        public DateTime NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public char SoDienThoai1 { get => SoDienThoai; set => SoDienThoai = value; }
        public string QuocGia1 { get => QuocGia; set => QuocGia = value; }
        public string QuocTich1 { get => QuocTich; set => QuocTich = value; }
        public string LoaiGiayTo1 { get => LoaiGiayTo; set => LoaiGiayTo = value; }
        public string SoGiayTo1 { get => SoGiayTo; set => SoGiayTo = value; }
        public DateTime NgayCap1 { get => NgayCap; set => NgayCap = value; }
        public DateTime NgayHetHan1 { get => NgayHetHan; set => NgayHetHan = value; }
        public string NoiCap1 { get => NoiCap; set => NoiCap = value; }
        public string Email1 { get => Email; set => Email = value; }
        public int NganhChinh1 { get => NganhChinh; set => NganhChinh = value; }
        public int Nganh1 { get => Nganh; set => Nganh = value; }
        public string NhanVienLV1 { get => NhanVienLV; set => NhanVienLV = value; }
    }
    
}
