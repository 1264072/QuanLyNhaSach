using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class TaiKhoanBUS
    {
        public static bool DangNhap(string username, string password)
        {
            return TaiKhoanDAO.DangNhap(username, password);
        }

        public static int GhiNhoTaiKhoan(string username, string password, bool status)
        {
            return TaiKhoanDAO.GhiNhoTaiKhoan(username, password, status);
        }

        public static NhoMatKhauDTO LayTaiKhoan()
        {
            return TaiKhoanDAO.LayTaiKhoan();
        }
    }
}
