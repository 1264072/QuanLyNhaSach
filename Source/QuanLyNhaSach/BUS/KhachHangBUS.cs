using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class KhachHangBUS
    {
        public static List<KhachHangDTO> LayDanhSach()
        {
            return KhachHangDAO.LayDanhSach();
        }

        public static int ThemKhachHang(KhachHangDTO khDTO)
        {
            return KhachHangDAO.ThemKhachHang(khDTO);
        }

        public static int CapNhatKhachHang(KhachHangDTO khDTO)
        {
            return KhachHangDAO.CapNhatKhachHang(khDTO);
        }

        public static int XoaKhachHang(KhachHangDTO khDTO)
        {
            return KhachHangDAO.XoaKhachHang(khDTO);
        }
    }
}
