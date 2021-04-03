using System;

namespace BaseConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any Number:");
            int number = Int32.Parse(Console.ReadLine());
            string convertFinal = Convert.ToString(number, 8);
            Console.WriteLine(convertFinal);
        }
    }
}
