using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SRLatch
{
    class Input
    {
        const string Inputs = "input.txt";
        //wipes input list
        public static void wipeInputList()
        {
            var fs = new FileStream(Inputs, FileMode.Create);
            var sw = new StreamWriter(fs);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        //writes the input file
        public static void WriteSRInputs()
        {
            wipeInputList();
            var fs = new FileStream(Inputs, FileMode.Append);
            var sw = new StreamWriter(fs);
            //Write all inputs for SR latch. Generating would take more performance, and there's only 4.
            sw.WriteLine("0,0");
            sw.WriteLine("1,0");
            sw.WriteLine("0,1");
            sw.WriteLine("1,1");

            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public static List<string> GetInputList()
        {
            var fs = new FileStream(Inputs, FileMode.Open);
            var sr = new StreamReader(fs);
            var inputList = new List<string>();

            string data;
            while((data = sr.ReadLine()) != null)
            {
                inputList.Add(data);
            }

            return inputList;
        }
    }
}
