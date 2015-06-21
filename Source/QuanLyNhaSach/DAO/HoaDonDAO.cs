using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HoaDonDAO
    {
        static public bool AddHoaDon(HoaDonDTO hd, List<ChiTietHoaDonDTO> lst)
        {
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                ChiTietHoaDonDAO.AddChiTietHD(lst);
                HOADON h = new HOADON()
                {
                    MAHD = hd.MAHD,
                    MANV = hd.MANV,
                    NGAYLAP = hd.NGAYLAP,
                    TONGTIEN = hd.TONGTIEN,
                    MAKH = hd.MAKH,
                    TIENNO = hd.TIENNO,
                    TIENTRA = hd.TIENTRA
                };
                bs.HOADONs.Add(h);
                bs.SaveChanges();
            }
            return true;
        }

        public static List<HoaDonDTO> LayDanhSach()
        {
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                List<HoaDonDTO> lstDTO = new List<HoaDonDTO>();
                List<HOADON> lst = bs.HOADONs.OrderByDescending(n => n.NGAYLAP).ToList();
                foreach (HOADON hd in lst)
                {
                    HoaDonDTO hdDTO = new HoaDonDTO()
                    {
                        MAHD = hd.MAHD,
                        MAKH = hd.MAKH,
                        MANV = hd.MANV,
                        TENKH = hd.KHACHHANG.HOTEN,
                        TENNV = hd.NHANVIEN.HOTEN,
                        TONGTIEN = hd.TONGTIEN,
                        TIENTRA = hd.TIENTRA,
                        TIENNO = hd.TIENNO,
                        NGAYLAP = hd.NGAYLAP
                    };
                    lstDTO.Add(hdDTO);
                }
                return lstDTO;
            }
        }
    }
}
