using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TonKhoDTO
    {
        int mADS;
        DateTime nGAYPHATSINH;
        int tONDAU;
        int pHATSINH;
        int tONCUOI;

        public int TONCUOI
        {
            get { return tONCUOI; }
            set { tONCUOI = value; }
        }

        public int PHATSINH
        {
            get { return pHATSINH; }
            set { pHATSINH = value; }
        }

        public int TONDAU
        {
            get { return tONDAU; }
            set { tONDAU = value; }
        }

        public DateTime NGAYPHATSINH
        {
            get { return nGAYPHATSINH; }
            set { nGAYPHATSINH = value; }
        }

        public int MADS
        {
            get { return mADS; }
            set { mADS = value; }
        }

        public TonKhoDTO() { }
    }
}
