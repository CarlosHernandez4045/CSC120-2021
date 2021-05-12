using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class LogicalGate
    {
        //didnt change truth table to A,B,R to not go away from assignment input data
        public bool result { get; set; }
        public bool InputD { get; set; }
        public bool InputA { get; set; }
        private bool? inputX { get; set; }
        public bool InputX 
        {
            get
            {
                return inputX.HasValue ? inputX.Value : false;
            }
            set
            {
                inputX = (bool)value; 
            }
        }

        public bool DoesntHave3Vars()
        {
            return inputX == null;
        }

        public bool AndGate() => InputD && InputA;

        public bool AndGate(bool x, bool y) => x && y; //uses override to be able to OR any inputs (will use for >2:1 mux)

        public bool OrGate() => InputA || InputD;

        public bool OrGate(bool x, bool y) => x || y; //uses override to be able to AND any inputs (will use for >2:1 mux)

        public bool NotGate(bool val) => !val;

        public bool XorGate() => InputD ^ InputA;

        public bool AndThenNotGate()
        {
            var andGateResult = AndGate();

            return !andGateResult;
        }
        public bool OrThenNot()
        {
            var orGateResult = OrGate();

            return !orGateResult ;
        }
        //gates made for 3 variables, or 3:1 mux
        public bool? Or2And2ThenOrGate() //naming one of these is weird.
        {
            var orGateAB = OrGate();

            var andGateBC = AndGate(InputA, InputX);

            var finalOr = OrGate(orGateAB, andGateBC);

            return finalOr;
        }
        public bool? BooleanAlgebraGate()
        {
            /* this will evaluate L = D + AX where X is notted
             * this equation was used in the Boolean Algebra assignment
             */
            var andGateAX = AndGate(InputA, !InputX);

            return InputD || andGateAX;
        }
    }
}
