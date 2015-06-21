using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class HoaDonBUS
    {
        public static List<HoaDonDTO> LayDanhSach()
        {
            return HoaDonDAO.LayDanhSach();
        }

        static public bool AddHoaDon(HoaDonDTO hd, List<ChiTietHoaDonDTO> lst)
        {
            return HoaDonDAO.AddHoaDon(hd, lst);
        }
    }
}
