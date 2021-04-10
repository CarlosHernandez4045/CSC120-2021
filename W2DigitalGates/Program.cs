using System;
using System.Collections.Generic;

namespace W2DigitalGates
{
    class Program
    {
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
                var result = XnorGate.Input(row.X, row.Y);
                Console.WriteLine("____________");
                string xAs = row.X ? "1" : "0";
                string yAs = row.Y ? "1" : "0";
                var resultAs = result ? "1" : "0";
                Console.WriteLine($"{xAs} | {yAs} | {resultAs}");
            }
        }
    }
}
