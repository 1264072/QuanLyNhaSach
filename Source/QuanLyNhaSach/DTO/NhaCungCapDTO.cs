using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCapDTO
    {
        string mANCC;
        string tENNCC;
        string sDT;
        string dIACHI;
        string eMAIL;

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

        public string TENNCC
        {
            get { return tENNCC; }
            set { tENNCC = value; }
        }

        public string MANCC
        {
            get { return mANCC; }
            set { mANCC = value; }
        }

        public NhaCungCapDTO() { }
    }
}
