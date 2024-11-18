using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TaiKhoanTietKiem
    {
        private long idTaiKhoan,idTaiKhoanLV;
        private int maKhachHang, idLoai;
        private string tienTe, tieuDeTK, tieuDeNgan, nhanVienLV, matkhau;
        private decimal soDu;
        private DateTime ngayGiaTri, ngayDaoHan;
        private float laiSuat;




        public DTO_TaiKhoanTietKiem()
        {
        }
        public DTO_TaiKhoanTietKiem(string matkhau, long idTaiKhoan)
        {
            this.idTaiKhoan = idTaiKhoan;
            this.matkhau = matkhau;
        }
        public DTO_TaiKhoanTietKiem(int maKhachHang, int idLoai, string tienTe, string tieuDeTK, string tieuDeNgan, string nhanVienLV, string matkhau)
        {
            this.maKhachHang = maKhachHang;
            this.IdLoai = idLoai;
            this.tienTe = tienTe;
            this.tieuDeTK = tieuDeTK;
            this.tieuDeNgan = tieuDeNgan;
            this.nhanVienLV = nhanVienLV;
            this.matkhau = matkhau;
        }
        public DTO_TaiKhoanTietKiem(
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
            Matkhau = matkhau;
        }
        public DTO_TaiKhoanTietKiem(
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
        }

        public DTO_TaiKhoanTietKiem(long idTaiKhoan, int maKhachHang, int idLoai, string tienTe, string tieuDeTK, string tieuDeNgan, string nhanVienLV, string matkhau, decimal soDu, DateTime ngayGiaTri, DateTime ngayDaoHan, float laiSuat, long idTaiKhoanLV)
        {
            this.idTaiKhoan = idTaiKhoan;
            this.maKhachHang = maKhachHang;
            this.idLoai = idLoai;
            this.tienTe = tienTe;
            this.tieuDeTK = tieuDeTK;
            this.tieuDeNgan = tieuDeNgan;
            this.nhanVienLV = nhanVienLV;
            this.matkhau = matkhau;
            this.soDu = soDu;
            this.ngayGiaTri = ngayGiaTri;
            this.ngayDaoHan = ngayDaoHan;
            this.laiSuat = laiSuat;
            IdTaiKhoanLV = idTaiKhoanLV;
        }

        public long IdTaiKhoan { get => idTaiKhoan; set => idTaiKhoan = value; }
        public int MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string TienTe { get => tienTe; set => tienTe = value; }
        public string TieuDeTK { get => tieuDeTK; set => tieuDeTK = value; }
        public string TieuDeNgan { get => tieuDeNgan; set => tieuDeNgan = value; }
        public string NhanVienLV { get => nhanVienLV; set => nhanVienLV = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public int IdLoai { get => idLoai; set => idLoai = value; }
        public decimal SoDu { get => soDu; set => soDu = value; }
        public DateTime NgayGiaTri { get => ngayGiaTri; set => ngayGiaTri = value; }
        public DateTime NgayDaoHan { get => ngayDaoHan; set => ngayDaoHan = value; }
        public float LaiSuat { get => laiSuat; set => laiSuat = value; }
        public long IdTaiKhoanLV { get => idTaiKhoanLV; set => idTaiKhoanLV = value; }
    }
}
