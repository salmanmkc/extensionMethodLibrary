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

        public static string LongestWord(this string sentence)
        {
            string[] stringOfWords = sentence.Split(' ');
            var sortByLength = stringOfWords.OrderBy(s => s.Length);
            var longest = sortByLength.LastOrDefault();
            return longest;

        }

        public static string LongestWord(this string sentence, int value)
        {
            string[] stringOfWords = sentence.Split(' ');
            var sortByLength = (stringOfWords.OrderByDescending(s => s.Length)).ToArray();
            foreach (var word in stringOfWords)
            {
                Console.WriteLine(word);
            }
            return sortByLength[value];
        }

        public static string ShortestWord(this string sentence, int value)
        {
            string[] stringOfWords = sentence.Split(' ');
            var sortByLength = (stringOfWords.OrderBy(s => s.Length)).ToArray();
            return sortByLength[value];
        }
    }
}
