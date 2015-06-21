using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietHoaDonBUS
    {
        public static List<ChiTietHoaDonDTO> LayChiTietTheoMaHD(HoaDonDTO HdDTO)
        {
            return ChiTietHoaDonDAO.LayChiTietTheoMaHD(HdDTO);
        }

        static public bool AddChiTietHD(List<ChiTietHoaDonDTO> lst)
        {
            return ChiTietHoaDonDAO.AddChiTietHD(lst);
        }
    }
}
