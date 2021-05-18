using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimpleCircuits
{
    class Input
    {
        static string INPUTS = "InputSet.txt";
        //wipes input file
        private static void WipeInputFile()
        {
            var fs = new FileStream(INPUTS, FileMode.Create);
            fs.Close();
        }
        //checks if a string is already in input file
        private static bool AlreadyInFile(string input)
        {
            foreach (string line in File.ReadLines(INPUTS))
            {
                if (line.Equals(input))
                {
                    return true;
                }
            }
            return false;
        }
        // converts inputs file created in Generate() to a List of Logic Gates
        public static List<LogicGate> ConvertToLogicList( int numberOfInputs)
        {
            var inputList = new List<LogicGate>();
            var fs = new FileStream(INPUTS, FileMode.Open);
            var sr = new StreamReader(fs);

            string data = String.Empty;
            while ((data = sr.ReadLine()) != null)
            {
                var dataSplit = data.Split(',').ToList<string>();
                var gate = new LogicGate(numberOfInputs);
                for (int i = 0;i <gate.NumberOfInputs.Count; i++)
                {
                    gate.NumberOfInputs[i] = Function.ConvertToBool(dataSplit[i]);
                }
               
                inputList.Add(gate);
            } 
            return inputList;
        }
        //gemerates all possible combinations of x binary inputs based on parameter given
        public static void Generate(int inputCount)
        {
            Console.WriteLine($"Generating All Possible Inputs Based On {inputCount} Inputs....");
            WipeInputFile();
            var rand = new Random();

            int validInputs = 0;

            while(validInputs != Math.Pow(2, inputCount))
            {
                string input = "";
                for (int f = 0; f < inputCount; f++)
                {
                    int randomBinary = rand.Next(2);


                    if (f == inputCount - 1)
                    {
                        input += $"{randomBinary}";
                    }
                    else
                    {
                        input += $"{randomBinary},";
                    }

                }
                if (AlreadyInFile(input))
                {
                    continue;
                }
                else
                {
                    var fs = new FileStream(INPUTS, FileMode.Append);
                    var sw = new StreamWriter(fs);
                    sw.WriteLine(input);
                    sw.Flush();
                    sw.Close();
                    fs.Close();
                    validInputs++;
                }
            }
            Console.WriteLine("Generation Complete!\n");
        }
    }
}
