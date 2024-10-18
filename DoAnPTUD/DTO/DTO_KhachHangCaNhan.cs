using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHangCaNhan
    {

        private int id, nganhChinh, nganh;
        private string tenKhachHang, diaChi, sdt, quocGia, quocTich, loaiGiayTo, soGiayTo, noiCap, email, nhanVienLV;
        private DateTime ngaySinh, ngayCap, ngayHetHan;
        public DTO_KhachHangCaNhan(int id, string tenKhachHang, string diaChi, string sdt, string quocGia, string quocTich, string loaiGiayTo, string soGiayTo, string noiCap, string email, int nganhChinh, int nganh, string nhanVienLV, DateTime ngaySinh, DateTime ngayCap, DateTime ngayHetHan)
        {
            this.Id = id;
            this.TenKhachHang = tenKhachHang;
            this.DiaChi = diaChi;
            this.Sdt = sdt;
            this.QuocGia = quocGia;
            this.QuocTich = quocTich;
            this.LoaiGiayTo = loaiGiayTo;
            this.SoGiayTo = soGiayTo;
            this.NoiCap = noiCap;
            this.Email = email;
            this.NganhChinh = nganhChinh;
            this.Nganh = nganh;
            this.NhanVienLV = nhanVienLV;
            this.NgaySinh = ngaySinh;
            this.NgayCap = ngayCap;
            this.NgayHetHan = ngayHetHan;
        }

        public int Id { get => id; set => id = value; }
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string QuocGia { get => quocGia; set => quocGia = value; }
        public string QuocTich { get => quocTich; set => quocTich = value; }
        public string LoaiGiayTo { get => loaiGiayTo; set => loaiGiayTo = value; }
        public string SoGiayTo { get => soGiayTo; set => soGiayTo = value; }
        public string NoiCap { get => noiCap; set => noiCap = value; }
        public string Email { get => email; set => email = value; }
        public int NganhChinh { get => nganhChinh; set => nganhChinh = value; }
        public int Nganh { get => nganh; set => nganh = value; }
        public string NhanVienLV { get => nhanVienLV; set => nhanVienLV = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public DateTime NgayCap { get => ngayCap; set => ngayCap = value; }
        public DateTime? NgayHetHan { get => ngayHetHan; set => ngayHetHan = (DateTime)value; }
    }
}
