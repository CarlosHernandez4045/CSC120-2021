using System;
using System.Collections.Generic;

namespace Gates
{
    class Program
    {
        static void Main(string[] args)
        {
            var truthTable = new List<GateInputs>();
            truthTable.Add(new GateInputs {X = false, Y = false });
            truthTable.Add(new GateInputs {X = true, Y = false });
            truthTable.Add(new GateInputs {X = false, Y = true });
            truthTable.Add(new GateInputs {X = true, Y = true });
            Console.WriteLine("X | Y | Z");
            foreach (var row in truthTable)
            {
                var result = AndGate.Input(row.X, row.Y);
                Console.WriteLine("____________");
                string xas = row.X ? "1" : "0";
                string yas = row.X ? "1" : "0";
                var resultAs = result ? "1" : "0";
                Console.WriteLine($"{xas} | {yas} | {resultAs}");
            }
        }
        static void Test1()
        {
            var x = true;
            var y = false;
            var result = OrGate.Input(x, y);
            Console.WriteLine($"The result of AndGate for inputs of" +
                $" X = {x} and Y = {y} is equal to {result}");
        }
    }
}
