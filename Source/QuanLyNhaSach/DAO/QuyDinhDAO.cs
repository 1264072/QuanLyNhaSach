using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class QuyDinhDAO
    {
        public static QuyDinhDTO LayQuyDinh()
        {
            using (BookStoreEntities bs = new BookStoreEntities())
            {
                QUYDINH qd = bs.QUYDINHs.ToList().FirstOrDefault();
                QuyDinhDTO dto = new QuyDinhDTO()
                {
                    NHAPTOITHIEU = qd.NHAPTOITHIEU,
                    NOTOIDA = qd.NOTOIDA,
                    THUQUANO = qd.THUQUANO,
                    TONSAUBAN = qd.TONSAUBAN,
                    TONTRUOCNHAP = qd.TONTRUOCNHAP
                };
                return dto;
            }
        }
    }
}
