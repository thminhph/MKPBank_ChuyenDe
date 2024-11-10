using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class BLL_ChiTietGiaoDich
    {
        DAL_ChiTietGiaoDich gd = new DAL_ChiTietGiaoDich();
        public IQueryable laydanhsach(string userId)
        {
            return gd.laydsCTGD(userId);
        }
        public IQueryable laydanhsachNhan(string userId)
        {
            return gd.laydsCTGDNhan(userId);
        }
        public IQueryable laydanhsachchuyen(string userId)
        {
            return gd.laydsCTGDChuyen(userId);
        }
        public IQueryable laydanhsachdungtien(string userId)
        {
            return gd.timtheodungtien(userId);
        }
        public IQueryable laydanhsachdungngay(DateTime userId)
        {
            return gd.timtheodungngay(userId);
        }
        public IQueryable laydanhsachtheongay(DateTime ngaybd, DateTime ngaykt)
        {
            return gd.timtheongay(ngaybd, ngaykt);
        }
        public IQueryable laydanhsachtheotien(string sotiens, string sotiene)
        {
            return gd.timtheosotien(sotiens, sotiene);
        }
        public DTO_ThongTinKH tim(string st)
        {
            return gd.tim(st);
        }
        public string timsdt(string st)
        {
            return gd.timsdt(st);
        }
        public long timMaGD(DateTime st)
        {
            return gd.timMa(st);
        }
        public bool giaoDich(string nc, string nn, float sotien, string diengia)
        {
            return gd.giaoDich(nc, nn, sotien, diengia);
        }
        public bool giaoDichsdt(string nc, string nn, float sotien, string diengia)
        {
            return gd.giaoDichsdt(nc, nn, sotien, diengia);
        }

    }


}
