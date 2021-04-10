using System;
using System.Collections.Generic;

namespace W2DigitalGates
{
    class Program
    { //Line 18 and 19 to test different logic gates!
        static void Main(string[] args)
        {
            var truthTable = new List<GateInputs>();
            truthTable.Add(new GateInputs { X = false, Y = false });
            truthTable.Add(new GateInputs { X = true, Y = false });
            truthTable.Add(new GateInputs { X = false, Y = true });
            truthTable.Add(new GateInputs { X = true, Y = true });
            Console.WriteLine("X | Y | Z");
            foreach (var row in truthTable)
            {
                var result = NandGate.Input(row.X, row.Y); //Use this to test different class gate methods
                result = NotGate.Input(result); //Use this to NOT gate, comment out if needed
                Console.WriteLine("____________");
                string xAs = row.X ? "1" : "0";
                string yAs = row.Y ? "1" : "0";
                var resultAs = result ? "1" : "0";
                Console.WriteLine($"{xAs} | {yAs} | {resultAs}");
            }
        }
    }
}
