using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2DigitalGates
{
    class NorGate
    {
        public static bool Input(bool x, bool y)
        {
            if (x.Equals(true) | y.Equals(true))
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
