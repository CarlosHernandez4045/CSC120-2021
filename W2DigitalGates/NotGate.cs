using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2DigitalGates
{
    class NotGate
    {
        public static bool Input(bool result)
        {
            if (result == true)
            {
                return false;
            }
            return true;
        }
    }
}
