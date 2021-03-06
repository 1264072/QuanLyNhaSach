﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietHoaDonDAO
    {
        public static List<ChiTietHoaDonDTO> LayChiTietTheoMaHD(HoaDonDTO HdDTO)
        {
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                List<ChiTietHoaDonDTO> lstDTO = new List<ChiTietHoaDonDTO>();
                List<CHITIETHOADON> lst = bs.CHITIETHOADONs.Where(c => c.MAHD == HdDTO.MAHD).ToList();
                foreach (CHITIETHOADON CTHD in lst)
                {
                    ChiTietHoaDonDTO DTO = new ChiTietHoaDonDTO()
                    {
                        MADS = CTHD.MADS,
                        TENDAUSACH = CTHD.DAUSACH.TENSACH,
                        MATL = CTHD.MATL,
                        TENTL = CTHD.THELOAI.TENTL,
                        SOLUONG = CTHD.SOLUONG,
                        THANHTIEN = CTHD.THANHTIEN,
                        DONGIA = CTHD.DONGIA
                    };
                    lstDTO.Add(DTO);
                }
                return lstDTO;
            }
        }

        static public bool AddChiTietHD(List<ChiTietHoaDonDTO> lst)
        {
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                foreach (ChiTietHoaDonDTO item in lst)
                {
                    CHITIETHOADON cthd = new CHITIETHOADON()
                    {
                        MADS = item.MADS,
                        MATL = item.MATL,
                        SOLUONG = item.SOLUONG,
                        DONGIA = item.DONGIA,
                        THANHTIEN = item.THANHTIEN,
                        MAHD = item.MAHD
                    };
                    bs.CHITIETHOADONs.Add(cthd);
                }
                bs.SaveChanges();
            }
            return true;
        }
    }
}
