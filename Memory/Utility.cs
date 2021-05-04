using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    public class Utility
    {
       public static Boolean ConvertToBoolean(string data)
        {
            return (data == "1"? true: false);
        }
        public static string ConvertToBinary(bool value)
        {

            return value ? "1" : "0";

        }
        public static int ConvertToBit(Boolean data)
        {
            return Convert.ToInt16(data);
        }
    }
}
