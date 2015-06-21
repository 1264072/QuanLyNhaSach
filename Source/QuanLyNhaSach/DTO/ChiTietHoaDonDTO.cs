using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDonDTO
    {
        string mAHD;
        int mADS;
        string mATL;
        int sOLUONG;
        decimal dONGIA;
        decimal tHANHTIEN;
        string tENDAUSACH;
        string tENTL;

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

        public string MATL
        {
            get { return mATL; }
            set { mATL = value; }
        }

        public int MADS
        {
            get { return mADS; }
            set { mADS = value; }
        }

        public string MAHD
        {
            get { return mAHD; }
            set { mAHD = value; }
        }

        public ChiTietHoaDonDTO() { }
    }
}
