using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartA
{
    class Identity
    {
        public bool SetInputD { get; set; }
        public bool SetInputA { get; set; }
        public bool SetInputX { get; set; }

        public bool Validate()
        {

            SetInputX = !SetInputX; //putting the input X through a Not Gate
            var AX = false; // This will be our placeholder bool val for AX

            if(SetInputA && SetInputX) // The AND Gate Operation we'll put the inputs through
            {
                AX = true;
            }

            return SetInputD | AX; // The final OR Gate value is the value of L or our result.
        }
    }
}
