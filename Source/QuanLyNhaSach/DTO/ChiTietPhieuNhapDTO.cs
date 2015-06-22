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
        decimal dONGIA;
        decimal tHANHTIEN;
        string tENDAUSACH;
        string tENTL;
        string tACGIA;

        public string TACGIA
        {
            get { return tACGIA; }
            set { tACGIA = value; }
        }

        public string TENTL
        {
            get { return tENTL; }
            set { tENTL = value; }
        }

        public string TENDAUSACH
        {
            get { return tENDAUSACH; }
            set { tENDAUSACH = value; }
        }

        public decimal THANHTIEN
        {
            get { return tHANHTIEN; }
            set { tHANHTIEN = value; }
        }

        public decimal DONGIA
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
