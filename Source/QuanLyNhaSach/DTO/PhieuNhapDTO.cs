using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhapDTO
    {
        string mAPN;
        DateTime nGAYLAP;
        string mANV;
        string mANCC;
        decimal tONGTIEN;
        decimal cONNO;
        string tENNV;
        string tENNCC;

        public string TENNCC
        {
            get { return tENNCC; }
            set { tENNCC = value; }
        }

        public string TENNV
        {
            get { return tENNV; }
            set { tENNV = value; }
        }

        public decimal CONNO
        {
            get { return cONNO; }
            set { cONNO = value; }
        }

        public decimal TONGTIEN
        {
            get { return tONGTIEN; }
            set { tONGTIEN = value; }
        }

        public string MANCC
        {
            get { return mANCC; }
            set { mANCC = value; }
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

        public string MAPN
        {
            get { return mAPN; }
            set { mAPN = value; }
        }

        public PhieuNhapDTO() { }
    }
}
