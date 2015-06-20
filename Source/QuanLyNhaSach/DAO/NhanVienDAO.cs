using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class NhanVienDAO
    {
        public static NhanVienDTO LayNhanVienTheoTaiKhoan(string username)
        {
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                TAIKHOAN tk = bs.TAIKHOANs.Where(t => t.USERNAME == username).FirstOrDefault();
                NHANVIEN nv = bs.NHANVIENs.Where(n => n.MANV == tk.MANV).FirstOrDefault();
                NhanVienDTO nvDTO = new NhanVienDTO();
                nvDTO.MANV = nv.MANV;
                nvDTO.HOTEN = nv.HOTEN;
                nvDTO.DIACHI = nv.DIACHI;
                nvDTO.EMAIL = nv.EMAIL;
                nvDTO.SDT = nv.SDT;
                nvDTO.MACV = nv.MACV;
                return nvDTO;
            }
        }
    }
}
