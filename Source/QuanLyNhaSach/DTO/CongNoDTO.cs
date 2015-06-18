using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CongNoDTO
    {
        string mAKH;
        DateTime nGAYPHATSINH;
        double nODAU;
        double pHATSINH;
        double nOCUOI;

        public double NOCUOI
        {
            get { return nOCUOI; }
            set { nOCUOI = value; }
        }

        public double PHATSINH
        {
            get { return pHATSINH; }
            set { pHATSINH = value; }
        }

        public double NODAU
        {
            get { return nODAU; }
            set { nODAU = value; }
        }

        public string MAKH
        {
            get { return mAKH; }
            set { mAKH = value; }
        }

        public CongNoDTO() { }
    }
}
