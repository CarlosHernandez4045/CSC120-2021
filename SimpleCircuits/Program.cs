using System;
using System.Threading;

namespace SimpleCircuits
{
    class Program
    {
        static void Main(string[] args)
        {
            Input.Generate(10); //will generate whatever amount of binary inputs. in this case 10

            var logicList = Input.ConvertToLogicList();

            foreach(var item in logicList)
            {
                var gateEval = new LogicGate()
                {
                    Input1 = item.Input1,
                    Input2 = item.Input2,
                    Input3 = item.Input3,
                    Input4 = item.Input4,
                    Input5 = item.Input5,
                    Input6 = item.Input6,
                    Input7 = item.Input7,
                    Input8 = item.Input8,
                    Input9 = item.Input9,
                    Input10 = item.Input10,

                };
                bool result = gateEval.TenVar();
                string inputs = $"{Function.ConvertToBinary(item.Input1)}{Function.ConvertToBinary(item.Input2)}{Function.ConvertToBinary(item.Input3)}{Function.ConvertToBinary(item.Input4)}" +
                    $"{Function.ConvertToBinary(item.Input5)}{Function.ConvertToBinary(item.Input6)}{Function.ConvertToBinary(item.Input7)}" +
                    $"{Function.ConvertToBinary(item.Input8)}{Function.ConvertToBinary(item.Input9)}{Function.ConvertToBinary(item.Input10)}";
                Console.WriteLine($"Inputs: {inputs}");
                if (result)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Result: {Function.ConvertToBinary(result)}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Result: {Function.ConvertToBinary(result)}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            
            Console.ReadKey(true);
        }
    }
}
