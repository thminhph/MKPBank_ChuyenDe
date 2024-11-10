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
                             Avarta = s.Avarta == null ? null :s.Avarta.ToArray(),  
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
                           TienTe=tk.TienTe
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
                                    Avarta=s.Avarta.ToArray(),

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
            try
            {
                KhachHang _kh = new KhachHang
                {
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

            try
            {
                TaiKhoan chiTiet = new TaiKhoan
                {
                    IdTaiKhoan = kh.IdTaiKhoan,
                    IdLoai = kh.IdLoai,
                    Matkhau = kh.Matkhau,
                    TienTe = kh.TienTe,
                    IdKhachHang = int.Parse(kh.MaKhachHang.ToString())
                };
                db.TaiKhoans.InsertOnSubmit(chiTiet);
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
            var temp = (from s in db.TaiKhoans
                        join d in db.KhachHangs on s.IdKhachHang equals d.IdKhachHang
                        where d.SoDienThoai != sDT
                        select s).Any();
            return temp;
        }
        public void SuaMK(string mk,string idTK)
        {
            var a = db.TaiKhoans.Single(kh => kh.IdTaiKhoan == long.Parse(idTK));

            a.Matkhau = mk;
          
            db.SubmitChanges();

        }
    }
}