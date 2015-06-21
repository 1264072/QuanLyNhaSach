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

        public static List<DauSachDTO> SearchDauSach(DauSachDTO ds)
        {
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                List<DauSachDTO> lst = new List<DauSachDTO>();
                List<DAUSACH> linq = new List<DAUSACH>();
                if (ds.DONGIA < 50000)
                    linq = bs.DAUSACHes.Where(d => d.TENSACH.Contains(ds.TENSACH) || d.MATL.Contains(ds.MATL) || d.DONGIA <= ds.DONGIA).ToList();
                else
                    linq = bs.DAUSACHes.Where(d => d.TENSACH.Contains(ds.TENSACH) || d.MATL.Contains(ds.MATL) || d.DONGIA >= ds.DONGIA).ToList();
                foreach (DAUSACH d in linq)
                {

                    ds = new DauSachDTO
                    {
                        MADS = d.MADS,
                        TENSACH = d.TENSACH,
                        SOLUONG = d.SOLUONG,
                        DONGIA = d.DONGIA,
                        TACGIA = d.TACGIA,
                        MATL = d.MATL,
                        TENTL = d.THELOAI.TENTL
                    };
                    lst.Add(ds);
                }
                return lst;
            }
        }
    }
}
