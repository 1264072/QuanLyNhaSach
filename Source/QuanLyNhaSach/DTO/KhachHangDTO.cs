using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        string mAKH;
        string hOTEN;
        string dIACHI;
        string sDT;
        string eMAIL;
        bool nO;

        public bool NO
        {
            get { return nO; }
            set { nO = value; }
        }

        public string EMAIL
        {
            get { return eMAIL; }
            set { eMAIL = value; }
        }

        public string SDT
        {
            get { return sDT; }
            set { sDT = value; }
        }

        public string DIACHI
        {
            get { return dIACHI; }
            set { dIACHI = value; }
        }

        public string HOTEN
        {
            get { return hOTEN; }
            set { hOTEN = value; }
        }

        public string MAKH
        {
            get { return mAKH; }
            set { mAKH = value; }
        }

        public KhachHangDTO() { }
    }
}
