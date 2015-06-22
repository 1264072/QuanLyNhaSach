using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DauSachDTO
    {
        int mADS;
        string tENSACH;
        string mATL;
        string tENTL;
        string tACGIA;
        int sOLUONG;
        decimal dONGIA;
        decimal tHANHTIEN;

        public decimal THANHTIEN
        {
            get { return sOLUONG*dONGIA; }
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

        public string MATL
        {
            get { return mATL; }
            set { mATL = value; }
        }

        public string TENSACH
        {
            get { return tENSACH; }
            set { tENSACH = value; }
        }

        public int MADS
        {
            get { return mADS; }
            set { mADS = value; }
        }

        public DauSachDTO() { }
    }
}
