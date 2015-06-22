using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class ChiTietPhieuNhapBUS
    {
        public static int ThemChiTiet(List<DauSachDTO> lstDTO, string ma)
        {
            return ChiTietPhieuNhapDAO.ThemChiTiet(lstDTO, ma);
        }
    }
}
