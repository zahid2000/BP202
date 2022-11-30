using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Extension_Enum
{
    internal static class Extension
    {
        public static bool CheckEmailFormat(this string format,int length) {
            if (format.Length>length)
            {
                return true;
            }
            return false;
        }
        public static int Pow(this Calc num,int pow)
        {
            int result = 1;
            for (int i = 0; i < pow; i++)
            {
                result *= 5;
            }
            return result;
        }
    }

   
}
