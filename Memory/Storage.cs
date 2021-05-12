using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    public class Storage
    {
        static string STORAGE = "MyStore.txt";

        public static void WipeMemoryFile()
        {
            var wipe = new FileStream(STORAGE, FileMode.Create);
            wipe.Close();
        }

        //2:1 mux version
        public static bool SaveTruthTableData(int val1, int val2, int result)
        {
            var fs = new FileStream(STORAGE, FileMode.Open);
            var sw = new StreamWriter(fs);
            sw.WriteLine($"{val1},{val2},{result}");
            sw.Flush();
            sw.Close();
            fs.Close();
            return true;
        }

        //3:1 mux version
        public static bool SaveTruthTableData(int val1, int val2, int val3, int result)
        {
            var fs = new FileStream(STORAGE, FileMode.Open);
            var sw = new StreamWriter(fs);
            sw.WriteLine($"{val1},{val2},{val3},{result}");
            sw.Flush();
            sw.Close();
            fs.Close();
            return true;
        }

        public static bool SaveTruthTableData(int elementCount, TruthTable tt)
        {
            if (elementCount == 3)
            {
                return SaveTruthTableData(
                        tt.A ? 1 : 0,
                        tt.D ? 1 : 0,
                        tt.L ? 1 : 0
                        );
            }
            else if (elementCount == 4)
            {
                return SaveTruthTableData(
                            tt.A ? 1 : 0,
                            tt.D ? 1 : 0,
                            tt.X ? 1 : 0,
                            tt.L ? 1 : 0
                            );
            }
            else
            {
                return SaveTruthTableData(
                            tt.A ? 1 : 0,
                            tt.D ? 1 : 0,
                            tt.X ? 1 : 0,
                            tt.L ? 1 : 0
                            );
            }
        }
        public static List<TruthTable> ReadWithMemory(bool active, string dataPath)
        {
            if (new FileInfo(STORAGE).Length == 0)
            {
                return ReadTruthTableData(dataPath);
            }
            else if(active)
            {
                return ReadTruthTableFromMem(dataPath);
            }
            else
            {
                return ReadTruthTableData(dataPath);
            }
        }
        public static List<TruthTable> ReadTruthTableData(string dataPath)
        {

            var inputList = new List<TruthTable>();
            var fs = new FileStream(dataPath, FileMode.Open);
            var sr = new StreamReader(fs);
            var header = sr.ReadLine();
            Console.WriteLine("Header: " + header + "\n"); // print header with variables
            string data;
            while ((data = sr.ReadLine()) != null) //read till End of File
            {
                var inputRow = new TruthTable();

                var dataElements = data.Split(','); // 0,1,0,1  will be split into arrays
                if (dataElements.Length == 3)
                {
                    inputRow.A = Utility.ConvertToBoolean(dataElements[0]);
                    inputRow.D = Utility.ConvertToBoolean(dataElements[1]);
                    inputRow.L = Utility.ConvertToBoolean(dataElements[2]);
                }
                else if (dataElements.Length == 4)
                {
                    inputRow.A = Utility.ConvertToBoolean(dataElements[0]);
                    inputRow.D = Utility.ConvertToBoolean(dataElements[1]);
                    inputRow.X = Utility.ConvertToBoolean(dataElements[2]);
                    inputRow.L = Utility.ConvertToBoolean(dataElements[3]);
                }
                else
                {
                    Console.WriteLine("This program isn't suited for the amount of elements in the given data. " +
                        "\n Please try again with a 2:1 or 3:1 multiplexer. Exiting now.");
                }

                SaveTruthTableData(dataElements.Length, inputRow);
                inputList.Add(inputRow);
            }
             sr.Close();
             fs.Close();

             return inputList;

        }
        public static List<TruthTable> ReadTruthTableFromMem(string dataPath)
        {
            var inputList = new List<TruthTable>();
            var fs = new FileStream(dataPath, FileMode.Open);
            var mem = new FileStream(STORAGE, FileMode.Open);
            var sr = new StreamReader(fs);
            var memsr = new StreamReader(mem);
            var header = sr.ReadLine();
            var memory = memsr.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Detected crash. Reading from last value in memory: {memory}."+
                "\nAlso reprinting the variables for you.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Header: " + header + "\n"); //header with variables
            string data;

            mem.Close();
            memsr.Close();
            var stringFound = 0;
            while ((data = sr.ReadLine()) != null)
            {
                if (data == memory)
                {
                    stringFound++;
                }

                if (stringFound > 0)
                {
                    var inputRow = new TruthTable();

                    var dataElements = data.Split(','); // 0,1,0,1  will be split into arrays
                    if (dataElements.Length == 3)
                    {
                        inputRow.A = Utility.ConvertToBoolean(dataElements[0]);
                        inputRow.D = Utility.ConvertToBoolean(dataElements[1]);
                        inputRow.L = Utility.ConvertToBoolean(dataElements[2]);
                    }
                    else if (dataElements.Length == 4)
                    {
                        inputRow.A = Utility.ConvertToBoolean(dataElements[0]);
                        inputRow.D = Utility.ConvertToBoolean(dataElements[1]);
                        inputRow.X = Utility.ConvertToBoolean(dataElements[2]);
                        inputRow.L = Utility.ConvertToBoolean(dataElements[3]);
                    }
                    else
                    {
                        Console.WriteLine("This program isn't suited for the amount of elements in the given data. " +
                            "\n Please try again with a 2:1 or 3:1 multiplexer. Exiting now.");
                    }

                    SaveTruthTableData(dataElements.Length, inputRow);
                    inputList.Add(inputRow);
                }
            }
            sr.Close();
            fs.Close();
            return inputList;
        }

    }
}
