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
        private int  maKhachHang;
        private string loaiTaiKhoan, tenTaiKhoan, tienTe,  tieuDeTK, tieuDeNgan, nhanVienLV, phiMa, matKhau;

        public DTO_TaiKhoan()
        {

        }

        public DTO_TaiKhoan(long idTaiKhoan, int maKhachHang, string loaiTaiKhoan, string tenTaiKhoan, string tienTe,
            string tieuDeTK, string tieuDeNgan, string nhanVienLV, string phiMa, string matKhau)
        {
            this.idTaiKhoan = idTaiKhoan;
            this.maKhachHang = maKhachHang;
            this.loaiTaiKhoan = loaiTaiKhoan;
            this.tenTaiKhoan = tenTaiKhoan;
            this.tienTe = tienTe;
            this.tieuDeTK = tieuDeTK;
            this.tieuDeNgan = tieuDeNgan;
            this.nhanVienLV = nhanVienLV;
            this.phiMa = phiMa;
            this.matKhau = matKhau;
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
        public string MatKhau { get => matKhau; set => matKhau = value; }
    }
}
