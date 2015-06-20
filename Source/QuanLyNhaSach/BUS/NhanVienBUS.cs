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
    }
}
