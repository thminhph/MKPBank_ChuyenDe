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
            var sua = db.KhachHangCaNhans.Single(kh => kh.IdKhachHangCN == a.IdKhachHangCN || kh.SoDienThoai==b.SoDienThoai);
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
        public  DTO_ThongTinKH timUserTheostk(long  stk)
        {
           var query = from s in db.KhachHangCaNhans
                        join tk in db.TaiKhoans on s.IdKhachHangCN equals tk.MaKhachHang
                        where tk.IdTaiKhoan==stk
                        select new 
                        {
                            s.Avarta,
                            s.TenKhachHang
                        };


            DTO_ThongTinKH thong = null;
            foreach(var t  in query)
            {
                byte[] img = new byte[0];
                if (t.Avarta != null)
                {
                    img=t.Avarta.ToArray();
                }
               
                string ten =t.TenKhachHang.ToString();
                thong =new DTO_ThongTinKH(img, ten);
            }
            return thong;
        }
        public DTO_ThongTinKH timTHKHstk(long stk)
        {
            var a = from s in db.KhachHangCaNhans
                        
                        join tk in db.TaiKhoans on s.IdKhachHangCN equals tk.MaKhachHang
                        where tk.IdTaiKhoan == stk
                        select new
                        {

                            s.Avarta,
                            s.TenKhachHang,
                            s.SoGiayTo,
                            s.NgaySinh,
                            
                            s.DiaChi,
                            s.NgayCap,
                            s.SoDienThoai,
                            s.Email
                        };


            DTO_ThongTinKH thong=new DTO_ThongTinKH();
            foreach (var t in a)
            {
                byte[] img = new byte[0];
                if (t.Avarta != null)
                {
                    img = t.Avarta.ToArray();
                }

                string ten = t.TenKhachHang.ToString();
                string sogiayto = t.SoGiayTo.ToString();
                DateTime ngaysinh = t.NgaySinh; 
    
                string diachi = t.DiaChi;
                DateTime ngaycap = t.NgayCap;
                string sodienthoai=t.SoDienThoai;
                string email=t.Email;
                thong = new DTO_ThongTinKH( ten,img,ngaysinh,diachi,sodienthoai,sogiayto,ngaycap,email);
            }
            return thong;
        }
    }
}
