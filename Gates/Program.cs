using System;
using System.Collections.Generic;

namespace Gates
{
    class Program
    {
        static void Main(string[] args)
        {
            var truthTable = new List<GateInputs2>();
            truthTable.Add(new GateInputs2 { A = false, B = false, C = false });
            truthTable.Add(new GateInputs2 { A = false, B = false, C = true });
            truthTable.Add(new GateInputs2 { A = false, B = true, C = false });
            truthTable.Add(new GateInputs2 { A = false, B = true, C = true });
            truthTable.Add(new GateInputs2 { A = true, B = false, C = false });
            truthTable.Add(new GateInputs2 { A = true, B = true, C = false });
            truthTable.Add(new GateInputs2 { A = true, B = true, C = true });
            truthTable.Add(new GateInputs2 { A = true, B = false, C = true });
            Console.WriteLine("A | B | C | Z");
            foreach (var row in truthTable)
            {
                var bc = OrGate.Input(row.B, row.C);
                var z = AndGate.Input(bc, row.A);
                Console.WriteLine("____________");
                string aas = row.A ? "1" : "0";
                string bas = row.B ? "1" : "0";
                string cas = row.C ? "1" : "0";
                var resultAs = z ? "1" : "0";
                Console.WriteLine($"{aas} | {bas} | {cas} | {resultAs}");
            }
        }
        static void CircuitTest()
        {
            var a = false;
            var b = false;
            var c = false;

            var bc = OrGate.Input(b, c);
            var z = AndGate.Input(bc, a);

            Console.WriteLine($"the result of NotGate for inputs of" +
                    $" A = {a}, B = {b}, C = {c} is equal to {z}");
        }
        static void NotGateTest()
        {
            var x = true;
            var result = NotGate.Input(x);
            Console.WriteLine($"the result of NotGate for inputs of" +
                $" x = {x} is equal to {result}");
        }
        static void OrGateTest()
        {
            var truthTable = new List<GateInputs>();
            truthTable.Add(new GateInputs { X = false, Y = false });
            truthTable.Add(new GateInputs { X = true, Y = false });
            truthTable.Add(new GateInputs { X = false, Y = true });
            truthTable.Add(new GateInputs { X = true, Y = true });
            Console.WriteLine("X | Y | Z");
            foreach (var row in truthTable)
            {
                var result = OrGate.Input(row.X, row.Y);
                Console.WriteLine("____________");
                string xas = row.X ? "1" : "0";
                string yas = row.Y ? "1" : "0";
                var resultAs = result ? "1" : "0";
                Console.WriteLine($"{xas} | {yas} | {resultAs}");
            }
        }
    }
}
