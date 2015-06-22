using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class PhieuNhapBUS
    {
        public static int ThemPhieuNhap(PhieuNhapDTO pn)
        {
            return PhieuNhapDAO.ThemPhieuNhap(pn);
        }
    }
}
