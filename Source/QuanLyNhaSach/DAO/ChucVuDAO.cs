using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class ChucVuDAO
    {
        public static List<ChucVuDTO> LayDanhSach()
        {
            List<ChucVuDTO> lst = new List<ChucVuDTO>();
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                List<CHUCVU> lstCV = bs.CHUCVUs.ToList();
                foreach (CHUCVU cv in lstCV)
                {
                    ChucVuDTO cvDTO = new ChucVuDTO()
                    {
                        MACV = cv.MACV,
                        TENCV = cv.TENCV
                    };
                    lst.Add(cvDTO);
                }
            }
            return lst;
        }
    }
}
