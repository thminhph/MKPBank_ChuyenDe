using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_GiaoDich
    {
        DAL_GiaoDich tm = new DAL_GiaoDich();
        public void Them(DTO_GiaoDich t)
        {
            tm.Them(t);
        }
        public void CapNhatTien(long idTK, decimal soDu)
        {
            tm.CapNhatTien(idTK, soDu);
        }
        public void TruTienMat(DTO_GiaoDich t)
        {
            tm.TruTienMat(t);
        }
        public IQueryable HienThiDanhSachGiaoDich(Dictionary<string, string> whereArg)
        {
            return tm.HienThiDanhSachGiaoDich(whereArg);
        }
    }
}
