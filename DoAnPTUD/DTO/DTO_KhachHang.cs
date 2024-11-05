using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {
     
            public int IdKhachHang { get; set; }
            public string TenKhachHang { get; set; }
            public byte[] Avarta { get; set; }
            public DateTime NgaySinh { get; set; }
            public string DiaChi { get; set; }
            public string SoDienThoai { get; set; }
            public string QuocGia { get; set; }
            public string QuocTich { get; set; }
            public string LoaiGiayTo { get; set; }
            public string SoGiayTo { get; set; }
            public DateTime NgayCap { get; set; }
            public DateTime? NgayHetHan { get; set; } // Nullable for optional fields
            public string NoiCap { get; set; }
            public string Email { get; set; }
            public int NganhChinh { get; set; }
            public int IdNganh { get; set; }
            public string NhanVienLV { get; set; }

            // Constructor không tham số
            public DTO_KhachHang()
            {
            }

            // Constructor có tham số
            public DTO_KhachHang(int idKhachHang, string tenKhachHang, byte[] avarta, DateTime ngaySinh, string diaChi,
                             string soDienThoai, string quocGia, string quocTich, string loaiGiayTo, string soGiayTo,
                             DateTime ngayCap, DateTime? ngayHetHan, string noiCap, string email, int nganhChinh,
                             int idNganh, string nhanVienLV)
            {
                IdKhachHang = idKhachHang;
                TenKhachHang = tenKhachHang;
                Avarta = avarta;
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
                IdNganh = idNganh;
                NhanVienLV = nhanVienLV;
            }
        }
    }
