using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartB
{
    class PartBProgram
    {
        public static void Main(string[] args)
        {
            var inputs = new List<TheoremInputs>();
            inputs.Add(new TheoremInputs { X = false, Y = false });
            inputs.Add(new TheoremInputs { X = false, Y = true });
            inputs.Add(new TheoremInputs { X = true, Y = false });
            inputs.Add(new TheoremInputs { X = true, Y = true });

            Console.WriteLine("DeMorgan's Theorem");
            Console.WriteLine("_____   _   _     _____   _   _");
            Console.WriteLine("X + Y = X * Y  ,  X * Y = X + Y");
            Console.WriteLine("               _____   _   _   _   _   _   _   _____");
            Console.WriteLine("X  Y | X + Y | X + Y | X | Y | X * Y | X + Y | X * Y");
            Console.WriteLine("----------------------------------------------------");
            
            foreach (var set in inputs)
            {
                var theoremInputs = new DeMorgansTheorem();
                theoremInputs.SetInputX = set.X;
                theoremInputs.SetInputY = set.Y;

                string x = set.X ? "1" : "0";
                string y = set.Y ? "1" : "0";
                string or = theoremInputs.Or() ? "1" : "0";
                string orThenNot = theoremInputs.OrThenNot() ? "1" : "0";
                string notX = theoremInputs.NotX() ? "1" : "0";
                string notY = theoremInputs.NotY() ? "1" : "0";
                string notThenAnd = theoremInputs.NotThenAnd() ? "1" : "0";
                string notThenOr = theoremInputs.NotThenOr() ? "1" : "0";
                string andThenNot = theoremInputs.AndThenNot() ? "1" : "0";

                Console.WriteLine($"{x}  {y} |   {or}   |   {orThenNot}   | {notX} | {notY} |   {notThenAnd}   |   {notThenOr}   |   {andThenNot}  ");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(true);
        }
    }
}
