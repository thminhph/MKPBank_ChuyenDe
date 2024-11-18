using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TaiKhoan
    {
        private long idTaiKhoan;
        private int maKhachHang, idLoai;
        private string loaiTaiKhoan, tenTaiKhoan, tienTe, tieuDeTK, tieuDeNgan, nhanVienLV, phiMa, matkhau;




        public DTO_TaiKhoan()
        {
        }
        public DTO_TaiKhoan(string matkhau, long idTaiKhoan)
        {
            this.idTaiKhoan = idTaiKhoan;
            this.matkhau = matkhau;
        }
        public DTO_TaiKhoan(int maKhachHang, int idLoai, string loaiTaiKhoan, string tenTaiKhoan, string tienTe, string tieuDeTK, string tieuDeNgan, string nhanVienLV, string phiMa, string matkhau)
        {
            this.maKhachHang = maKhachHang;
            this.IdLoai = idLoai;
            this.loaiTaiKhoan = loaiTaiKhoan;
            this.tenTaiKhoan = tenTaiKhoan;
            this.tienTe = tienTe;
            this.tieuDeTK = tieuDeTK;
            this.tieuDeNgan = tieuDeNgan;
            this.nhanVienLV = nhanVienLV;
            this.phiMa = phiMa;
            this.matkhau = matkhau;
        }
        public DTO_TaiKhoan(
           long idTaiKhoan,
           int idKhachHang,
           int loaiTaiKhoan,
           string tienTe,
           string tieuDeTK,
           string tieuDeNgan,
           string nhanVienLV,
           string phiMa,
           string matkhau)
        {
            IdTaiKhoan = idTaiKhoan;
            MaKhachHang = idKhachHang;
            idLoai = loaiTaiKhoan;
            TienTe = tienTe;
            TieuDeTK = tieuDeTK;
            TieuDeNgan = tieuDeNgan;
            NhanVienLV = nhanVienLV;
            PhiMa = phiMa;
            Matkhau = matkhau;
        }
        public DTO_TaiKhoan(
            long idTaiKhoan,
            int loaiTaiKhoan,
            string tienTe,
            string tieuDeTK,
            string tieuDeNgan,
            string nhanVienLV,
            string phiMa)
        {
            IdTaiKhoan = idTaiKhoan;
            idLoai = loaiTaiKhoan;
            TienTe = tienTe;
            TieuDeTK = tieuDeTK;
            TieuDeNgan = tieuDeNgan;
            NhanVienLV = nhanVienLV;
            PhiMa = phiMa;
        }
        public long IdTaiKhoan { get => idTaiKhoan; set => idTaiKhoan = value; }
        public int MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string LoaiTaiKhoan { get => loaiTaiKhoan; set => loaiTaiKhoan = value; }
        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string TienTe { get => tienTe; set => tienTe = value; }
        public string TieuDeTK { get => tieuDeTK; set => tieuDeTK = value; }
        public string TieuDeNgan { get => tieuDeNgan; set => tieuDeNgan = value; }
        public string NhanVienLV { get => nhanVienLV; set => nhanVienLV = value; }
        public string PhiMa { get => phiMa; set => phiMa = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public int IdLoai { get => idLoai; set => idLoai = value; }
    }
}
