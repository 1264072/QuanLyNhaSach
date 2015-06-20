using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class NhanVienBUS
    {
        public static NhanVienDTO LayNhanVienTheoTaiKhoan(string username)
        {
            return NhanVienDAO.LayNhanVienTheoTaiKhoan(username);
        }

        public static List<NhanVienDTO> LayDanhSach()
        {
            return NhanVienDAO.LayDanhSach();
        }

        public static int ThemNhanVien(NhanVienDTO NvDTO)
        {
            return NhanVienDAO.ThemNhanVien(NvDTO);
        }

        public static int CapNhatNhanVien(NhanVienDTO NvDTO)
        {
            return NhanVienDAO.CapNhatNhanVien(NvDTO);
        }

        public static int XoaNhanVien(NhanVienDTO nvDTO)
        {
            return NhanVienDAO.XoaNhanVien(nvDTO);
        }
    }
}
