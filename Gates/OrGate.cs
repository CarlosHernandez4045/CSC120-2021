using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gates
{
    class OrGate
    {
        public static bool Input(bool x, bool y)
        {
            return (x || y);
        }
    }
}
