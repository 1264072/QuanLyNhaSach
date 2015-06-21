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
