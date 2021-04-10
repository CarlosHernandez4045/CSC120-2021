using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2DigitalGates
{
    class XorGate
    {
        public static bool Input(bool x, bool y)
        {
            if (x ^ y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
