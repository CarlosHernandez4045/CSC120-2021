using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2DigitalGates
{
    class XnorGate
    {
        public static bool Input(bool x, bool y)
        {
            if (x ^ y)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
