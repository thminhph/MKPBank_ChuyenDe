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
         public  DTO_ThongTinKH timUserTheostk(string   stk)
        {
           var query = from s in db.KhachHangs
                        join tk in db.TaiKhoans on s.IdKhachHang equals tk.IdKhachHang
                        where s.SoDienThoai == stk
                        select new 
                        {
                            tk.IdTaiKhoan,
                            s.Avarta,
                            s.TenKhachHang,
                            s.NgayCap,
                            s.DiaChi,
                            s.Email,
                            s.NgaySinh,
                            s.SoGiayTo,
                            s.SoDienThoai
                        };


            DTO_ThongTinKH thong = new DTO_ThongTinKH();
            foreach (var t in query)
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
                string sodienthoai = t.SoDienThoai;
                string email = t.Email;
                thong = new DTO_ThongTinKH(ten, img, ngaysinh, diachi, sodienthoai, sogiayto, ngaycap, email);
            }
            return thong;
        }

        public bool  DangNhap(string  sDT, string mk )
        {
            var  temp = (from s in db.KhachHangs
                              join tk in db.TaiKhoans on s.IdKhachHang equals tk.IdKhachHang
                              where s.SoDienThoai == sDT && tk.Matkhau == mk
                              select tk).Any();
            return temp;

        }
        public DTO_ThongTinKH GanThongTinNguoiDung(string sDT, string mk)
        {
            if (DangNhap(sDT, mk))
            {
                // Lấy thông tin chi tiết người dùng
                var taiKhoan = (from s in db.KhachHangs
                                join tk in db.TaiKhoans on s.IdKhachHang equals tk.IdKhachHang
                                where s.SoDienThoai == sDT
                                select new DTO_ThongTinKH
                                {
                                    IdKhachHangCN = (int)tk.IdKhachHang,
                                    TenKhachHang = s.TenKhachHang,
                                    SoDienThoai = s.SoDienThoai,
                                   
                                    
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

        public void Them(DTO_TaiKhoan taiKhoan)
        {
            try
            {
                // Chèn đối tượng TaiKhoan
                TaiKhoan tk = new TaiKhoan
                {
                    IdTaiKhoan = taiKhoan.IdTaiKhoan,
                    IdKhachHang = taiKhoan.IdKhachHang,
                    IdLoai = taiKhoan.LoaiTaiKhoan,
                    TenTaiKhoan = taiKhoan.TenTaiKhoan,
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

    }
}
