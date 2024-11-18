using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_LoadValue
    {
        Data_Context dContext;
        public IQueryable XemNganhChinh()
        {
            dContext = new Data_Context();
            var xem = dContext.Db.NganhChinhs.Select(n => n);
            return xem;
        }
        public IQueryable XemNganh(int maNganhChinh)
        {
            dContext = new Data_Context();
            var xem = dContext.Db.Nganhs
                .Where(n => n.IdNganhChinh == maNganhChinh)
                .Select(n => n);
            return xem;
        }
        public IQueryable XemNhanVien()
        {
            dContext = new Data_Context();
            var xem = dContext.Db.NhanViens.Select(n => n);
            return xem;
        }
        public string LayTenNV(string idNV)
        {
            dContext = new Data_Context();
            var xem = dContext.Db.NhanViens
                .Where(nv => nv.IdNhanVien == idNV)
                .Select(n => new
                {
                    ten = n.HoTen
                }).ToList();
            if (xem.Any())
            {
                return xem[0].ten;
            }
            else
            {
                return null;
            }
        }
        public string LayTenNganhChinh(int id)
        {
            dContext = new Data_Context();
            var xem = dContext.Db.NganhChinhs
                .Where(n => n.IdNganhChinh == id)
                .Select(n => new
                {
                    tenNganh = n.TenNganh
                }).ToList();
            if (xem.Any())
            {
                return xem[0].tenNganh;
            }
            else
            {
                return null;
            }
        }
        public string LayTenNganh(int id)
        {
            dContext = new Data_Context();
            var xem = dContext.Db.Nganhs
                .Where(n => n.IdNganh == id)
                .Select(n => new
                {
                    tenNganh = n.TenNganh
                }).ToList();
            if (xem.Any())
            {
                return xem[0].tenNganh;
            }
            else
            {
                return null;
            }
        }
        public List<DTO_KhachHang> HienThiDanhSachKH()
        {
            dContext = new Data_Context();
            var xem = dContext.Db.KhachHangs
                .Select(kh => new DTO_KhachHang
                {
                    IdKhachHang = kh.IdKhachHang,
                    TenKhachHang = kh.TenKhachHang,
                    IdLoaiKH = (int)kh.IdLoaiKH,
                }).ToList();
            return xem;
        }
        public IQueryable HienThiDanhSachKH(Dictionary<string, string> whereArg)
        {
            dContext = new Data_Context();
            // Đồng bộ các thuộc tính bằng cách sử dụng tên chung
            var xem = from kh in dContext.Db.KhachHangs
                      select new
                      {
                          kh.IdKhachHang,
                          kh.LoaiKhachHang.TenLoai,
                          kh.TenKhachHang,
                          kh.SoGiayTo,
                          kh.SoDienThoai,
                          kh.NganhChinh,
                          kh.IdNganh
                      };
            //var xem = khCaNhan
            //    .Union(khDoanhNghiep);
            foreach (var item in whereArg)
            {
                switch (item.Key)
                {
                    case "Loai":
                        xem = xem.Where(kh => kh.TenLoai == item.Value);
                        break;
                    case "IdKhachHang":
                        xem = xem.Where(kh => kh.IdKhachHang == Convert.ToInt32(item.Value));
                        break;
                    case "Ten":
                        xem = xem.Where(kh => kh.TenKhachHang == item.Value);
                        break;
                    case "SoGiayTo":
                        xem = xem.Where(kh => kh.SoGiayTo == item.Value);
                        break;
                    case "SoDienThoai":
                        xem = xem.Where(kh => kh.SoDienThoai == item.Value);
                        break;
                    case "NganhChinh":
                        xem = xem.Where(kh => kh.NganhChinh == Convert.ToInt32(item.Value));
                        break;
                    case "IdNganh":
                        xem = xem.Where(kh => kh.IdNganh == Convert.ToInt32(item.Value));
                        break;
                }
            }
            return xem;
        }


        public IQueryable XemDSLoaiTK()
        {
            dContext = new Data_Context();
            return dContext.Db.LoaiTaiKhoans.Where(l => l.TenLoai != "Tiết kiệm có kỳ hạn").Select(l => l);
        }

        public List<string> LayThongTinKhachHang(long id,int loaiTK)
        {
            dContext = new Data_Context();
            var xem = (from kh in dContext.Db.KhachHangs
                       join tk in dContext.Db.TaiKhoans
                       on kh.IdKhachHang equals tk.IdKhachHang
                       where tk.IdTaiKhoan == id && tk.IdLoai == loaiTK
                       select new
                       {
                           kh.IdKhachHang,
                           kh.TenKhachHang,
                           tk.TieuDeTK,
                           tk.TienTe,
                           tk.SoDuTinDung.SoDuTK
                       }).FirstOrDefault();
            if (xem != null)
            {
                List<string> list = new List<string>();
                list.Add(xem.IdKhachHang.ToString());
                list.Add(xem.TenKhachHang);
                list.Add(xem.TieuDeTK);
                list.Add(xem.TienTe);
                list.Add(xem.SoDuTK.ToString());
                return list;
            }

            return null;
        }

        public IQueryable DanhSachLoaiKH()
        {
            dContext = new Data_Context();
            return dContext.Db.LoaiKhachHangs.Select(tk => tk);
        }

        public IQueryable DanhSachTaiKhoan()
        {
            dContext = new Data_Context();
            var xem = dContext.Db.TaiKhoans
                .Select(tk => new
                {
                    tk.IdTaiKhoan,
                    tk.KhachHang.TenKhachHang,
                    tk.TienTe
                });
            return xem;
        }

        public DTO_TaiKhoan LayThongTinTK(long id)
        {
            dContext = new Data_Context();
            var lay = dContext.Db.TaiKhoans
                .Where(tk => tk.IdTaiKhoan == id)
                .Select(tk => new DTO_TaiKhoan
                {
                    IdTaiKhoan = tk.IdTaiKhoan,
                    MaKhachHang = (int)tk.IdKhachHang,
                    IdLoai = tk.IdLoai,
                    TienTe = tk.TienTe,
                    TieuDeTK = tk.TieuDeTK,
                    TieuDeNgan = tk.TieuDeNgan,
                    NhanVienLV = tk.NhanVienLV,
                    PhiMa = tk.PhiMa,
                    Matkhau = tk.Matkhau
                }).FirstOrDefault();
            return lay;
        }
        public DTO_ThamGiaTK LayThongTinKHTG(long id)
        {
            long a = id;
            dContext = new Data_Context();
            var lay = dContext.Db.ThamGiaTKs
                .Where(tk => tk.IdTaiKhoan == long.Parse(id.ToString()))
                .Select(tk => new DTO_ThamGiaTK
                {
                    IdTK = tk.IdKhachHang,
                    NoiDung = tk.GhiChu,
                }).FirstOrDefault();

            return lay;

        }
        public IQueryable HienThiDanhSachTK(Dictionary<string, string> whereArg)
        {
            dContext = new Data_Context();
            // Đồng bộ các thuộc tính bằng cách sử dụng tên chung
            var xem = from kh in dContext.Db.TaiKhoans
                      select new
                      {
                          kh.IdTaiKhoan,
                          kh.KhachHang.IdLoaiKH,
                          kh.KhachHang.TenKhachHang,
                          kh.IdLoai,
                          kh.IdKhachHang,
                          kh.TienTe,
                          kh.KhachHang.SoGiayTo
                      };
            //var xem = khCaNhan
            //    .Union(khDoanhNghiep);
            foreach (var item in whereArg)
            {
                switch (item.Key)
                {
                    case "MaTK":
                        xem = xem.Where(kh => kh.IdTaiKhoan == Convert.ToInt64(item.Value));
                        break;
                    case "LoaiKH":
                        xem = xem.Where(kh => kh.IdLoaiKH == Convert.ToInt32(item.Value));
                        break;
                    case "Ten":
                        xem = xem.Where(kh => kh.TenKhachHang == item.Value);
                        break;
                    case "SoGiayTo":
                        xem = xem.Where(kh => kh.SoGiayTo == item.Value);
                        break;
                    case "LoaiTK":
                        xem = xem.Where(kh => kh.IdLoai == Convert.ToInt32(item.Value));
                        break;
                    case "TienTe":
                        xem = xem.Where(kh => kh.TienTe == item.Value);
                        break;
                    case "MaKH":
                        xem = xem.Where(kh => kh.IdKhachHang == Convert.ToInt32(item.Value));
                        break;
                }
            }
            return xem;
        }
        public List<DTO_KhachHang> NguoiThamGiaTK(int idKH)
        {
            dContext = new Data_Context();
            var xem = dContext.Db.KhachHangs
                .Where(kh => kh.IdKhachHang != idKH)
                .Select(kh => new DTO_KhachHang
                {
                    IdKhachHang = kh.IdKhachHang,
                    TenKhachHang = kh.TenKhachHang,
                    IdLoaiKH = (int)kh.IdLoaiKH,
                }).ToList();
            return xem;
        }
        private string[] Units = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
        private string[] Tens = { "", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
        private string[] BigUnits = { "", "nghìn", "triệu", "tỷ" };
        public DataTable InPhieuNopTien(string maGD)
        {
            dContext = new Data_Context();
            var lay = from gt in dContext.Db.GiaoDiches
                      where gt.IdGiaoDich == maGD
                      let soGD = ConvertToWords((float)gt.SoGiaoDich)
                      select new
                      {
                          gt.IdGiaoDich,
                          gt.IdTaiKhoan,
                          gt.TaiKhoan.KhachHang.TenKhachHang,
                          gt.TaiKhoan.KhachHang.DiaChi,
                          gt.TaiKhoan.KhachHang.SoGiayTo,
                          gt.TaiKhoan.KhachHang.NgayCap,
                          gt.TaiKhoan.KhachHang.NoiCap,
                          gt.SoDu,
                          gt.NoiDung,
                          gt.SoGiaoDich,
                          gt.NgayGiaoDich,
                          soGD
                      };
            DataTable dt = new DataTable();
            dt.Columns.Add("IdGuiTien");
            dt.Columns.Add("IdTaiKhoan");
            dt.Columns.Add("TenKH");
            dt.Columns.Add("DiaChi");
            dt.Columns.Add("SoGiayTo");
            dt.Columns.Add("NgayCap");
            dt.Columns.Add("NoiCap");
            dt.Columns.Add("SoTienGhiCo");
            dt.Columns.Add("NoiDung");
            dt.Columns.Add("SoTienNop");
            dt.Columns.Add("NgayGiaoDich");
            dt.Columns.Add("SoDuChu");
            foreach (var item in lay)
            {
                dt.Rows.Add(item.IdGiaoDich, item.IdTaiKhoan, item.TenKhachHang, item.DiaChi, item.SoGiayTo, item.NgayCap, item.NoiCap, item.SoDu, item.NoiDung, item.SoGiaoDich, item.NgayGiaoDich, item.soGD);
            }
            return dt;
        }
        public IQueryable XemGuiTienMat()
        {
            dContext = new Data_Context();
            var xem = dContext.Db.GiaoDiches
                .Where(gd => gd.IdLoaiGD == 2)
                .Select(gd => new
                {
                    gd.IdGiaoDich,
                    gd.LoaiGiaoDich.TenLoaiGD,
                    gd.IdTaiKhoan,
                    gd.SoGiaoDich,
                    SoTienCu = gd.SoDu - gd.SoGiaoDich,
                    SoTienMoi = gd.SoDu
                });
            return xem;
        }
        
        public DTO_GiaoDich LayChiTietGT(string idTienMat)
        {

            dContext = new Data_Context();
            var lay = (from x in dContext.Db.GiaoDiches
                       where x.IdGiaoDich == idTienMat
                       select new DTO_GiaoDich
                       {
                           IdGuiTien = x.IdGiaoDich,
                           IdTK = (long)x.IdTaiKhoan,
                           SoGiaoDich = (decimal)x.SoGiaoDich,
                           SoDu = (decimal)x.SoDu,
                           NoiDung = x.NoiDung
                       }).FirstOrDefault();
            return lay;
        }
        public string ConvertToWords(double number)
        {
            if (number == 0) return "không đồng";

            string result = "";
            int bigUnitIndex = 0;

            long integerPart = (long)number;
            int fractionPart = (int)((number - integerPart) * 100); // Lấy phần thập phân (2 chữ số)

            // Chuyển đổi phần nguyên
            while (integerPart > 0)
            {
                int threeDigits = (int)(integerPart % 1000);
                integerPart /= 1000;

                if (threeDigits > 0)
                {
                    string threeDigitsText = ConvertThreeDigitsToWords(threeDigits);
                    result = $"{threeDigitsText} {BigUnits[bigUnitIndex]} {result}".Trim();
                }

                bigUnitIndex++;
            }

            result = result.Trim() + " đồng";

            // Thêm phần thập phân nếu có
            if (fractionPart > 0)
            {
                result += $" và {ConvertThreeDigitsToWords(fractionPart)} xu";
            }

            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(result.Trim());
        }

        private string ConvertThreeDigitsToWords(int number)
        {
            int hundreds = number / 100;
            int tens = (number % 100) / 10;
            int units = number % 10;

            string result = "";

            if (hundreds > 0)
            {
                result += Units[hundreds] + " trăm";
            }

            if (tens > 0)
            {
                result += " " + Tens[tens];
            }
            else if (hundreds > 0 && units > 0)
            {
                result += " lẻ";
            }

            if (units > 0)
            {
                result += " " + Units[units];
            }

            return result.Trim();
        }


        public IQueryable HienThiDanhSachTKTK(Dictionary<string, string> whereArg)
        {
            dContext = new Data_Context();
            // Đồng bộ các thuộc tính bằng cách sử dụng tên chung
            var xem = from kh in dContext.Db.TaiKhoans
                      where kh.IdLoai == 4
                      select new
                      {
                          kh.IdTaiKhoan,
                          kh.IdKhachHang,
                          kh.TienTe,
                          kh.SoDuTinDung.SoDuTK
                      };
            //var xem = khCaNhan
            //    .Union(khDoanhNghiep);
            foreach (var item in whereArg)
            {
                switch (item.Key)
                {
                    case "TietKiem":
                        xem = xem.Where(kh => kh.IdTaiKhoan == Convert.ToInt64(item.Value));
                        break;
                    case "Tu":
                        xem = xem.Where(kh => kh.SoDuTK >= decimal.Parse(item.Value));
                        break;
                    case "Den":
                        xem = xem.Where(kh => kh.SoDuTK <= decimal.Parse(item.Value));
                        break;
                    case "KhachHang":
                        xem = xem.Where(kh => kh.IdKhachHang == Convert.ToInt32(item.Value));
                        break;
                }
            }
            return xem;
        }
        public IQueryable DanhSachLoaiTK()
        {
            dContext = new Data_Context();
            return dContext.Db.LoaiTaiKhoans.Select(ltk => ltk);
        }
        public int LayIdLoaiTK(long idTK)
        {
            dContext = new Data_Context();
            var id = dContext.Db.TaiKhoans
                .Where(l => l.IdTaiKhoan == idTK)
                .Select(l => l.IdLoai)
                .FirstOrDefault();
            return id;
        }
        public IQueryable DanhSachLoaiGD()
        {
            dContext = new Data_Context();
            var xem = dContext.Db.LoaiGiaoDiches.Select(ltk => ltk);
            return xem;
        }
        public IQueryable DanhSachRutTien()
        {
            dContext = new Data_Context();
            var xem = dContext.Db.GiaoDiches
                .Where(gd => gd.IdLoaiGD == 3)
                .Select(gd => new
                {
                    gd.IdGiaoDich,
                    gd.LoaiGiaoDich.TenLoaiGD,
                    gd.IdTaiKhoan,
                    gd.SoGiaoDich,
                    SoTienCu = gd.SoDu - gd.SoGiaoDich,
                    SoTienMoi = gd.SoDu
                });
            return xem;
        }
    }
}
