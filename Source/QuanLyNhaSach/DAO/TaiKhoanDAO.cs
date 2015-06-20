using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class TaiKhoanDAO
    {
        // Hàm kiểm tra đăng nhập
        // false : Sai tài khoản hoặc mật khẩu
        // true : Đăng nhập thành công
        public static bool DangNhap(string username, string password)
        {
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                TAIKHOAN taiKhoan = bs.TAIKHOANs.Where(t => t.USERNAME == username).FirstOrDefault();
                if (taiKhoan != null)
                {
                    if (taiKhoan.PASSWORD != password)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }        
        }

        // Hàm ghi nhớ tài khoản
        public static int GhiNhoTaiKhoan(string username, string password, bool status)
        {
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                NHOMATKHAU taiKhoan = bs.NHOMATKHAUs.FirstOrDefault();
                taiKhoan.USERNAME = username;
                taiKhoan.PASSWORD = password;
                taiKhoan.TRANGTHAI = status;

                int i = bs.SaveChanges();
                return i;
            }
        }

        // Hàm lấy tài khoản đã ghi nhớ
        public static NhoMatKhauDTO LayTaiKhoan()
        {
            NhoMatKhauDTO taiKhoan = new NhoMatKhauDTO();
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                NHOMATKHAU tk = bs.NHOMATKHAUs.FirstOrDefault();
                taiKhoan.USERNAME = tk.USERNAME;
                taiKhoan.PASSWORD = tk.PASSWORD;
                taiKhoan.TRANGTHAI = tk.TRANGTHAI;
                return taiKhoan;
            }
        }


        public static int DoiMatKhau(string username, string newpass)
        {
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                TAIKHOAN tk = bs.TAIKHOANs.Where(t => t.USERNAME == username).FirstOrDefault();
                if (tk != null)
                {
                    tk.PASSWORD = newpass;
                    bs.NHOMATKHAUs.Where(m => m.USERNAME == tk.USERNAME).FirstOrDefault().TRANGTHAI = false;
                }                
                int i = bs.SaveChanges();

                return i;
            }
        }

        public static bool KiemTraMatKhau(string username, string oldpass)
        {
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                TAIKHOAN tk = bs.TAIKHOANs.Where(t => t.USERNAME == username).FirstOrDefault();
                if (tk.PASSWORD == oldpass)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
