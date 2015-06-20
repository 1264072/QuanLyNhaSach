using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhachHangDAO
    {
        public static List<KhachHangDTO> LayDanhSach()
        {
            List<KhachHangDTO> lstDTO = new List<KhachHangDTO>();
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                List<KHACHHANG> lst = bs.KHACHHANGs.ToList();
                foreach (KHACHHANG kh in lst)
                {
                    KhachHangDTO khDTO = new KhachHangDTO()
                    {
                        MAKH = kh.MAKH,
                        HOTEN = kh.HOTEN,
                        DIACHI = kh.DIACHI,
                        SDT = kh.SDT,
                        EMAIL = kh.EMAIL,
                        NO = kh.NO
                    };
                    lstDTO.Add(khDTO);
                }
            }
            return lstDTO;
        }

        public static int ThemKhachHang(KhachHangDTO khDTO)
        {
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                if (bs.KHACHHANGs.Where(k => k.MAKH == khDTO.MAKH).FirstOrDefault() != null)
                {
                    return 0;
                }
                KHACHHANG kh = new KHACHHANG()
                {
                    MAKH = khDTO.MAKH,
                    HOTEN = khDTO.HOTEN,
                    DIACHI = khDTO.DIACHI,
                    SDT = khDTO.SDT,
                    EMAIL = khDTO.EMAIL,
                    NO = false
                };
                bs.KHACHHANGs.Add(kh);
                return bs.SaveChanges();
            }
        }

        public static int CapNhatKhachHang(KhachHangDTO khDTO)
        {
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                KHACHHANG kh = bs.KHACHHANGs.Where(k => k.MAKH == khDTO.MAKH).FirstOrDefault();
                if (kh != null)
                {
                    kh.HOTEN = khDTO.HOTEN;
                    kh.DIACHI = khDTO.DIACHI;
                    kh.SDT = khDTO.SDT;
                    kh.EMAIL = khDTO.EMAIL;
                }
                return bs.SaveChanges();
            }
        }

        public static int XoaKhachHang(KhachHangDTO khDTO)
        {
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                KHACHHANG kh = bs.KHACHHANGs.Where(k => k.MAKH == khDTO.MAKH).FirstOrDefault();
                if (kh != null)
                {
                    bs.KHACHHANGs.Remove(kh);
                }
                return bs.SaveChanges();
            }
        }
    }
}
