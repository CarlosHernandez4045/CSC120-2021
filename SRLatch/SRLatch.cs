using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SRLatch
{
    class SRLatch
    {
        //use NOR gates, simulate SR Latch pulse, memory storage and other function

        const string Output = "Output.txt";

        //properties, Q and Qbar have a default setting of false.
        private static bool S { get; set; }
        private static bool R { get; set; }
        private static bool Q { get; set; } = false;

        private static bool Qbar { get; set; } = false;


        //Simulates NORGate
        private static bool NORGate(bool val, bool val2)
        {
            bool NOR = val | val2;

            return !NOR;
        }
        //simulates the pulsing that the guy showed in the video, unused but thought it might be cool to add.
        public static void ResetPulse()
        {
            Q = false;
            R = true;
        }
        public static void SetPulse()
        {
            Q = true;
            R = false;
        }
        //wipes or creates the output file
        private static void WipeOutputFile()
        {
            var fs = new FileStream(Output, FileMode.Create);
            var sw = new StreamWriter(fs);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        //takes inputs, then simulates the SR Latch, printing it to console and output file.
        public static void Simulate()
        {
            WipeOutputFile();
            Input.WriteSRInputs();
            var inputs = Input.GetInputList();

            var fs = new FileStream(Output, FileMode.Append);
            var sw = new StreamWriter(fs);

            //for every input, we evaluate.
            foreach (var item in inputs)
            {
                var dataElements = item.Split(',');
                S = (dataElements[0] == "1") ? true : false;
                R = (dataElements[1] == "1") ? true : false;
                string inputsBefore = $"Inputs Before Turning On: S = {Convert.toBinary(S)} R = {Convert.toBinary(R)} Q =" +
                    $" {Convert.toBinary(Q)} Qbar = {Convert.toBinary(Qbar)}";

                Console.WriteLine(inputsBefore);
                sw.WriteLine(inputsBefore);

                Q = NORGate(Qbar, R);
                Qbar = NORGate(Q, S);

                string inputsAfter = $"Inputs After Turning On: S = {Convert.toBinary(S)} R = {Convert.toBinary(R)} Q =" +
                    $" {Convert.toBinary(Q)} Qbar = {Convert.toBinary(Qbar)}";

                Console.WriteLine(inputsAfter + "\n");
                sw.WriteLine(inputsAfter);
            }
            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}
