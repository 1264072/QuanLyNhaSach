using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public delegate void Listener(object sender, MyDelegate e);
    public class MyDelegate : EventArgs
    {
        public object Data;
        public MyDelegate(object input)
        {
            Data = input;
        }
    }
}
