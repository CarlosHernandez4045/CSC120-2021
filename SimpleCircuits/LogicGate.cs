using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCircuits
{
    class LogicGate
    {
       

        private List<bool> Inputs = new List<bool>();
        public LogicGate(int numberOfInputs) // coinstructor
        {
            for (int i = 0; i < numberOfInputs; i++)
            {
                Inputs.Add(false);
            }
        }

        //will eval a 10:1 mux you can find here: https://www.circuitlab.com/circuit/863gf39qs9hn/circuit-documentation/
        public List<bool> NumberOfInputs
        {
            get
            {
                return Inputs;
            }
        }

        public bool ProcessAsAndGate()
        {
            bool result = false;
            bool init = false;
            
            foreach(var input in Inputs)
            {
                if (init == false)
                {
                    result = input;
                    continue;
                }
                else
                {
                    result = result && input;
                }
            }
            return result;
        }
        public bool ProcessAsOrGate()
        {
            bool result = false;
            bool init = false;

            foreach (var input in Inputs)
            {
                if (init == false)
                {
                    result = input;
                    continue;
                }
                else
                {
                    result = result | input;
                }
            }
            return result;
        }
    }
}
