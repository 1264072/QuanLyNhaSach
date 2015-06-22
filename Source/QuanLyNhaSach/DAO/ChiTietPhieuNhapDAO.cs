using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietPhieuNhapDAO
    {
        public static int ThemChiTiet(List<DauSachDTO> lstDTO, string ma)
        {
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                foreach (DauSachDTO item in lstDTO)
                {
                    CHITIETPHIEUNHAP pn = new CHITIETPHIEUNHAP()
                    {
                        MAPN = ma,
                        MADS = item.MADS,
                        SOLUONG = item.SOLUONG,
                        DONGIA = item.DONGIA,
                        THANHTIEN = item.THANHTIEN
                    };
                    bs.CHITIETPHIEUNHAPs.Add(pn);
                }
                return bs.SaveChanges();
            }
        }
    }
}
