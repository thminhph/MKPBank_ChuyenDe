using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Collections;
using System.Windows.Forms;


namespace DAL
{
    public class DAL_TaiKhoan
    {


        private QLNganHangDataContext db;

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
                                      s.IdKhachHang,
                                      s.LoaiTaiKhoan,
                                      s.TienTe,
                                      s.TieuDeTK,
                                      s.TieuDeNgan,
                                      s.NhanVienLV,
                                      s.PhiMa,
                                      s.Matkhau
                                  };
            return taiKhoan;
        }
        public List<DTO_LoaiKhachHang> LayDanhSachLoaiTK()
        {
            try
            {
                var danhSachLoaiTK = (from qg in db.LoaiTaiKhoans

                                      select new DTO_LoaiKhachHang
                                      {
                                          IdLoai = qg.IdLoai,
                                          TenLoai = qg.TenLoai
                                      }).ToList();
                return danhSachLoaiTK;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách quốc gia: " + ex.Message);
            }
        }
        public DTO_ThongTinKH timUserTheostk(string stk)
        {
            var query = (from s in db.KhachHangs
                         join tk in db.TaiKhoans on s.IdKhachHang equals tk.IdKhachHang
                         where tk.IdTaiKhoan == long.Parse(stk)
                         select new DTO_ThongTinKH
                         {
                             IdKhachHang = s.IdKhachHang,
                             Avarta = s.Avarta == null ? null : s.Avarta.ToArray(),
                             TenKhachHang = s.TenKhachHang,
                             NgayCap = s.NgayCap,
                             DiaChi = s.DiaChi,
                             Email = s.Email,
                             NgaySinh = s.NgaySinh,
                             SoGiayTo = s.SoGiayTo,
                             SoDienThoai = s.SoDienThoai,
                             Nganh = s.IdNganh,
                             NganhChinh = s.NganhChinh
                         }).FirstOrDefault();
            //DTO_ThongTinKH thong = new DTO_ThongTinKH();
            //foreach (var t in query)
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
            //    string sodienthoai = t.SoDienThoai;
            //    string email = t.Email;
            //    thong = new DTO_ThongTinKH(ten, img, ngaysinh, diachi, sodienthoai, sogiayto, ngaycap, email);
            //}
            if (query != null && query.Avarta != null) { Console.WriteLine("Avarta length: " + query.Avarta.Length); } else { Console.WriteLine("Avarta is null"); }
            return query;
        }

        public DTO_TaiKhoan DangNhap(string sDT, string mk)
        {
            var temp = (from s in db.KhachHangs
                        join tk in db.TaiKhoans on s.IdKhachHang equals tk.IdKhachHang
                        where s.SoDienThoai == sDT && tk.Matkhau == mk
                        select new DTO_TaiKhoan
                        {
                  
                            IdTaiKhoan = tk.IdTaiKhoan,
                            MaKhachHang = (int)tk.IdKhachHang,
                             Matkhau=tk.Matkhau,
                           TienTe=tk.TienTe == null ? null:tk.TienTe
                        }).FirstOrDefault();
            return temp;

        }

        public DTO_ThongTinKH GanThongTinNguoiDung(string sDT, string mk)
        {
            if (DangNhap(sDT, mk)!=null)
            {
                // Lấy thông tin chi tiết người dùng
                var taiKhoan = (from s in db.KhachHangs
                                join tk in db.TaiKhoans on s.IdKhachHang equals tk.IdKhachHang
                                where s.SoDienThoai == sDT
                                select new DTO_ThongTinKH
                                {
                                    IdKhachHang = (int)tk.IdKhachHang,
                                    TenKhachHang = s.TenKhachHang,
                                    SoDienThoai = s.SoDienThoai,
                                    Avarta = s.Avarta == null ? null : s.Avarta.ToArray(),
                                    IdLoaiKH1 = (int)s.IdLoaiKH

                                }).FirstOrDefault();

                return taiKhoan;
            }
            else
            {
                // Xử lý trường hợp đăng nhập thất bại
                // Bạn có thể hiển thị thông báo lỗi chẳng hạn như:
                MessageBox.Show("Số điện thoại hoặc mật khẩu không đúng.");
                return null; // Trả về null để báo hiệu đăng nhập thất bại
            }
        }

        public void CreateKH(DTO_ThongTinKH kh)
        {
            DTO_ThongTinKH d = kh;
            try
            {
                KhachHang _kh = new KhachHang
                {
                    IdKhachHang = kh.IdKhachHang,
                    SoDienThoai = kh.SoDienThoai,
                    Email = kh.Email,
                    TenKhachHang = kh.TenKhachHang,
                    NgaySinh = kh.NgaySinh,
                    DiaChi = kh.DiaChi,
                    QuocTich = kh.QuocTich,
                    SoGiayTo = kh.SoGiayTo,
                    NgayCap = kh.NgayCap,
                    NoiCap = kh.NoiCap,
                    LoaiGiayTo = kh.LoaiGiayTo,
                    IdNganh = kh.Nganh,
                    NganhChinh = kh.NganhChinh,
                    IdLoaiKH = kh.IdLoaiKH1
                };
                db.KhachHangs.InsertOnSubmit(_kh);
                db.SubmitChanges();
                Console.WriteLine("Dang ki thanh cong");
            }
            catch (Exception ex)
            {
                throw new Exception("Error", ex);
            }
        }
       

        public void CreateTK(DTO_TaiKhoan kh)
        {
            DTO_TaiKhoan a = kh;
            try
            {
                TaiKhoan chiTiet = new TaiKhoan
                {
                    IdTaiKhoan = kh.IdTaiKhoan, 
                    IdLoai = kh.IdLoai,
                    Matkhau = kh.Matkhau,
                    TienTe = kh.TienTe,
                    IdKhachHang =kh.MaKhachHang
                };
                db.TaiKhoans.InsertOnSubmit(chiTiet);
                db.SubmitChanges();
                var soDuTinDung = db.SoDuTinDungs.FirstOrDefault(s => s.IdTaiKhoan == chiTiet.IdTaiKhoan);
                if (soDuTinDung == null)
                {
                    SoDuTinDung so = new SoDuTinDung
                    {
                        IdTaiKhoan = chiTiet.IdTaiKhoan,
                        SoDuTK = 0
                    };
                    db.SoDuTinDungs.InsertOnSubmit(so);
                }
                db.SubmitChanges();
                    Console.WriteLine("Giao Dịch Thành Công");

            }
            catch (Exception ex)
            {
                throw new Exception("Error", ex);
            }

        }
        public bool DangKy(string sDT)
        {
            var temp = (from s in db.KhachHangs
                        where s.SoDienThoai != sDT
                        select s).Any();
            return temp;
        }
        public void SuaMK(string mk,string idTK)
        {
            var a = db.TaiKhoans.Single(kh => kh.IdTaiKhoan == long.Parse(idTK));

            a.Matkhau = mk;
          
            db.SubmitChanges();

        }
        public void Them(DTO_TaiKhoan taiKhoan)
        {
            DTO_TaiKhoan ta = taiKhoan;
            try
            {
                // Chèn đối tượng TaiKhoan
                TaiKhoan tk = new TaiKhoan
                {
                    IdTaiKhoan = taiKhoan.IdTaiKhoan,
                    IdKhachHang = taiKhoan.MaKhachHang,
                    IdLoai = taiKhoan.IdLoai,
                    TienTe = taiKhoan.TienTe,
                    TieuDeTK = taiKhoan.TieuDeTK,
                    TieuDeNgan = taiKhoan.TieuDeNgan,
                    NhanVienLV = taiKhoan.NhanVienLV,
                    PhiMa = taiKhoan.PhiMa,
                    Matkhau = taiKhoan.Matkhau,
                };

                db.TaiKhoans.InsertOnSubmit(tk);
                db.SubmitChanges(); // Xác nhận lưu và nhận IdTaiKhoan đã được tạo

                // Kiểm tra IdTaiKhoan đã được tạo
                if (tk.IdTaiKhoan <= 0)
                {
                    throw new InvalidOperationException("IdTaiKhoan không được tạo đúng.");
                }

                // Chèn SoDuTinDung với IdTaiKhoan vừa tạo
                SoDuTinDung sd = new SoDuTinDung
                {
                    IdTaiKhoan = tk.IdTaiKhoan, // Khóa ngoại từ TaiKhoan
                    SoDuTK = 0
                };

                db.SoDuTinDungs.InsertOnSubmit(sd);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Thêm thất bại: " + ex.Message);
            }
        }
        public void SuaTK(DTO_TaiKhoan tk)
        {
            var sua = db.TaiKhoans.Single(tkk => tkk.IdTaiKhoan == tk.IdTaiKhoan);
            sua.TienTe = tk.TienTe;
            sua.IdLoai = tk.IdLoai;
            sua.TieuDeTK = tk.TieuDeTK;
            sua.TieuDeNgan = tk.TieuDeNgan;
            sua.NhanVienLV = tk.NhanVienLV;
            sua.PhiMa = tk.PhiMa;
            db.SubmitChanges();
        }
    }
}