using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class TheLoaiBUS
    {
        public static List<TheLoaiDTO> LayDanhSach()
        {
            return TheLoaiDAO.LayDanhSach();
        }
    }
}
