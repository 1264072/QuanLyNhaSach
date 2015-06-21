using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuyDinhDTO
    {
        int nHAPTOITHIEU;
        int tONTRUOCNHAP;
        int tONSAUBAN;
        decimal nOTOIDA;
        bool tHUQUANO;

        public bool THUQUANO
        {
            get { return tHUQUANO; }
            set { tHUQUANO = value; }
        }

        public decimal NOTOIDA
        {
            get { return nOTOIDA; }
            set { nOTOIDA = value; }
        }

        public int TONSAUBAN
        {
            get { return tONSAUBAN; }
            set { tONSAUBAN = value; }
        }

        public int TONTRUOCNHAP
        {
            get { return tONTRUOCNHAP; }
            set { tONTRUOCNHAP = value; }
        }

        public int NHAPTOITHIEU
        {
            get { return nHAPTOITHIEU; }
            set { nHAPTOITHIEU = value; }
        }

        public QuyDinhDTO() { }
    }
}
