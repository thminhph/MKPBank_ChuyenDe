using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Drawing;


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

        private int idKhachHangCN;
        private string tenKhachHang;
        private byte[] avarta;
        private DateTime ngaySinh;
        private string diaChi;
        private string soDienThoai;
        private string quocGia;
        private string quocTich;
        private string loaiGiayTo;
        private string soGiayTo;
        private DateTime ngayCap;
        private DateTime ngayHetHan;
        private string noiCap;
        private string email;
        private int nganhChinh;
        private int idnganh;
        private string nhanVienLV;


       

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

        public DTO_ThongTinKH(int idKhachHangCN, string tenKhachHang, byte[] avarta, DateTime ngaySinh, string diaChi, string soDienThoai, string quocGia, string quocTich, string loaiGiayTo, string soGiayTo, DateTime ngayCap, DateTime ngayHetHan, string noiCap, string email, int nganhChinh, int nganh, string nhanVienLV)
        {
            this.idKhachHangCN = idKhachHangCN;
            this.tenKhachHang = tenKhachHang;
            this.avarta = avarta;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.quocGia = quocGia;
            this.quocTich = quocTich;
            this.loaiGiayTo = loaiGiayTo;
            this.soGiayTo = soGiayTo;
            this.ngayCap = ngayCap;
            this.ngayHetHan = ngayHetHan;
            this.noiCap = noiCap;
            this.email = email;
            this.nganhChinh = nganhChinh;
            this.idnganh = nganh;
            this.nhanVienLV = nhanVienLV;
        }

        public int IdKhachHangCN { get => idKhachHangCN; set => idKhachHangCN = value; }
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public byte[] Avarta { get => avarta; set => avarta = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string QuocGia { get => quocGia; set => quocGia = value; }
        public string QuocTich { get => quocTich; set => quocTich = value; }
        public string LoaiGiayTo { get => loaiGiayTo; set => loaiGiayTo = value; }
        public string SoGiayTo { get => soGiayTo; set => soGiayTo = value; }
        public DateTime NgayCap { get => ngayCap; set => ngayCap = value; }
        public DateTime NgayHetHan { get => ngayHetHan; set => ngayHetHan = value; }
        public string NoiCap { get => noiCap; set => noiCap = value; }
        public string Email { get => email; set => email = value; }
        public int NganhChinh { get => nganhChinh; set => nganhChinh = value; }
        public int Nganh { get => idnganh; set => idnganh = value; }
        public string NhanVienLV { get => nhanVienLV; set => nhanVienLV = value; }

    }
    
}
