using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCircuits
{
    class Function
    {
        public static bool ConvertToBool(int num) => num == 1 ? true : false;

        public static bool ConvertToBool(string num) => num == "1" ? true : false;

        public static int ConvertToBinary(bool value) => value ? 1 : 0;
    }
}
