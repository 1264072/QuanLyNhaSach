using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DauSachDAO
    {
        public static List<DauSachDTO> LayDanhSach()
        {
            List<DauSachDTO> lstDTO = new List<DauSachDTO>();
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                List<DAUSACH> lst = bs.DAUSACHes.ToList();
                foreach (DAUSACH ds in lst)
                {
                    DauSachDTO dsDTO = new DauSachDTO()
                    {
                        MADS = ds.MADS,
                        TENSACH = ds.TENSACH,
                        MATL = ds.MATL,
                        TENTL = ds.THELOAI.TENTL,
                        TACGIA = ds.TACGIA,
                        SOLUONG = ds.SOLUONG,
                        DONGIA = ds.DONGIA
                    };
                    lstDTO.Add(dsDTO);
                }
            }
            return lstDTO;
        }

        public static int ThemDauSach(DauSachDTO DsDTO)
        {
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                DAUSACH ds = new DAUSACH()
                {
                    TENSACH = DsDTO.TENSACH,
                    MATL = DsDTO.MATL,
                    TACGIA = DsDTO.TACGIA,
                    SOLUONG = DsDTO.SOLUONG,
                    DONGIA = DsDTO.DONGIA
                };
                bs.DAUSACHes.Add(ds);
                return bs.SaveChanges();
            }
        }

        public static int CapNhatDauSach(DauSachDTO DsDTO)
        {
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                DAUSACH ds = bs.DAUSACHes.Where(s => s.MADS == DsDTO.MADS).FirstOrDefault();
                if (ds != null)
                {
                    ds.TENSACH = DsDTO.TENSACH;
                    ds.MATL = DsDTO.MATL;
                    ds.TACGIA = DsDTO.TACGIA;
                    ds.SOLUONG = DsDTO.SOLUONG;
                    ds.DONGIA = DsDTO.DONGIA;
                }
                return bs.SaveChanges();
            }
        }

        public static int XoaDauSach(DauSachDTO DsDTO)
        {
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                DAUSACH ds = bs.DAUSACHes.Where(s => s.MADS == DsDTO.MADS).FirstOrDefault();
                if (ds != null)
                {
                    bs.DAUSACHes.Remove(ds);
                }
                return bs.SaveChanges();
            }
        }

        public static List<DauSachDTO> TimKiem(string ten, string matl, string soluong, string dongia)
        {
            List<DauSachDTO> lstDTO = new List<DauSachDTO>();
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                int slton = bs.QUYDINHs.ToList().Take(1).FirstOrDefault().TONTRUOCNHAP;
                List<DAUSACH> lst = bs.DAUSACHes.ToList();
                if (ten != "")
                {
                    string[] arr = ten.Split(' ');
                    for (int i = 0; i < arr.Length; i++)
                    {
                        lst = lst.Where(s => s.TENSACH.Contains(arr[i])).ToList();
                    }
                }
                if (matl != "ALL")
                {
                    lst = lst.Where(s => s.MATL == matl).ToList();
                }
                if (soluong == "0" && dongia == "0")
                {
                    lst = lst.OrderByDescending(s => s.SOLUONG).ThenByDescending(s => s.DONGIA).ToList();
                }
                else if (soluong == "0" && dongia == "1")
                {
                    lst = lst.OrderByDescending(s => s.SOLUONG).ThenBy(s => s.DONGIA).ToList();
                }
                else if (soluong == "1" && dongia == "0")
                {
                    lst = lst.OrderBy(s => s.SOLUONG).ThenByDescending(s => s.DONGIA).ToList();
                }
                else if (soluong == "2" && dongia == "0")
                {
                    lst = lst.Where(s => s.SOLUONG <= slton).OrderByDescending(s => s.SOLUONG).ToList();
                }
                else if (soluong == "2" && dongia == "1")
                {
                    lst = lst.Where(s => s.SOLUONG <= slton).OrderBy(s => s.SOLUONG).ToList();
                }
                else
                {
                    lst = lst.OrderBy(s => s.SOLUONG).ThenBy(s => s.DONGIA).ToList();
                }
                foreach (DAUSACH ds in lst)
                {
                    DauSachDTO dsDTO = new DauSachDTO()
                    {
                        MADS = ds.MADS,
                        TENSACH = ds.TENSACH,
                        MATL = ds.MATL,
                        TENTL = ds.THELOAI.TENTL,
                        TACGIA = ds.TACGIA,
                        SOLUONG = ds.SOLUONG,
                        DONGIA = ds.DONGIA
                    };
                    lstDTO.Add(dsDTO);
                }
            }
            return lstDTO;
        }
    }
}
