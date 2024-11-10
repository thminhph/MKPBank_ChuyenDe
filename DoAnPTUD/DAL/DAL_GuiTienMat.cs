using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_GuiTienMat
    {
        Data_Context db;
        public DAL_GuiTienMat()
        {
            db = new Data_Context();
        }
        public void Them(DTO_GuiTienMat t)
        {
            try
            {
                GUITIENMAT tm = new GUITIENMAT
                {
                    IdGuiTien = t.IdGuiTien,
                    IdTaiKhoan = t.IdTK,
                    LTaiKhoan = t.LoaiTaiKhoan,
                    SoGiaoDich = t.SoGiaoDich,
                    SoDu = t.SoDu,
                    NoiDung = t.NoiDung
                };
                db.Db.GUITIENMATs.InsertOnSubmit(tm);
                db.Db.SubmitChanges();
            }
            catch (Exception)
            {

                throw new InvalidOperationException("Thêm thất bại!!!");
            }
        }
        public void CapNhatTien(long idTK, float soDu)
        {
            var capNhat = db.Db.SoDuTinDungs
                .Single(sd => sd.IdTaiKhoan == idTK);
            capNhat.SoDuTK = soDu;
            db.Db.SubmitChanges();
        }
    }
}
