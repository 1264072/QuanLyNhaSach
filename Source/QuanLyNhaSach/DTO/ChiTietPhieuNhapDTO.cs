using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuNhapDTO
    {
        string mAPN;
        int mADS;
        int sOLUONG;
        double dONGIA;
        double tHANHTIEN;

        public double THANHTIEN
        {
            get { return tHANHTIEN; }
            set { tHANHTIEN = value; }
        }

        public double DONGIA
        {
            get { return dONGIA; }
            set { dONGIA = value; }
        }

        public int SOLUONG
        {
            get { return sOLUONG; }
            set { sOLUONG = value; }
        }

        public int MADS
        {
            get { return mADS; }
            set { mADS = value; }
        }

        public string MAPN
        {
            get { return mAPN; }
            set { mAPN = value; }
        }

        public ChiTietPhieuNhapDTO() { }
    }
}
