using System;

namespace W1_Demo
{
    class Program
    {
        static void Main(string[] args) //this is an entry point, the main method gets executed first.
        {
            var qty = 112.23;
            var unitPrice = 4.90;

            var amount = Calculate((int)qty, unitPrice);
            Console.WriteLine("The amount owed = " + amount);
        }

        private static double Calculate(int qty, double unitPrice)
        {
            var finalCalc = qty * unitPrice;

            return finalCalc;

        }
    }
}
