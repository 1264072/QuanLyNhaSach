using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class NhaCungCapDAO
    {
        public static List<NhaCungCapDTO> LayDanhSach()
        {
            List<NhaCungCapDTO> lstDTO = new List<NhaCungCapDTO>();
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                List<NHACUNGCAP> lst = bs.NHACUNGCAPs.ToList();
                foreach (NHACUNGCAP item in lst)
                {
                    NhaCungCapDTO nccDTO = new NhaCungCapDTO()
                    {
                        MANCC = item.MANCC,
                        TENNCC = item.TENNCC,
                        DIACHI = item.DIACHI,
                        EMAIL = item.EMAIL,
                        SDT = item.SDT
                    };
                    lstDTO.Add(nccDTO);
                }
            }
            return lstDTO;
        }

        public static int ThemNhaCungCap(NhaCungCapDTO NccDTO)
        {
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                if (bs.NHACUNGCAPs.Where(n => n.MANCC == NccDTO.MANCC).FirstOrDefault() != null)
                {
                    return 0;
                }
                NHACUNGCAP ncc = new NHACUNGCAP()
                {
                    MANCC = NccDTO.MANCC,
                    TENNCC = NccDTO.TENNCC,
                    DIACHI = NccDTO.DIACHI,
                    SDT = NccDTO.SDT,
                    EMAIL = NccDTO.EMAIL
                };
                bs.NHACUNGCAPs.Add(ncc);
                return bs.SaveChanges();
            }
        }

        public static int ChinhSuaNhaCungCap(NhaCungCapDTO NccDTO)
        {
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                NHACUNGCAP ncc = bs.NHACUNGCAPs.Where(n => n.MANCC == NccDTO.MANCC).FirstOrDefault();
                if (ncc != null)
                {
                    ncc.TENNCC = NccDTO.TENNCC;
                    ncc.DIACHI = NccDTO.DIACHI;
                    ncc.SDT = NccDTO.SDT;
                    ncc.EMAIL = NccDTO.EMAIL;
                }
                return bs.SaveChanges();
            }
        }

        public static int XoaNhaCungCap(NhaCungCapDTO NCC)
        {
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                NHACUNGCAP ncc = bs.NHACUNGCAPs.Where(n => n.MANCC == NCC.MANCC).FirstOrDefault();
                if (ncc != null)
                {
                    bs.NHACUNGCAPs.Remove(ncc);
                }
                return bs.SaveChanges();
            }
        }
    }
}
