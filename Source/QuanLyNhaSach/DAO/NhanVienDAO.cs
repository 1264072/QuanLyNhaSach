using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class NhanVienDAO
    {
        public static NhanVienDTO LayNhanVienTheoTaiKhoan(string username)
        {
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                TAIKHOAN tk = bs.TAIKHOANs.Where(t => t.USERNAME == username).FirstOrDefault();
                NHANVIEN nv = bs.NHANVIENs.Where(n => n.MANV == tk.MANV).FirstOrDefault();
                NhanVienDTO nvDTO = new NhanVienDTO();
                nvDTO.MANV = nv.MANV;
                nvDTO.HOTEN = nv.HOTEN;
                nvDTO.DIACHI = nv.DIACHI;
                nvDTO.EMAIL = nv.EMAIL;
                nvDTO.SDT = nv.SDT;
                nvDTO.MACV = nv.MACV;
                nvDTO.TENCV = nv.CHUCVU.TENCV;
                return nvDTO;
            }
        }

        public static List<NhanVienDTO> LayDanhSach()
        {
            List<NhanVienDTO> lst = new List<NhanVienDTO>();
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                List<NHANVIEN> lstNV = bs.NHANVIENs.ToList();
                foreach (NHANVIEN nv in lstNV)
                {
                    NhanVienDTO nvDTO = new NhanVienDTO()
                    {
                        MANV = nv.MANV,
                        HOTEN = nv.HOTEN,
                        DIACHI = nv.DIACHI,
                        SDT = nv.SDT,
                        EMAIL = nv.EMAIL,
                        MACV = nv.MACV,
                        TENCV = nv.CHUCVU.TENCV
                    };
                    lst.Add(nvDTO);
                }
            }
            return lst;
        }

        public static int ThemNhanVien(NhanVienDTO NvDTO)
        {
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                if (bs.NHANVIENs.Where(n => n.MANV == NvDTO.MANV).FirstOrDefault() != null)
                {
                    return 0;
                }
                NHANVIEN nv = new NHANVIEN()
                {
                    MANV = NvDTO.MANV,
                    HOTEN = NvDTO.HOTEN,
                    DIACHI = NvDTO.DIACHI,
                    EMAIL = NvDTO.EMAIL,
                    SDT = NvDTO.SDT,
                    MACV = NvDTO.MACV
                };
                bs.NHANVIENs.Add(nv);
                return bs.SaveChanges();
            }
        }

        public static int CapNhatNhanVien(NhanVienDTO NvDTO)
        {
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                NHANVIEN nv = bs.NHANVIENs.Where(n => n.MANV == NvDTO.MANV).FirstOrDefault();
                if (nv != null)
                {
                    nv.HOTEN = NvDTO.HOTEN;
                    nv.DIACHI = NvDTO.DIACHI;
                    nv.EMAIL = NvDTO.EMAIL;
                    nv.MACV = NvDTO.MACV;
                    nv.SDT = NvDTO.SDT;
                }
                return bs.SaveChanges();
            }
        }

        public static int XoaNhanVien(NhanVienDTO nvDTO)
        {
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                NHANVIEN nv = bs.NHANVIENs.Where(n => n.MANV == nvDTO.MANV).FirstOrDefault();
                if (nv != null)
                {
                    bs.NHANVIENs.Remove(nv);
                }
                return bs.SaveChanges();
            }
        }
    }
}
