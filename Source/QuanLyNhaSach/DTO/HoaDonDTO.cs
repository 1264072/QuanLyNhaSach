using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        string mAHD;
        string mAKH; 
        DateTime nGAYLAP;
        string mANV;
        double tONGTIEN;
        double tIENTRA;
        double tIENNO;

        public double TIENNO
        {
            get { return tIENNO; }
            set { tIENNO = value; }
        }

        public double TIENTRA
        {
            get { return tIENTRA; }
            set { tIENTRA = value; }
        }

        public double TONGTIEN
        {
            get { return tONGTIEN; }
            set { tONGTIEN = value; }
        }

        public string MANV
        {
            get { return mANV; }
            set { mANV = value; }
        }

        public DateTime NGAYLAP
        {
            get { return nGAYLAP; }
            set { nGAYLAP = value; }
        }

        public string MAKH
        {
            get { return mAKH; }
            set { mAKH = value; }
        }

        public string MAHD
        {
            get { return mAHD; }
            set { mAHD = value; }
        }


        public HoaDonDTO() { }
    }
}
