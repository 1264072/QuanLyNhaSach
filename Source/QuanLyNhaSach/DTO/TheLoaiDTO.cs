using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TheLoaiDTO
    {
        string mATL;
        string tENTL;

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

        public TheLoaiDTO() { }
    }
}
