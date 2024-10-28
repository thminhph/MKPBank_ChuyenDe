using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhachHangDoanhNghiep
    {
        Data_Context dContext;
        public DataTable LayDuLieu()
        {
            dContext = new Data_Context();
            var xem = dContext.Db.KhachHangDoanhNghieps
                .Join(dContext.Db.NganhChinhs,
                kh => kh.NganhChinh,
                n => n.IdNganhChinh,
                (kh, n) => new
                {
                    id = kh.IdKhachHangDN,
                    ten = kh.TenVietTatDN,
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
        public void Them(DTO_KhachHangDoanhNghiep kh)
        {
            dContext = new Data_Context();
            try
            {
                // Tạo đối tượng KhachHangDoanhNghiep mới từ dữ liệu của BUS_KhachHangDoanhNghiep
                KhachHangDoanhNghiep khachHangDN = new KhachHangDoanhNghiep
                {
                    IdKhachHangDN = kh.IdKhachHangDN,
                    TenVietTatDN = kh.TenVietTatDN,
                    TenDayDuDN = kh.TenDayDuDN,
                    NgayThanhLap = kh.NgayThanhLap,
                    DiaChi = kh.DiaChi,
                    QuocGia = string.IsNullOrEmpty(kh.QuocGia) ? null : kh.QuocGia,
                    QuocTich = string.IsNullOrEmpty(kh.QuocTich) ? null : kh.QuocTich,
                    LoaiGiayTo = kh.LoaiGiayTo,
                    SoGiayTo = kh.SoGiayTo,
                    NgayCap = kh.NgayCap,
                    NgayHetHan = kh.NgayHetHan,
                    NoiCap = kh.NoiCap,
                    NguoiLH = string.IsNullOrEmpty(kh.NguoiLH) ? null : kh.NguoiLH,
                    ChucVu = string.IsNullOrEmpty(kh.ChucVu) ? null : kh.ChucVu,
                    Email = string.IsNullOrEmpty(kh.Email) ? null : kh.Email,
                    SoDienThoai = string.IsNullOrEmpty(kh.SoDienThoai) ? null : kh.SoDienThoai,
                    NganhChinh = kh.NganhChinh,
                    IdNganh = kh.Nganh,
                    NhanVienLV = kh.NhanVienLV
                };

                // Thêm đối tượng vào cơ sở dữ liệu
                dContext.Db.KhachHangDoanhNghieps.InsertOnSubmit(khachHangDN);
                dContext.Db.SubmitChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }
        public void ThemChiTiet(DTO_ChiTietKHDN kh)
        {
            dContext = new Data_Context();
            try
            {
                // Tạo đối tượng ChiTietKHDN mới từ dữ liệu của BUS_ChiTietKHDN
                ChiTietKHDN chiTietKHDN = new ChiTietKHDN
                {
                    IdKhachHangDN = kh.IdKhachHangDN,
                    NgayTao = kh.NgayTao,
                    QuanHe = string.IsNullOrEmpty(kh.QuanHe) ? null : kh.QuanHe,
                    SoVanPhong = string.IsNullOrEmpty(kh.SoVanPhong) ? null : kh.SoVanPhong,
                    TongVon = kh.TongVon,
                    TongTaiSan = kh.TongTaiSan,
                    TongDoanhThu = kh.TongDoanhThu,
                    SoLuongNhanVien = kh.SoLuongNhanVien
                };

                // Thêm đối tượng vào cơ sở dữ liệu
                dContext.Db.ChiTietKHDNs.InsertOnSubmit(chiTietKHDN);
                dContext.Db.SubmitChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }
        public DTO_ChiTietKHDN LayGiaTri(int id)
        {
            dContext = new Data_Context();
            var chiTietKhachHang = (from khachHang in dContext.Db.KhachHangDoanhNghieps
                                    join chiTiet in dContext.Db.ChiTietKHDNs
                                    on khachHang.IdKhachHangDN equals chiTiet.IdKhachHangDN
                                    where khachHang.IdKhachHangDN == id
                                    select new DTO_ChiTietKHDN(
                                        khachHang.IdKhachHangDN,
                                        khachHang.TenVietTatDN,
                                        khachHang.TenDayDuDN,
                                        khachHang.NgayThanhLap,
                                        khachHang.DiaChi,
                                        khachHang.QuocGia,
                                        khachHang.QuocTich,
                                        khachHang.LoaiGiayTo,
                                        khachHang.SoGiayTo,
                                        khachHang.NgayCap,
                                        khachHang.NgayHetHan,
                                        khachHang.NoiCap,
                                        khachHang.NguoiLH,
                                        khachHang.ChucVu,
                                        khachHang.Email,
                                        khachHang.SoDienThoai,
                                        khachHang.NganhChinh,
                                        khachHang.IdNganh,
                                        khachHang.NhanVienLV,
                                        (DateTime)chiTiet.NgayTao,
                                        chiTiet.QuanHe,
                                        chiTiet.SoVanPhong,
                                        (float)chiTiet.TongVon,
                                        (float)chiTiet.TongTaiSan,
                                        (float)chiTiet.TongDoanhThu,
                                        (int)chiTiet.SoLuongNhanVien
                                    )).FirstOrDefault();

            return chiTietKhachHang;
        }
        public void Sua(DTO_ChiTietKHDN kh)
        {
            dContext = new Data_Context();
            try
            {
                // Tìm đối tượng KhachHangDoanhNghiep cần sửa
                var sua = dContext.Db.KhachHangDoanhNghieps.Single(khachHang => khachHang.IdKhachHangDN == kh.IdKhachHangDN);
                sua.TenVietTatDN = kh.TenVietTatDN;
                sua.TenDayDuDN = kh.TenDayDuDN;
                sua.NgayThanhLap = kh.NgayThanhLap;
                sua.DiaChi = kh.DiaChi;
                sua.QuocGia = kh.QuocGia;
                sua.QuocTich = kh.QuocTich;
                sua.LoaiGiayTo = kh.LoaiGiayTo;
                sua.SoGiayTo = kh.SoGiayTo;
                sua.NgayCap = kh.NgayCap;
                sua.NgayHetHan = kh.NgayHetHan;
                sua.NoiCap = kh.NoiCap;
                sua.NguoiLH = kh.NguoiLH;
                sua.ChucVu = kh.ChucVu;
                sua.Email = kh.Email;
                sua.SoDienThoai = kh.SoDienThoai;
                sua.NganhChinh = kh.NganhChinh;
                sua.IdNganh = kh.Nganh;
                sua.NhanVienLV = kh.NhanVienLV;

                // Tìm đối tượng ChiTietKHDN cần sửa
                var suaChiTiet = dContext.Db.ChiTietKHDNs.Single(chiTiet => chiTiet.IdKhachHangDN == kh.IdKhachHangDN);
                suaChiTiet.NgayTao = kh.NgayTao;
                suaChiTiet.QuanHe = kh.QuanHe;
                suaChiTiet.SoVanPhong = kh.SoVanPhong;
                suaChiTiet.TongVon = kh.TongVon;
                suaChiTiet.TongTaiSan = kh.TongTaiSan;
                suaChiTiet.TongDoanhThu = kh.TongDoanhThu;
                suaChiTiet.SoLuongNhanVien = kh.SoLuongNhanVien;

                // Lưu thay đổi vào cơ sở dữ liệu
                dContext.Db.SubmitChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }
        public void Xoa(int id)
        {
            dContext = new Data_Context();
            var xoa = dContext.Db.KhachHangDoanhNghieps
                .Where(kh => kh.IdKhachHangDN == id)
                .Select(kh => kh);
            var xoaChitiet = dContext.Db.ChiTietKHDNs
                .Where(kh => kh.IdKhachHangDN == id)
                .Select(kh => kh);
            foreach (var item in xoa)
            {
                dContext.Db.KhachHangDoanhNghieps.DeleteOnSubmit(item);
            }
            foreach (var item in xoaChitiet)
            {
                dContext.Db.ChiTietKHDNs.DeleteOnSubmit(item);
            }
            dContext.Db.SubmitChanges();
        }


    }
}
