using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRLatch
{
    class Convert
    {
        public static bool toBoolean(string s) => s == "1" ? true : false ;

        public static string toBinary(bool val) => val ? "1" : "0";
    }
}
