using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TheLoaiDAO
    {
        public static List<TheLoaiDTO> LayDanhSach()
        {
            List<TheLoaiDTO> lstDTO = new List<TheLoaiDTO>();
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                List<THELOAI> lst = bs.THELOAIs.ToList();
                foreach (THELOAI tl in lst)
                {
                    TheLoaiDTO tlDTO = new TheLoaiDTO()
                    {
                        MATL = tl.MATL,
                        TENTL = tl.TENTL
                    };
                    lstDTO.Add(tlDTO);
                }
            }
            return lstDTO;
        }
    }
}
