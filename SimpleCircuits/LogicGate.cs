using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCircuits
{
    class LogicGate
    {
        public bool Input1 { get; set; }
        public bool Input2 { get; set; }
        public bool Input3 { get; set; }
        public bool Input4 { get; set; }
        public bool Input5 { get; set; }
        public bool Input6 { get; set; }
        public bool Input7 { get; set; }
        public bool Input8 { get; set; }
        public bool Input9 { get; set; }
        public bool Input10 { get; set; }

        //will eval a 10:1 mux you can find here: https://www.circuitlab.com/circuit/863gf39qs9hn/circuit-documentation/
        public bool TenVar()
        {
            //something
            bool AND1 = Input1 && Input2;
            bool OR2 = Input3 | Input4;
            bool AND2 = Input5 && Input6;
            bool OR3 = Input7 | Input8;
            bool AND3 = Input9 && Input10;

            bool NOT1 = !AND1;
            bool OR1 = NOT1 | OR2;
            bool AND4 = OR3 && AND2;

            bool OR4 = AND4 | OR1;

            bool AND5 = OR4 && AND3;

            return AND5; 
        }
    }
}
