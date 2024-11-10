using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_GuiTienMat
    {
        private string idGuiTien, loaiTaiKhoan, noiDung;
        private long idTK;
        private float soGiaoDich, soDu;

        public DTO_GuiTienMat(string idGuiTien, string loaiTaiKhoan, string noiDung, long idTK, float soGiaoDich, float soDu)
        {
            this.idGuiTien = idGuiTien;
            this.loaiTaiKhoan = loaiTaiKhoan;
            this.noiDung = noiDung;
            this.idTK = idTK;
            this.soGiaoDich = soGiaoDich;
            this.soDu = soDu;
        }

        public string IdGuiTien { get => idGuiTien; set => idGuiTien = value; }
        public string LoaiTaiKhoan { get => loaiTaiKhoan; set => loaiTaiKhoan = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public long IdTK { get => idTK; set => idTK = value; }
        public float SoGiaoDich { get => soGiaoDich; set => soGiaoDich = value; }
        public float SoDu { get => soDu; set => soDu = value; }
    }
}
