using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhachHangCaNhan
    {
        Data_Context dContext;

        public IQueryable Xem(string conn)
        {
            dContext = new Data_Context(conn);
            var xem = dContext.Db.KhachHangCaNhans.Select(kh => kh);
            return xem;
        }
        public DTO_ChiTietKHCN LayGiaTri(int id, string conn)
        {
            dContext = new Data_Context(conn);
            var chiTietKhachHang = (from khachHang in dContext.Db.KhachHangCaNhans
                                    join chiTiet in dContext.Db.ChiTietKHCNs
                                    on khachHang.IdKhachHangCN equals chiTiet.IdKhachHangCN
                                    where khachHang.IdKhachHangCN == id
                                    select new DTO_ChiTietKHCN(
                                        khachHang.IdKhachHangCN,
                                        khachHang.TenKhachHang,
                                        khachHang.DiaChi,
                                        khachHang.SoDienThoai,
                                        khachHang.QuocGia,
                                        khachHang.QuocTich,
                                        khachHang.LoaiGiayTo,
                                        khachHang.SoGiayTo,
                                        khachHang.NoiCap,
                                        khachHang.Email,
                                        khachHang.NganhChinh,
                                        khachHang.Nganh,
                                        khachHang.NhanVienLV,
                                        khachHang.NgaySinh,
                                        khachHang.NgayCap,
                                        (DateTime)khachHang.NgayHetHan,
                                        chiTiet.GioiTinh,
                                        chiTiet.XungHo,
                                        chiTiet.TTHonNhan,
                                        chiTiet.QuanHe,
                                        chiTiet.SoVanPhong,
                                        chiTiet.SoNguoiPT,
                                        chiTiet.SoHuuNha,
                                        chiTiet.LHCuChu,
                                        chiTiet.TinhTrangViecLam,
                                        chiTiet.TenCty,
                                        chiTiet.ThuNhapHangThang,
                                        chiTiet.DiaChiCty
                                    )).FirstOrDefault();

            return chiTietKhachHang;
        }

        public void Them(DTO_KhachHangCaNhan kh, string conn)
        {
            dContext = new Data_Context(conn);
            try
            {
                KhachHangCaNhan khachHang = new KhachHangCaNhan
                {
                    IdKhachHangCN = kh.Id,
                    DiaChi = kh.DiaChi,
                    Email = kh.Email,
                    LoaiGiayTo = kh.LoaiGiayTo,
                    Nganh = kh.Nganh,
                    NgayCap = kh.NgayCap,
                    NganhChinh = kh.NganhChinh,
                    NgaySinh = kh.NgaySinh,
                    NgayHetHan = kh.NgayHetHan,
                    QuocGia = string.IsNullOrEmpty(kh.QuocGia) ? null : kh.QuocGia,
                    NoiCap = kh.NoiCap,
                    SoDienThoai = string.IsNullOrEmpty(kh.Sdt) ? null : kh.Sdt,
                    QuocTich = string.IsNullOrEmpty(kh.QuocTich) ? null : kh.QuocTich,
                    TenKhachHang = kh.TenKhachHang,
                    NhanVienLV = string.IsNullOrEmpty(kh.NhanVienLV) ? null : kh.NhanVienLV,
                    SoGiayTo = kh.SoGiayTo,

                };
                dContext.Db.KhachHangCaNhans.InsertOnSubmit(khachHang);
            }
            finally
            {
                dContext.Db.SubmitChanges();
            }
        }
        public void ThemChiTiet(DTO_ChiTietKHCN kh, string conn)
        {
            dContext = new Data_Context(conn);
            try
            {
                ChiTietKHCN chiTietKHCN = new ChiTietKHCN
                {
                    IdKhachHangCN = kh.Id,
                    GioiTinh = string.IsNullOrEmpty(kh.GioiTinh) ? null : kh.GioiTinh,
                    XungHo = string.IsNullOrEmpty(kh.XungHo) ? null : kh.XungHo,
                    TTHonNhan = string.IsNullOrEmpty(kh.TTHonNhan) ? null : kh.TTHonNhan,
                    QuanHe = string.IsNullOrEmpty(kh.QuanHe) ? null : kh.QuanHe,
                    SoVanPhong = string.IsNullOrEmpty(kh.SoVanPhong) ? null : kh.SoVanPhong,
                    SoNguoiPT = kh.SoNguoiPT ?? 0,
                    SoHuuNha = string.IsNullOrEmpty(kh.SoHuuNha) ? null : kh.SoHuuNha,
                    LHCuChu = string.IsNullOrEmpty(kh.LHCuChu) ? null : kh.LHCuChu,
                    TinhTrangViecLam = string.IsNullOrEmpty(kh.TinhTrangViecLam) ? null : kh.TinhTrangViecLam,
                    TenCty = string.IsNullOrEmpty(kh.TenCty) ? null : kh.TenCty,
                    ThuNhapHangThang = kh.ThuNhapHangThang ?? 0.0,
                    DiaChiCty = string.IsNullOrEmpty(kh.DiaChiCty) ? null : kh.DiaChiCty,
                };
                dContext.Db.ChiTietKHCNs.InsertOnSubmit(chiTietKHCN);
                dContext.Db.SubmitChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }
        public DataTable InDanhSach(string conn)
        {
            dContext = new Data_Context(conn);
            var xem = dContext.Db.KhachHangCaNhans
            .Join(dContext.Db.NganhChinhs,
                  khachHang => khachHang.NganhChinh,
                  n => n.IdNganhChinh,
                  (khachHang, n) => new
                  {
                      Id = khachHang.IdKhachHangCN,
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
    }
}
