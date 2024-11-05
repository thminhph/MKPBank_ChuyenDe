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

        public IQueryable Xem(string conn)
        {
            dContext = new Data_Context();
            var xem = dContext.Db.KhachHangs.Select(kh => kh);
            return xem;
        }
        public DTO_ChiTietKHCN LayGiaTri(int id)
        {
            dContext = new Data_Context();
            var chiTietKhachHang = (from khachHang in dContext.Db.KhachHangs
                                    join chiTiet in dContext.Db.ChiTietKHCNs
                                    on khachHang.IdKhachHang equals chiTiet.IdKhachHangCN
                                    where khachHang.IdKhachHang == id
                                    select new DTO_ChiTietKHCN(
                                        khachHang.IdKhachHang,
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
                                        khachHang.IdNganh,
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

        public void Them(DTO_KhachHang kh)
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
                dContext.Db.KhachHangs.InsertOnSubmit(khachHang);
            }
            finally
            {
                dContext.Db.SubmitChanges();
            }
        }
        public void ThemChiTiet(DTO_ChiTietKHCN kh)
        {
            dContext = new Data_Context();
            try
            {
                ChiTietKHCN chiTietKHCN = new ChiTietKHCN
                {
                    IdKhachHangCN = kh.IdKhachHang,
                    GioiTinh = string.IsNullOrEmpty(kh.GioiTinh) ? null : kh.GioiTinh,
                    XungHo = string.IsNullOrEmpty(kh.XungHo) ? null : kh.XungHo,
                    TTHonNhan = string.IsNullOrEmpty(kh.TTHonNhan) ? null : kh.TTHonNhan,
                    QuanHe = string.IsNullOrEmpty(kh.QuanHe) ? null : kh.QuanHe,
                    SoVanPhong = string.IsNullOrEmpty(kh.SoVanPhong) ? null : kh.SoVanPhong,
                    SoNguoiPT = Math.Max(kh.SoNguoiPT, 0),
                    SoHuuNha = string.IsNullOrEmpty(kh.SoHuuNha) ? null : kh.SoHuuNha,
                    LHCuChu = string.IsNullOrEmpty(kh.LHCuChu) ? null : kh.LHCuChu,
                    TinhTrangViecLam = string.IsNullOrEmpty(kh.TinhTrangViecLam) ? null : kh.TinhTrangViecLam,
                    TenCty = string.IsNullOrEmpty(kh.TenCty) ? null : kh.TenCty,
                    ThuNhapHangThang =Math.Max(kh.ThuNhapHangThang , 0.0),
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
        public DataTable InDanhSach()
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
        public void Sua(DTO_ChiTietKHCN kh)
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
        public void Xoa(int id)
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
    }
}
