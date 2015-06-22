using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class DuLieuBUS
    {
        public static int SaoLuu(string path)
        {
            return DuLieuDAO.SaoLuu(path);
        }

        public static int PhucHoi(string path)
        {
            return DuLieuDAO.PhucHoi(path);
        }
    }
}
