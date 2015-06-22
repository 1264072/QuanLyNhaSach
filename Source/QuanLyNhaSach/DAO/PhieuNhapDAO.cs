using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuNhapDAO
    {
        public static int ThemPhieuNhap(PhieuNhapDTO pn)
        {
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                if (bs.PHIEUNHAPs.Where(p => p.MAPN == pn.MAPN).FirstOrDefault() != null)
                {
                    return 0;
                }
                PHIEUNHAP PN = new PHIEUNHAP()
                {
                    MAPN = pn.MAPN,
                    MANV = pn.MANV,
                    MANCC = pn.MANCC,
                    NGAYLAP = pn.NGAYLAP,
                    TONGTIEN = pn.TONGTIEN,
                    CONNO = pn.CONNO
                };
                bs.PHIEUNHAPs.Add(PN);
                return bs.SaveChanges();
            }
        }
    }
}
