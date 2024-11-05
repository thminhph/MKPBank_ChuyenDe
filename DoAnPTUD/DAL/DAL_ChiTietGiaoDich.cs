using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_ChiTietGiaoDich
    {
        private QLNganHangDataContext db;
        public DAL_ChiTietGiaoDich() {
            this.db = new QLNganHangDataContext(Properties.Settings.Default.QLNganHangConnectionString);
        }
        public IQueryable laydsCTGD(){
            IQueryable gd = from s in db.ChiTietGDs
                            select s;
            return gd;
            }
        public string tim (string   tk)
        {
            var qr =(from s in db.KhachHangs 
                     join b in db.TaiKhoans on s.IdKhachHang equals b.IdKhachHang
                     where  s.SoDienThoai==tk
                     select new {
                        s.TenKhachHang
                        }).ToList();
            foreach (var s in qr) {
                return s.TenKhachHang;
            }

            return null;  
        }
        public bool giaoDich(string nc ,string nn,float sotien ,string diengia) {

            var khchuyen = db.KhachHangs.FirstOrDefault(kh => kh.SoDienThoai == nc);
            var tknguoichuyen = khchuyen?.TaiKhoans.FirstOrDefault();
            var khnhan = db.KhachHangs.FirstOrDefault(kh => kh.SoDienThoai == nn);
            var tknguoinhan = khnhan?.TaiKhoans.FirstOrDefault();
            
            if( tknguoichuyen.SoDuTinDung.SoDuTK.Value >= sotien)
            {
                tknguoichuyen.SoDuTinDung.SoDuTK -= sotien;
                tknguoinhan.SoDuTinDung.SoDuTK += sotien;

                ChiTietGD chiTiet = new ChiTietGD
                {
                    SoTKNguoiChuyen = tknguoichuyen.IdTaiKhoan,
                    SoTKNguoiNhan = tknguoinhan.IdTaiKhoan, 
                    SoTien =sotien,
                    NgayGio = DateTime.Now,
                    DienGia =diengia
                };
                db.ChiTietGDs.InsertOnSubmit(chiTiet);
                db.SubmitChanges();
                Console.WriteLine("Giao Dịch Thành Công");
                return true; 
            }
            else
            {
                Console.WriteLine("Giao Dịch Thất Bại ");
            }
            return false;

        } 
    }
}
