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
                int userInputNumber = Int32.Parse(Console.ReadLine());
                if (userInputNumber == 0) //exit the while true loop with a break if user inputs 0
                {
                    break;
                }
                else if (userInputNumber < 0)
                {
                    Console.WriteLine("Invalid Input, Try Again"); //defensive programming
                }
                else //if valid input, convert to base 8 and output to user
                {
                    string convertFinal = Convert.ToString(userInputNumber, 8);
                    Console.WriteLine("The base 8 version is " + convertFinal);
                }
            }
        }
    }
}
