using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class Extensions
    {
        public static long ToLong(this string str)
        {
            long result = 0;
            double x;
            if (double.TryParse(str, out x))
            {
                result = (long)Math.Truncate(x);
            }
            return result;
        }
    }
}
