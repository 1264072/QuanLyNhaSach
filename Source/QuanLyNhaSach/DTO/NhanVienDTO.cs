using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        string mANV;
        string hOTEN;
        string sDT;
        string dIACHI;
        string eMAIL;
        string mACV;
        string tENCV;

        public string TENCV
        {
            get { return tENCV; }
            set { tENCV = value; }
        }

        public string MACV
        {
            get { return mACV; }
            set { mACV = value; }
        }

        public string EMAIL
        {
            get { return eMAIL; }
            set { eMAIL = value; }
        }

        public string DIACHI
        {
            get { return dIACHI; }
            set { dIACHI = value; }
        }

        public string SDT
        {
            get { return sDT; }
            set { sDT = value; }
        }

        public string HOTEN
        {
            get { return hOTEN; }
            set { hOTEN = value; }
        }

        public string MANV
        {
            get { return mANV; }
            set { mANV = value; }
        }

        public NhanVienDTO() { }
    }
}
