using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BLL_LoadValue
    {
        DAL_LoadValue load = new DAL_LoadValue();
        public IQueryable XemNganhChinh()
        {
            return load.XemNganhChinh();
        }
        public IQueryable XemNganh(int maNganhChinh)
        {
            return load.XemNganh(maNganhChinh);
        }
        public IQueryable XemNhanVien()
        {
            return load.XemNhanVien();
        }
        public string LayTenNganhChinh(int id)
        {
            return load.LayTenNganhChinh(id);
        }
        public string LayTenNganh(int id)
        {
            return load.LayTenNganh(id);
        }
        public string LayTenNV(string idNV)
        {
            return load.LayTenNV(idNV);
        }
        public List<DTO_KhachHang> HienThiDanhSachKH()
        {
            return load.HienThiDanhSachKH();
        }
        public IQueryable HienThiDanhSachKH(Dictionary<string, string> whereArg)
        {
            return load.HienThiDanhSachKH(whereArg);
        }
        public IQueryable XemDSLoaiTK()
        {
            return load.XemDSLoaiTK();
        }
        public List<string> LayThongTinKhachHang(long id, int loaiTK)
        {
            return load.LayThongTinKhachHang(id, loaiTK);
        }
        public IQueryable DanhSachLoaiKH()
        {
            return load.DanhSachLoaiKH();
        }

        public IQueryable DanhSachTaiKhoan()
        {
            return load.DanhSachTaiKhoan();
        }

        public DTO_TaiKhoan LayThongTinTK(long id)
        {
            return load.LayThongTinTK(id);
        }
        public IQueryable HienThiDanhSachTK(Dictionary<string, string> whereArg)
        {
            return load.HienThiDanhSachTK(whereArg);
        }
        public List<DTO_KhachHang> NguoiThamGiaTK(int idKH)
        {
            return load.NguoiThamGiaTK(idKH);
        }
        public DTO_ThamGiaTK LayThongTinKHTG(long id)
        {
            return load.LayThongTinKHTG(id);
        }
        public DataTable InPhieuNopTien(string maGD)
        {
            return load.InPhieuNopTien(maGD);
        }
        public IQueryable XemGuiTienMat()
        {
            return load.XemGuiTienMat();
        }
        public DTO_GiaoDich LayChiTietGT(string idTienMat)
        {
            return load.LayChiTietGT(idTienMat);
        }

        public IQueryable HienThiDanhSachTKTK(Dictionary<string, string> whereArg)
        {
            return load.HienThiDanhSachTKTK(whereArg);
        }
        public IQueryable DanhSachLoaiTK()
        {
            return load.DanhSachLoaiTK();
        }
        public int LayIdLoaiTK(long idTK)
        {
            return load.LayIdLoaiTK(idTK);
        }
        public IQueryable DanhSachLoaiGD()
        {
            return load.DanhSachLoaiGD();
        }
        public IQueryable DanhSachRutTien()
        {
            return load.DanhSachRutTien();
        }
    }
}
