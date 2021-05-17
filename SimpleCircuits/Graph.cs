using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCircuits
{
    class Graph
    {
        private static void printSpaces()
        {
            for (int i = 0; i < 11; i++)
            {
                Console.Write(" ");
            }
        }
        private static void printLine()
        {
            for (int i = 0; i < 11; i++)
            {
                Console.Write("-");
            }
        }
        private static void topLine(bool value)
        {

        }
        private static void topLine()
        {

        }

        private static void BackBone(bool result)
        {
            Console.WriteLine("|");
            Console.WriteLine("|");
            if (result)
            {
                //start calling topLine method here
            }

            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
        }
        public static void PrintGraph(string input, bool result )
        {
            //coming back after, pass val to it, then it calls other methods to either print space or line? 
        }
    }
}
