using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietGiaoDich
    {
        private int MaGD;
        private int SoTKNguoiChuyen;
        private int SoTKNguoiNhan;
        private long SoTKNguoiChuyen;
        private long SoTKNguoiNhan;
        private float SoTien;
        private DateTime NgayGio;
        private string DienGia;

        public DTO_ChiTietGiaoDich(int maGD, int soTKNguoiChuyen, int soTKNguoiNhan, float soTien, DateTime ngayGio, string dienGia)
        public DTO_ChiTietGiaoDich(int maGD, long  soTKNguoiChuyen, long soTKNguoiNhan, float soTien, DateTime ngayGio, string dienGia)
        {
            MaGD = maGD;
            SoTKNguoiChuyen = soTKNguoiChuyen;
            SoTKNguoiNhan = soTKNguoiNhan;
            SoTien = soTien;
            NgayGio = ngayGio;
            DienGia = dienGia;
        }
        public DTO_ChiTietGiaoDich( int soTKNguoiChuyen, int soTKNguoiNhan, float soTien, DateTime ngayGio, string dienGia)
        public DTO_ChiTietGiaoDich( long soTKNguoiChuyen, long soTKNguoiNhan, float soTien, DateTime ngayGio, string dienGia)
        {
            SoTKNguoiChuyen = soTKNguoiChuyen;
            SoTKNguoiNhan = soTKNguoiNhan;
            SoTien = soTien;
            NgayGio = ngayGio;
            DienGia = dienGia;
        }
        public DTO_ChiTietGiaoDich() { 
        }    

        public int MaGD1 { get => MaGD; set => MaGD = value; }
        public int SoTKNguoiChuyen1 { get => SoTKNguoiChuyen; set => SoTKNguoiChuyen = value; }
        public int SoTKNguoiNhan1 { get => SoTKNguoiNhan; set => SoTKNguoiNhan = value; }
        public long SoTKNguoiChuyen1 { get => SoTKNguoiChuyen; set => SoTKNguoiChuyen = value; }
        public long SoTKNguoiNhan1 { get => SoTKNguoiNhan; set => SoTKNguoiNhan = value; }
        public float SoTien1 { get => SoTien; set => SoTien = value; }
        public DateTime NgayGio1 { get => NgayGio; set => NgayGio = value; }
        public string DienGia1 { get => DienGia; set => DienGia = value; }
    }
}
