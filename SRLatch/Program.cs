using System;

namespace SRLatch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*you can find both the input and output file in the project debug folder after a successful run!
            Simulates an SR latch and writes to console and and output file the states before and after pulsing/turning on the latch.
            Also sorry if it's sloppy, don't have much time and want to get this done now since I have stuff coming up. 
            Thanks for the great semester and all your help. - Carlos
            */
            SRLatch.Simulate();

            Console.ReadKey(true);
        }
    }
}
