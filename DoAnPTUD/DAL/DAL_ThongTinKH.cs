using DTO;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.ComponentModel.Design;

namespace DAL
{
    public class DAL_ThongTinKH
    {

        private QLNganHangDataContext db;
        public DAL_ThongTinKH()
        {
            this.db = new QLNganHangDataContext(Properties.Settings.Default.QLNganHangConnectionString);
        }

        public List<KhachHang> layDSThongTinKH()
        {
            db = new QLNganHangDataContext();
            var thongTinKH = db.KhachHangs.Select(kh => kh).ToList();
            return thongTinKH;
        }
        public void SuaKH(DTO_ThongTinKH a )
        {
            var sua = db.KhachHangs.Single(kh => kh.IdKhachHang == a.IdKhachHang );
            sua.TenKhachHang = a.TenKhachHang;
            sua.Avarta = a.Avarta;
            sua.Email = a.Email;
            sua.NganhChinh = a.NganhChinh;
            sua.IdNganh = a.Nganh;
            db.SubmitChanges();
        }

        public DTO_ThongTinKH timTHKHstk(long stk)
        {

            var a = (from s in db.KhachHangs
                     join tk in db.TaiKhoans on s.IdKhachHang equals tk.IdKhachHang
                     where tk.IdTaiKhoan == stk
                     select new DTO_ThongTinKH
                     {
                         IdKhachHang = s.IdKhachHang,

                         Avarta = s.Avarta.ToArray(),
                         TenKhachHang = s.TenKhachHang,
                         SoGiayTo = s.SoGiayTo,
                         NgaySinh = s.NgaySinh,
                         DiaChi = s.DiaChi,
                         NgayCap = s.NgayCap,
                         SoDienThoai = s.SoDienThoai,
                        Nganh=s.IdNganh,
                        NganhChinh = s.NganhChinh
                     }).FirstOrDefault();

            //DTO_ThongTinKH thong=new DTO_ThongTinKH();
            //foreach (var t in a)
            //{
            //    byte[] img = new byte[0];
            //    if (t.Avarta != null)
            //    {
            //        img = t.Avarta.ToArray();

            //    }

            //    string ten = t.TenKhachHang.ToString();
            //    string sogiayto = t.SoGiayTo.ToString();
            //    DateTime ngaysinh = t.NgaySinh; 
            //    string diachi = t.DiaChi;
            //    DateTime ngaycap = t.NgayCap;
            //    string sodienthoai=t.SoDienThoai;
            //    string email=t.Email;
            //    thong = new DTO_ThongTinKH( ten,img,ngaysinh,diachi,sodienthoai,sogiayto,ngaycap,email);
            //}
            return a;
        }
        public bool ktraSDT(string sDT)
        {
            using (var _db = new QLNganHangDataContext())
            {
                return _db.KhachHangs.Any(tk => tk.SoDienThoai == sDT);
            }
        }
        //public bool ktraMatKhau(string mk,string idTK)
        //{
        //    using (var _db = new QLNganHangDataContext())
        //    {
        //        (from s in db.TaiKhoans
        //         where s.IdTaiKhoan == long.Parse(idTK)
        //         select new {s.Matkhau}).FirstOrDefault();
        //    }
        //    return
        //}
    }
}
