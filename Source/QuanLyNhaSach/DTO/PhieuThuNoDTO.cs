using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuThuNoDTO
    {
        string mAPT;
        string mAKH;
        DateTime nGAYLAP;
        double tIENNO;
        double tIENTHU;
        double cONNO;
        string mANV;

        public string MANV
        {
            get { return mANV; }
            set { mANV = value; }
        }

        public double CONNO
        {
            get { return cONNO; }
            set { cONNO = value; }
        }

        public double TIENTHU
        {
            get { return tIENTHU; }
            set { tIENTHU = value; }
        }

        public double TIENNO
        {
            get { return tIENNO; }
            set { tIENNO = value; }
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

        public string MAPT
        {
            get { return mAPT; }
            set { mAPT = value; }
        }

        public PhieuThuNoDTO() { }
    }
}
