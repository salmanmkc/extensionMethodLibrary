using System;
using System.Collections.Generic;
using System.Linq;
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

        public static int WordCount(this string sentence)
        {
            return sentence.Split(new char[] { ' ', '.', '?'}, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string ShortestWord(this string sentence)
        {
            string[] stringOfWords = sentence.Split(' ');
            var sortByLength = stringOfWords.OrderBy(s => s.Length);
            var shortest = sortByLength.FirstOrDefault();
            return shortest;

        }
    }
}
