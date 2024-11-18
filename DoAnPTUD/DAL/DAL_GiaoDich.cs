using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_GiaoDich
    {
        Data_Context db;
        public DAL_GiaoDich()
        {
            db = new Data_Context();
        }
        public void Them(DTO_GiaoDich t)
        {
            try
            {
                GiaoDich tm = new GiaoDich
                {
                    IdGiaoDich = t.IdGuiTien,
                    IdTaiKhoan = t.IdTK,
                    IdLoaiGD = 2,
                    SoGiaoDich = t.SoGiaoDich,
                    SoDu = t.SoDu,
                    NoiDung = t.NoiDung,
                    NgayGiaoDich = DateTime.Now
                };
                db.Db.GiaoDiches.InsertOnSubmit(tm);
                db.Db.SubmitChanges();
            }
            catch (Exception)
            {

                throw new InvalidOperationException("Thêm thất bại!!!");
            }
        }
        public void CapNhatTien(long idTK, decimal soDu)
        {
            var capNhat = db.Db.SoDuTinDungs
                .Single(sd => sd.IdTaiKhoan == idTK);
            capNhat.SoDuTK = soDu;
            db.Db.SubmitChanges();
        }
        public void TruTienMat(DTO_GiaoDich t)
        {
            try
            {
                GiaoDich tm = new GiaoDich
                {
                    IdGiaoDich = t.IdGuiTien,
                    IdTaiKhoan = t.IdTK,
                    IdLoaiGD = 3,
                    SoGiaoDich = t.SoGiaoDich,
                    SoDu = t.SoDu,
                    NoiDung = t.NoiDung,
                    NgayGiaoDich = DateTime.Now
                };
                db.Db.GiaoDiches.InsertOnSubmit(tm);
                db.Db.SubmitChanges();
            }
            catch (Exception)
            {

                throw new InvalidOperationException("Thêm thất bại!!!");
            }
        }
        public IQueryable HienThiDanhSachGiaoDich(Dictionary<string, string> whereArg)
        {
            // Đồng bộ các thuộc tính bằng cách sử dụng tên chung
            var xem = from gd in db.Db.GiaoDiches
                      select new
                      {
                          gd.IdLoaiGD,
                          gd.IdGiaoDich,
                          gd.TaiKhoan.KhachHang.TenKhachHang,
                          gd.SoGiaoDich,
                          gd.TaiKhoan.LoaiTaiKhoan.IdLoai,
                          gd.TaiKhoan.TienTe,
                          gd.TaiKhoan.KhachHang.IdKhachHang,
                          gd.TaiKhoan.IdTaiKhoan
                      };
            //var xem = khCaNhan
            //    .Union(khDoanhNghiep);
            foreach (var item in whereArg)
            {
                switch (item.Key)
                {
                    case "LoaiGiaoDich":
                        xem = xem.Where(gd => gd.IdLoaiGD == Convert.ToInt64(item.Value));
                        break;
                    case "MaGiaoDich":
                        xem = xem.Where(gd => gd.IdGiaoDich == item.Value);
                        break;
                    case "HoTen":
                        xem = xem.Where(gd => gd.TenKhachHang == item.Value);
                        break;
                    case "Tu":
                        xem = xem.Where(gd => gd.SoGiaoDich >= int.Parse(item.Value));
                        break;
                    case "Den":
                        xem = xem.Where(gd => gd.SoGiaoDich <= int.Parse(item.Value));
                        break;
                    case "LoaiTaiKhoan":
                        xem = xem.Where(gd => gd.IdLoai == int.Parse(item.Value));
                        break;
                    case "TienTe":
                        xem = xem.Where(gd => gd.TienTe == item.Value);
                        break;
                    case "MaKhachHang":
                        xem = xem.Where(gd => gd.IdKhachHang == int.Parse(item.Value));
                        break;
                    case "TaiKhoan":
                        xem = xem.Where(gd => gd.IdTaiKhoan == long.Parse(item.Value));
                        break;
                }
            }
            return xem.Select(gd => new
            {
                gd.IdLoai,
                gd.IdGiaoDich,
                gd.IdTaiKhoan,
                gd.TenKhachHang,
                gd.TienTe,
                gd.SoGiaoDich
            });
        }
    }
}
