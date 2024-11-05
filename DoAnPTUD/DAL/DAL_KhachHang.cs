using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DAL
{
    public class DAL_KhachHang
    {
        Data_Context dContext;

        public IQueryable XemKhachHangCaNhan()
        {
            dContext = new Data_Context();
            var xem = dContext.Db.KhachHangs.Select(kh => kh);
            return xem;
        }
        public DTO_ChiTietKHCN LayGiaTriKHCaNhan(int id)
        {
            dContext = new Data_Context();
            var chiTietKhachHang = (from khachHang in dContext.Db.KhachHangs
                                    join chiTiet in dContext.Db.ChiTietKHCNs
                                    on khachHang.IdKhachHang equals chiTiet.IdKhachHangCN
                                    where khachHang.IdKhachHang == id
                                    select new DTO_ChiTietKHCN(
                                        khachHang.IdKhachHang,
                                        khachHang.TenKhachHang,
                                        khachHang.Avarta.ToArray(),
                                        khachHang.NgaySinh,
                                        khachHang.DiaChi,
                                        khachHang.SoDienThoai,
                                        khachHang.QuocGia,
                                        khachHang.QuocTich,
                                        khachHang.LoaiGiayTo,
                                        khachHang.SoGiayTo,
                                        khachHang.NgayCap,
                                        (DateTime)khachHang.NgayHetHan,
                                        khachHang.NoiCap,
                                        khachHang.Email,
                                        khachHang.NganhChinh,
                                        khachHang.IdNganh,
                                        khachHang.NhanVienLV,
                                        chiTiet.IdLoaiKH,
                                        chiTiet.GioiTinh,
                                        chiTiet.XungHo,
                                        chiTiet.TTHonNhan,
                                        chiTiet.QuanHe,
                                        chiTiet.SoVanPhong,
                                        (int)chiTiet.SoNguoiPT,
                                        chiTiet.SoHuuNha,
                                        chiTiet.LHCuChu,
                                        chiTiet.TinhTrangViecLam,
                                        chiTiet.TenCty,
                                        (float)chiTiet.ThuNhapHangThang,
                                        chiTiet.DiaChiCty
                                    )).FirstOrDefault();

            return chiTietKhachHang;
        }

        public void ThemKHCaNhan(DTO_ChiTietKHCN kh)
        {
            dContext = new Data_Context();
            try
            {
                KhachHang khachHang = new KhachHang
                {
                    IdKhachHang = kh.IdKhachHang,
                    DiaChi = kh.DiaChi,
                    Email = kh.Email,
                    LoaiGiayTo = kh.LoaiGiayTo,
                    IdNganh = kh.IdNganh,
                    NgayCap = kh.NgayCap,
                    NganhChinh = kh.NganhChinh,
                    NgaySinh = kh.NgaySinh,
                    NgayHetHan = kh.NgayHetHan,
                    QuocGia = string.IsNullOrEmpty(kh.QuocGia) ? null : kh.QuocGia,
                    NoiCap = kh.NoiCap,
                    SoDienThoai = string.IsNullOrEmpty(kh.SoDienThoai) ? null : kh.SoDienThoai,
                    QuocTich = string.IsNullOrEmpty(kh.QuocTich) ? null : kh.QuocTich,
                    TenKhachHang = kh.TenKhachHang,
                    NhanVienLV = string.IsNullOrEmpty(kh.NhanVienLV) ? null : kh.NhanVienLV,
                    SoGiayTo = kh.SoGiayTo,

                };
                ChiTietKHCN chiTietKHCN = new ChiTietKHCN
                {
                    IdKhachHangCN = kh.IdKhachHang,
                    GioiTinh = string.IsNullOrEmpty(kh.GioiTinh) ? null : kh.GioiTinh,
                    XungHo = string.IsNullOrEmpty(kh.XungHo) ? null : kh.XungHo,
                    TTHonNhan = string.IsNullOrEmpty(kh.TTHonNhan) ? null : kh.TTHonNhan,
                    QuanHe = string.IsNullOrEmpty(kh.QuanHe) ? null : kh.QuanHe,
                    SoVanPhong = string.IsNullOrEmpty(kh.SoVanPhong) ? null : kh.SoVanPhong,
                    SoNguoiPT = kh.SoNguoiPT,
                    SoHuuNha = string.IsNullOrEmpty(kh.SoHuuNha) ? null : kh.SoHuuNha,
                    LHCuChu = string.IsNullOrEmpty(kh.LHCuChu) ? null : kh.LHCuChu,
                    TinhTrangViecLam = string.IsNullOrEmpty(kh.TinhTrangViecLam) ? null : kh.TinhTrangViecLam,
                    TenCty = string.IsNullOrEmpty(kh.TenCty) ? null : kh.TenCty,
                    ThuNhapHangThang = kh.ThuNhapHangThang
                    ,
                    DiaChiCty = string.IsNullOrEmpty(kh.DiaChiCty) ? null : kh.DiaChiCty,
                };
                dContext.Db.KhachHangs.InsertOnSubmit(khachHang);
                dContext.Db.ChiTietKHCNs.InsertOnSubmit(chiTietKHCN);
            }
            finally
            {
                dContext.Db.SubmitChanges();
            }
        }
        public DataTable InDanhSachKhCaNhan()
        {
            dContext = new Data_Context();
            var xem = dContext.Db.KhachHangs
            .Join(dContext.Db.NganhChinhs,
                  khachHang => khachHang.NganhChinh,
                  n => n.IdNganhChinh,
                  (khachHang, n) => new
                  {
                      Id = khachHang.IdKhachHang,
                      Ten = khachHang.TenKhachHang,
                      DiaChi = khachHang.DiaChi,
                      QuocTich = khachHang.QuocTich,
                      Nganhcn = n.TenNganh,
                      SoGiayTo = khachHang.SoGiayTo
                  })
            .AsEnumerable() // Chuyển đổi sang kiểu IEnumerable để xử lý chuỗi trong C#
            .Select(x => new
            {
                x.Id,
                x.Ten,
                DiaChi = x.DiaChi.Split(',').Length > 2 ? x.DiaChi.Split(',')[2].Trim() : string.Empty,
                x.QuocTich,
                x.Nganhcn,
                x.SoGiayTo
            });
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã khách hàng");
            dt.Columns.Add("Tên khách hàng");
            dt.Columns.Add("Thành phố/Tỉnh");
            dt.Columns.Add("Quốc tịch");
            dt.Columns.Add("Ngành công nghiệp chính");
            dt.Columns.Add("Số giấy tờ");
            foreach (var item in xem)
            {
                dt.Rows.Add(item.Id, item.Ten, item.DiaChi, item.QuocTich, item.Nganhcn, item.SoGiayTo);
            }
            return dt;
        }
        public void SuaKhCaNhan(DTO_ChiTietKHCN kh)
        {
            dContext = new Data_Context();
            var sua = dContext.Db.KhachHangs.Single(khachHang => khachHang.IdKhachHang == kh.IdKhachHang);
            sua.TenKhachHang = kh.TenKhachHang;
            sua.DiaChi = kh.DiaChi;
            sua.SoDienThoai = kh.SoDienThoai;
            sua.QuocGia = kh.QuocGia;
            sua.QuocTich = kh.QuocTich;
            sua.LoaiGiayTo = kh.LoaiGiayTo;
            sua.NoiCap = kh.NoiCap;
            sua.NgayCap = kh.NgayCap;
            sua.NgayHetHan = kh.NgayHetHan;
            sua.Email = kh.Email;
            sua.NganhChinh = kh.NganhChinh;
            sua.IdNganh = kh.IdNganh;
            sua.NhanVienLV = kh.NhanVienLV;


            var sua1 = dContext.Db.ChiTietKHCNs.Single(khachHang => khachHang.IdKhachHangCN == kh.IdKhachHang);
            sua1.GioiTinh = kh.GioiTinh;
            sua1.XungHo = kh.XungHo;
            sua1.TTHonNhan = kh.TTHonNhan;
            sua1.QuanHe = kh.QuanHe;
            sua1.SoVanPhong = kh.QuocTich;
            sua1.SoNguoiPT = kh.SoNguoiPT;
            sua1.SoHuuNha = kh.SoHuuNha;
            sua1.TinhTrangViecLam = kh.TinhTrangViecLam;
            sua1.TenCty = kh.TenCty;
            sua1.ThuNhapHangThang = kh.ThuNhapHangThang;
            sua1.DiaChiCty = kh.DiaChiCty;
            dContext.Db.SubmitChanges();
        }
        public void XoaKhCaNhan(int id)
        {
            dContext = new Data_Context();
            var xoa = dContext.Db.KhachHangs
                .Where(kh => kh.IdKhachHang == id)
                .Select(kh => kh);
            var xoaChitiet = dContext.Db.ChiTietKHCNs
                .Where(kh => kh.IdKhachHangCN == id)
                .Select(kh => kh);
            foreach (var item in xoa)
            {
                dContext.Db.KhachHangs.DeleteOnSubmit(item);
            }
            foreach (var item in xoaChitiet)
            {
                dContext.Db.ChiTietKHCNs.DeleteOnSubmit(item);
            }
            dContext.Db.SubmitChanges();
        }


        //Khách hàng doanh nghiệp
        public DataTable LayDuLieuKHDoanhNghiep()
        {
            dContext = new Data_Context();
            var xem = dContext.Db.KhachHangs
                .Join(dContext.Db.NganhChinhs,
                kh => kh.NganhChinh,
                n => n.IdNganhChinh,
                (kh, n) => new
                {
                    id = kh.IdKhachHang,
                    ten = kh.TenKhachHang,
                    tp = kh.DiaChi,
                    quocTich = kh.QuocTich,
                    nganh = n.TenNganh,
                    soGiayTo = kh.SoGiayTo
                })
                .AsEnumerable()
                .Select(x => new
                {
                    x.id,
                    x.ten,
                    DiaChi = x.tp.Split(',').Length > 2 ? x.tp.Split(',')[2].Trim() : string.Empty,
                    x.quocTich,
                    x.nganh,
                    x.soGiayTo
                });
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã khách hàng");
            dt.Columns.Add("Tên khách hàng");
            dt.Columns.Add("Thành phố/Tỉnh");
            dt.Columns.Add("Quốc tịch");
            dt.Columns.Add("Ngành công nghiệp chính");
            dt.Columns.Add("Số giấy tờ");
            foreach (var item in xem)
            {
                dt.Rows.Add(item.id, item.ten, item.DiaChi, item.quocTich, item.nganh, item.soGiayTo);
            }
            return dt;
        }
        public void ThemKHDoanhNghiep(DTO_ChiTietKHDN kh)
        {
            dContext = new Data_Context();
            try
            {
                // Tạo đối tượng KhachHangDoanhNghiep mới từ dữ liệu của BUS_KhachHangDoanhNghiep
                KhachHang khachHangDN = new KhachHang
                {
                    IdKhachHang = kh.IdKhachHang,
                    TenKhachHang = kh.TenKhachHang,
                    NgaySinh = kh.NgaySinh,
                    DiaChi = kh.DiaChi,
                    QuocGia = string.IsNullOrEmpty(kh.QuocGia) ? null : kh.QuocGia,
                    QuocTich = string.IsNullOrEmpty(kh.QuocTich) ? null : kh.QuocTich,
                    LoaiGiayTo = kh.LoaiGiayTo,
                    SoGiayTo = kh.SoGiayTo,
                    NgayCap = kh.NgayCap,
                    NgayHetHan = kh.NgayHetHan,
                    NoiCap = kh.NoiCap,
                    Email = string.IsNullOrEmpty(kh.Email) ? null : kh.Email,
                    SoDienThoai = string.IsNullOrEmpty(kh.SoDienThoai) ? null : kh.SoDienThoai,
                    NganhChinh = kh.NganhChinh,
                    IdNganh = kh.IdNganh,
                    NhanVienLV = kh.NhanVienLV
                };
                // Tạo đối tượng ChiTietKHDN mới từ dữ liệu của BUS_ChiTietKHDN
                ChiTietKHDN chiTietKHDN = new ChiTietKHDN
                {
                    IdKhachHangDN = kh.IdKhachHang,
                    NgayTao = kh.NgayTao,
                    QuanHe = string.IsNullOrEmpty(kh.QuanHe) ? null : kh.QuanHe,
                    SoVanPhong = string.IsNullOrEmpty(kh.SoVanPhong) ? null : kh.SoVanPhong,
                    TongVon = kh.TongVon,
                    TongTaiSan = kh.TongTaiSan,
                    TongDoanhThu = kh.TongDoanhThu,
                    SoLuongNhanVien = kh.SoLuongNhanVien,
                    ChucVu = kh.ChucVu,
                    NguoiLH = kh.NguoiLH,

                };

                // Thêm đối tượng vào cơ sở dữ liệu
                dContext.Db.ChiTietKHDNs.InsertOnSubmit(chiTietKHDN);

                // Thêm đối tượng vào cơ sở dữ liệu
                dContext.Db.KhachHangs.InsertOnSubmit(khachHangDN);
                dContext.Db.SubmitChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }
        public DTO_ChiTietKHDN LayGiaTriKHDoanhNghiep(int id)
        {
            dContext = new Data_Context();
            var chiTietKhachHang = (from khachHang in dContext.Db.KhachHangs
                                    join chiTiet in dContext.Db.ChiTietKHDNs
                                    on khachHang.IdKhachHang equals chiTiet.IdKhachHangDN
                                    where khachHang.IdKhachHang == id
                                    select new DTO_ChiTietKHDN(
                                        khachHang.IdKhachHang,
                                        khachHang.TenKhachHang,
                                        khachHang.Avarta.ToArray(),
                                        khachHang.NgaySinh,
                                        khachHang.DiaChi,
                                        khachHang.SoDienThoai,
                                        khachHang.QuocGia,
                                        khachHang.QuocTich,
                                        khachHang.LoaiGiayTo,
                                        khachHang.SoGiayTo,
                                        khachHang.NgayCap,
                                        (DateTime)khachHang.NgayHetHan,
                                        khachHang.NoiCap,
                                        khachHang.Email,
                                        khachHang.NganhChinh,
                                        khachHang.IdNganh,
                                        khachHang.NhanVienLV,
                                        chiTiet.IdLoaiKH,
                                        (DateTime)chiTiet.NgayTao,
                                        chiTiet.QuanHe,
                                        chiTiet.SoVanPhong,
                                        (float)chiTiet.TongVon,
                                        (float)chiTiet.TongTaiSan,
                                        (float)chiTiet.TongDoanhThu,
                                        (int)chiTiet.SoLuongNhanVien,
                                        chiTiet.NguoiLH,
                                        chiTiet.ChucVu
                                    )).FirstOrDefault();

            return chiTietKhachHang;
        }
        public void SuaKHDoanhNghiep(DTO_ChiTietKHDN kh)
        {
            dContext = new Data_Context();
            try
            {
                // Tìm đối tượng KhachHangDoanhNghiep cần sửa
                var sua = dContext.Db.KhachHangs.Single(khachHang => khachHang.IdNganh == kh.IdKhachHang);
                sua.TenKhachHang = kh.TenKhachHang;
                sua.NgaySinh = kh.NgaySinh;
                sua.DiaChi = kh.DiaChi;
                sua.QuocGia = kh.QuocGia;
                sua.QuocTich = kh.QuocTich;
                sua.LoaiGiayTo = kh.LoaiGiayTo;
                sua.SoGiayTo = kh.SoGiayTo;
                sua.NgayCap = kh.NgayCap;
                sua.NgayHetHan = kh.NgayHetHan;
                sua.NoiCap = kh.NoiCap;
                sua.Email = kh.Email;
                sua.SoDienThoai = kh.SoDienThoai;
                sua.NganhChinh = kh.NganhChinh;
                sua.IdNganh = kh.IdNganh;
                sua.NhanVienLV = kh.NhanVienLV;

                // Tìm đối tượng ChiTietKHDN cần sửa
                var suaChiTiet = dContext.Db.ChiTietKHDNs.Single(chiTiet => chiTiet.IdKhachHangDN == kh.IdKhachHang);
                suaChiTiet.NgayTao = kh.NgayTao;
                suaChiTiet.QuanHe = kh.QuanHe;
                suaChiTiet.SoVanPhong = kh.SoVanPhong;
                suaChiTiet.TongVon = kh.TongVon;
                suaChiTiet.TongTaiSan = kh.TongTaiSan;
                suaChiTiet.TongDoanhThu = kh.TongDoanhThu;
                suaChiTiet.SoLuongNhanVien = kh.SoLuongNhanVien;
                suaChiTiet.NguoiLH = kh.NguoiLH;
                suaChiTiet.ChucVu = kh.ChucVu;

                // Lưu thay đổi vào cơ sở dữ liệu
                dContext.Db.SubmitChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }
        public void XoaKHDoanhNghiep(int id)
        {
            dContext = new Data_Context();
            var xoa = dContext.Db.KhachHangs
                .Where(kh => kh.IdKhachHang == id)
                .Select(kh => kh);
            var xoaChitiet = dContext.Db.ChiTietKHDNs
                .Where(kh => kh.IdKhachHangDN == id)
                .Select(kh => kh);
            foreach (var item in xoa)
            {
                dContext.Db.KhachHangs.DeleteOnSubmit(item);
            }
            foreach (var item in xoaChitiet)
            {
                dContext.Db.ChiTietKHDNs.DeleteOnSubmit(item);
            }
            dContext.Db.SubmitChanges();
        }
    }
}
