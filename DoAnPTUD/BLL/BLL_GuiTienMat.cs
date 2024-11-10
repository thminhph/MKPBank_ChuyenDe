using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_GuiTienMat
    {
        DAL_GuiTienMat tm = new DAL_GuiTienMat();
        public void Them(DTO_GuiTienMat t)
        {
            tm.Them(t);
        }
        public void CapNhatTien(long idTK, float soDu)
        {
            tm.CapNhatTien(idTK, soDu);
        }
    }
}
