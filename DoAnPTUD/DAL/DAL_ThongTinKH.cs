using DTO;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DAL
{
    public  class DAL_ThongTinKH
    {

        private QLNganHangDataContext db;
         public DAL_ThongTinKH()
        {
            this.db = new QLNganHangDataContext(Properties.Settings.Default.QLNganHangConnectionString);
        }
        public IQueryable layDSThongTinKH()
        {
            IQueryable thongTinKH = from s in db.KhachHangCaNhans 
                                    join h in db.Nganhs on s.IdNganh equals h.IdNganh
                                    select new
                                    {
                                        s.IdKhachHangCN,
                                        s.TenKhachHang,
                                        s.Avarta,
                                        s.NgaySinh,
                                        s.DiaChi,
                                        s.SoDienThoai,
                                        s.QuocGia,
                                        s.QuocTich,
                                        s.LoaiGiayTo,
                                        s.SoGiayTo,
                                        s.NgayCap,
                                        s.NgayHetHan,
                                        s.NoiCap,
                                        s.Email,
                                        s.NganhChinh,
                                        h.IdNganh,
                                        s.NhanVienLV
                                    };
            return thongTinKH;
        }
        public void SuaKH(DTO_ThongTinKH a , DTO_ThongTinKH b)
        {
            var sua = db.KhachHangCaNhans.Single(kh => kh.IdKhachHangCN == a.IdKhachHangCN || kh.SoDienThoai==b.SoDienThoai.ToString());
            sua.TenKhachHang = a.TenKhachHang;
            sua.Avarta = a.Avarta;
            sua.NgaySinh = a.NgaySinh;
            sua.DiaChi = a.DiaChi;
            sua.QuocGia = a.QuocGia;
            sua.QuocTich = a.QuocTich;
            sua.LoaiGiayTo= a.LoaiGiayTo;
            sua.SoGiayTo = a.SoGiayTo;
            sua.NgayCap= a.NgayCap;
            sua.NgayHetHan= a.NgayHetHan;
            sua.NoiCap= a.NoiCap;
            sua.Email= a.Email;
            sua.NganhChinh= a.NganhChinh;
            sua.IdNganh=a.Nganh;
            sua.NhanVienLV = a.NhanVienLV;
            db.SubmitChanges();
        }
        public IQueryable timUserTheostk(DTO_ThongTinKH  stk)
        {
            IQueryable temp = from s in db.KhachHangCaNhans
                              where s.IdKhachHangCN == stk.IdKhachHangCN
                              select s;
            return temp;

        }
    }
}
