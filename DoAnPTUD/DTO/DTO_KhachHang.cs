using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {
        private int idKhachHang;
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
        private DateTime ngayHetHan; // Nullable for optional fields
        private string noiCap;
        private string email;
        private int nganhChinh;
        private int idNganh;
        private string nhanVienLV;
        private int idLoaiKH;
        public DTO_KhachHang()
        {

        }
        public DTO_KhachHang(int idKhachHang, string tenKhachHang, byte[] avarta, DateTime ngaySinh, string diaChi, string soDienThoai, string quocGia, string quocTich, string loaiGiayTo, string soGiayTo, DateTime ngayCap, DateTime ngayHetHan, string noiCap, string email, int nganhChinh, int idNganh, string nhanVienLV, int idLoaiKH)
        {
            this.idKhachHang = idKhachHang;
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
            this.idNganh = idNganh;
            this.nhanVienLV = nhanVienLV;
            this.idLoaiKH = idLoaiKH;
        }

        public int IdKhachHang { get => idKhachHang; set => idKhachHang = value; }
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
        public int IdNganh { get => idNganh; set => idNganh = value; }
        public string NhanVienLV { get => nhanVienLV; set => nhanVienLV = value; }
        public int IdLoaiKH { get => idLoaiKH; set => idLoaiKH = value; }
    }
}
