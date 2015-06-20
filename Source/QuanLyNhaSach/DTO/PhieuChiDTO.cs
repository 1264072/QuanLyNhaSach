using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuChiDTO
    {
        string mAPC;
        string mANV;
        DateTime nGAYLAP;
        double tIENCHI;
        string mAPN;
        string tENNV;

        public string TENNV
        {
            get { return tENNV; }
            set { tENNV = value; }
        }

        public string MAPN
        {
            get { return mAPN; }
            set { mAPN = value; }
        }

        public double TIENCHI
        {
            get { return tIENCHI; }
            set { tIENCHI = value; }
        }

        public DateTime NGAYLAP
        {
            get { return nGAYLAP; }
            set { nGAYLAP = value; }
        }

        public string MANV
        {
            get { return mANV; }
            set { mANV = value; }
        }

        public string MAPC
        {
            get { return mAPC; }
            set { mAPC = value; }
        }

        public PhieuChiDTO() { }
    }
}
