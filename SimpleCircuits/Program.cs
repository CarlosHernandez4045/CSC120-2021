using System;
using System.Collections.Generic;
using System.Threading;

namespace SimpleCircuits
{
    class Program
    {
        static int numberOfInputs = 6;
        static void Main(string[] args)
        {
            //create and initialize graph
            Graph.Initialize();
            //generate all possible inputs
            Input.Generate(numberOfInputs);
            //displays list of gates based on possible inputs
            var listOfGates = Input.ConvertToLogicList(numberOfInputs);



            //loop over gates and keep adding/evaluating them
            foreach (var gate in listOfGates)
            {
                var outputBinary = new List<string>();
                foreach (var input in gate.NumberOfInputs)
                {
                    outputBinary.Add(Function.ConvertToBinary(input).ToString());
                    var result = gate.ProcessAsAndGate();

                    //add current gate to graph elements
                    Graph.AddToTLine(result);
                    Graph.AddToBLine(result);

                }
                var stringBinary = String.Concat(outputBinary.ToArray());
                Console.WriteLine("Inputs: " + stringBinary);
                Graph.AddToInputFile(stringBinary);
            }
            //print graph based on those inputs and evaluations
            Console.WriteLine("\nEach input is represented by one dash. Here is the graph.\n");
            Graph.PrintGraph();
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey(true);
        }

    }

}

