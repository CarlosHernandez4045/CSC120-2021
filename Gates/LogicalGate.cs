using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gates
{
    class LogicalGate
    {
        //Result stores the intermediate value
        public bool Result { get; set; }
        public LogicalGate And(bool x, bool y)
        {
            Result = x && y;
            return this;
        }
        public LogicalGate Or(bool x, bool y)
        {
            Result = (x || y);
            return this;
        }
        public LogicalGate Or(bool y)
        {
            Result = (Result || y);
            return this;
        }
        public LogicalGate Not(bool x)
        {
            Result = !x;
            return this;
        }
    }
}
