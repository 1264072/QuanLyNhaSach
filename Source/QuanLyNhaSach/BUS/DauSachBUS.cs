using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class DauSachBUS
    {
        public static List<DauSachDTO> LayDanhSach()
        {
            return DauSachDAO.LayDanhSach();
        }

        public static int ThemDauSach(DauSachDTO DsDTO)
        {
            return DauSachDAO.ThemDauSach(DsDTO);
        }

        public static int CapNhatDauSach(DauSachDTO DsDTO)
        {
            return DauSachDAO.CapNhatDauSach(DsDTO);
        }

        public static int XoaDauSach(DauSachDTO DsDTO)
        {
            return DauSachDAO.XoaDauSach(DsDTO);
        }
    }
}
