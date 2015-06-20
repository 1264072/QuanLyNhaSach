using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhaCungCapBUS
    {
        public static List<NhaCungCapDTO> LayDanhSach()
        {
            return NhaCungCapDAO.LayDanhSach();
        }

        public static int ThemNhaCungCap(NhaCungCapDTO NccDTO)
        {
            return NhaCungCapDAO.ThemNhaCungCap(NccDTO);
        }

        public static int ChinhSuaNhaCungCap(NhaCungCapDTO NccDTO)
        {
            return NhaCungCapDAO.ChinhSuaNhaCungCap(NccDTO);
        }

        public static int XoaNhaCungCap(NhaCungCapDTO NCC)
        {
            return NhaCungCapDAO.XoaNhaCungCap(NCC);
        }
    }
}
