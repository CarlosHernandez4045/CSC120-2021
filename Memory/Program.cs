using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Memory
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputPutDataFile = @"D:\Documents\inputdata.txt";

            if (File.Exists(inputPutDataFile))
            {
                //this method can remember where it crashed and will pick up where it left off
                var truthTableInputs = Storage.ReadWithMemory(true, inputPutDataFile); //first bool value controls if it reads with memory function

                foreach (var input in truthTableInputs)
                {
                    //In it's current config, it's running 3:1 mux calculations, you can uncomment and comment below in order to get 2:1
                    var gate = new LogicalGate() { InputA = input.A, InputD = input.D, InputX = input.X };
                    //var gate = new LogicalGate() { InputA = input.A, InputD = input.D };
                    //var result = gate.AndGate();
                    bool result = (bool)gate.BooleanAlgebraGate(); //evaluates the L = D + AX gate where X is notted. The equation for the data.
                    if (gate.DoesntHave3Vars())
                    {
                        TwoVarEval(gate.InputA, gate.InputD, input.L, result);
                        Storage.SaveTruthTableData(input);
                    }
                    else
                    {
                        ThreeVarEval(gate.InputA, gate.InputD, gate.InputX, input.L, result);
                        Storage.SaveTruthTableData(input);
                    }
                    Storage.SaveTruthTableData(input);
                    Console.ReadKey(true);
                }
                Storage.WipeMemoryFile();
                Console.WriteLine("Memory file wiped after successful run. Press any key to exit.");
                Console.ReadKey(true);
            }
            else
            {
                Console.WriteLine("The inputted file path does not exist. Please try again."); //output user error
            }

        }
        static void TwoVarEval(bool A, bool D, bool resultFromTxt, bool result)
        {
            if (resultFromTxt == result)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Success for inputs: {Utility.ConvertToBinary(A)}, {Utility.ConvertToBinary(D)}" +
                    $"\nThe results for A = {A} and D = {D} was {resultFromTxt} \n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Failure for inputs: {Utility.ConvertToBinary(A)}, {Utility.ConvertToBinary(D)}"+
                    $"\nThe result for the Logic Gate: {resultFromTxt} did not match the expected result of {result} for the data provided.\n");
            }
        }
        static void ThreeVarEval(bool A, bool D, bool X, bool resultFromTxt, bool result)
        {
            if (resultFromTxt == result)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Success for inputs: A = {Utility.ConvertToBinary(A)}, D = {Utility.ConvertToBinary(D)}, X = {Utility.ConvertToBinary(X)}" +
                    $"\nThe result from the Logic Gate was {resultFromTxt} \n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Failure for inputs: A = {Utility.ConvertToBinary(A)}, D = {Utility.ConvertToBinary(D)}, X = {Utility.ConvertToBinary(X)}"+
                    $"\nThe result for Logic Gate: {result} did not match the expected result of {resultFromTxt} for the data provided.\n");
            }
        }
    }
}
