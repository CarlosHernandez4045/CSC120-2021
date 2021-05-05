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
                    Thread.Sleep(1000);
                    Console.WriteLine($"{Utility.ConvertToBinary(input.A)}, {Utility.ConvertToBinary(input.X)}, {Utility.ConvertToBinary(input.D)}, {Utility.ConvertToBinary(input.L)}");
                    Storage.SaveTruthTableData(input);
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
    }
}
