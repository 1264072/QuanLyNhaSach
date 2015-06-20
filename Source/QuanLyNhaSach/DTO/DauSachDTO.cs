using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DauSachDTO
    {
        string tENSACH;
        string mATL;
        string tENTL;
        string tACGIA;
        int sOLUONG;
        double dONGIA;

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

        public DauSachDTO() { }
    }
}
