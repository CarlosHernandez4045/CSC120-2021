using System;

namespace BaseConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number to convert to base 8, enter 0 to exit:");
            convertToBaseEight();
        }
        static void convertToBaseEight()
        {
            while (true)
            {
                int number = Int32.Parse(Console.ReadLine());
                if (number == 0)
                {
                    break;
                }
                else if (number < 0)
                {
                    Console.WriteLine("Invalid Input, Try Again");
                }
                else
                {
                    string convertFinal = Convert.ToString(number, 8);
                    Console.WriteLine("The base 8 version is " + convertFinal);
                }
            }
        }
    }
}
