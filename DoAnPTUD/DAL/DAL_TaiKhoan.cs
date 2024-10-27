using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Collections;
using System.Data;


namespace DAL
{
    public class DAL_TaiKhoan
    {
       
        private QLNganHangDataContext  db;

        public DAL_TaiKhoan()
        {
            this.db = new QLNganHangDataContext(Properties.Settings.Default.QLNganHangConnectionString);
        }
        public IQueryable layDSTaiKhoan()
        {
            IQueryable taiKhoan = from s in db.TaiKhoans
                                   select new
                                   {
                                       s.IdTaiKhoan,
                                       s.MaKhachHang,
                                       s.LoaiTaiKhoan,
                                       s.TenTaiKhoan,
                                       s.TienTe,
                                       s.TieuDeTK,
                                       s.TieuDeNgan,
                                       s.NhanVienLV,
                                       s.PhiMa,
                                       s.Matkhau
                                   };
            return taiKhoan;
        }
        
        public IQueryable TimSTK(string sDT )
        {
            IQueryable temp = from s in db.KhachHangCaNhans
                              join tk in db.TaiKhoans on s.IdKhachHangCN equals tk.MaKhachHang
                              where s.SoDienThoai.CompareTo(sDT) == 0
                              select tk;
            return temp;
        }

        public bool DangNhap(string sDT, string matKhau)
        {
            bool temp = (from s in db.KhachHangCaNhans
                         join tk in db.TaiKhoans on s.IdKhachHangCN equals tk.MaKhachHang
                         where s.SoDienThoai.CompareTo(sDT) == 0 && tk.Matkhau.CompareTo(matKhau)==0
                         select tk).Any();
            return temp;
        }
        public bool DangKy(DTO_TaiKhoan newTK, DTO_ThongTinKH newKH)
        {
            try
            {
                TaiKhoan tk = new TaiKhoan();
                {
                    tk.IdTaiKhoan = newTK.IdTaiKhoan;
                    tk.MaKhachHang = newTK.MaKhachHang;
                    tk.LoaiTaiKhoan = newTK.LoaiTaiKhoan;
                    tk.TenTaiKhoan = newTK.TenTaiKhoan;
                    tk.TienTe = newTK.TienTe;
                    tk.TieuDeTK = newTK.TieuDeTK;
                    tk.TieuDeNgan = newTK.TieuDeNgan;
                    tk.NhanVienLV = newTK.NhanVienLV;
                    tk.PhiMa = newTK.PhiMa;
                    tk.Matkhau = newTK.MatKhau;
                    db.TaiKhoans.InsertOnSubmit(tk);
                    db.SubmitChanges();
                }

                KhachHangCaNhan kh = new KhachHangCaNhan();
                {
                    kh.Avarta = newKH.Avarta;
                    kh.NgaySinh = newKH.NgaySinh;
                    kh.DiaChi = newKH.DiaChi;
                    kh.QuocGia = newKH.QuocGia;
                    kh.QuocTich = newKH.QuocTich;
                    kh.LoaiGiayTo = newKH.LoaiGiayTo;
                    kh.SoGiayTo = newKH.SoGiayTo;
                    kh.NgayCap = newKH.NgayCap;
                    kh.NgayHetHan = newKH.NgayHetHan;
                    kh.NoiCap = newKH.NoiCap;
                    kh.Email = newKH.Email;
                    kh.NganhChinh = newKH.NganhChinh;
                    kh.IdNganh = newKH.Nganh;
                    kh.NhanVienLV = newKH.NhanVienLV;
                    db.KhachHangCaNhans.InsertOnSubmit(kh);
                    db.SubmitChanges();
                }

                    return true;
            }
            
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
