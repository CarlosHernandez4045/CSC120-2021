using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartA
{
    class Tester
    {
        public static void RawBool()
        {
            var inputs = new List<IdentityInput>();
            inputs.Add(new IdentityInput() { D = false, A = false, X = false });
            inputs.Add(new IdentityInput() { D = true, A = false, X = false });
            inputs.Add(new IdentityInput() { D = false, A = true, X = false });
            inputs.Add(new IdentityInput() { D = false, A = false, X = true });
            inputs.Add(new IdentityInput() { D = false, A = true, X = true });
            inputs.Add(new IdentityInput() { D = true, A = true, X = false });
            inputs.Add(new IdentityInput() { D = true, A = false, X = true });
            inputs.Add(new IdentityInput() { D = true, A = true, X = true });

            foreach (var set in inputs)
            {
                var identity = new Identity();
                identity.SetInputD = set.D;
                identity.SetInputA = set.A;
                identity.SetInputX = set.X;

                var output = identity.Validate();
                Console.WriteLine($" D = {identity.SetInputD}, A = {identity.SetInputA}, X = {identity.SetInputX}, Output = {output}");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(true);
        }
        public static void TruthTable()
        {
            var inputs = new List<IdentityInput>();
            inputs.Add(new IdentityInput() { D = false, A = false, X = false });
            inputs.Add(new IdentityInput() { D = true, A = false, X = false });
            inputs.Add(new IdentityInput() { D = false, A = true, X = false });
            inputs.Add(new IdentityInput() { D = false, A = false, X = true });
            inputs.Add(new IdentityInput() { D = false, A = true, X = true });
            inputs.Add(new IdentityInput() { D = true, A = true, X = false });
            inputs.Add(new IdentityInput() { D = true, A = false, X = true });
            inputs.Add(new IdentityInput() { D = true, A = true, X = true });

            Console.WriteLine("D | A | X | L");
            Console.WriteLine("-------------");

            foreach (var set in inputs)
            {
                var identity = new Identity();

                identity.SetInputD = set.D;
                identity.SetInputA = set.A;
                identity.SetInputX = set.X;

                string dBinary = set.D ? "1" : "0";
                string aBinary = set.A ? "1" : "0";
                string xBinary = set.X ? "1" : "0";
                var lBinary = identity.Validate() ? "1" : "0";
                Console.WriteLine($"{dBinary} | {aBinary} | {xBinary} | {lBinary}");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(true);
        }
    }
}
