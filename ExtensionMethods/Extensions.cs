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

        public static string LongestWord(this string sentence, int value) //overload method
        {
            string[] stringOfWords = sentence.Split(' ');
            var sortByLength = (stringOfWords.OrderByDescending(s => s.Length)).ToArray();

            Console.WriteLine("Do you want to see the words ordered from largest to smallest? Y or N");
            string input = Console.ReadLine();
            if(input.ToUpper().Equals("Y"))
            {
                foreach (var word in sortByLength)
                {
                    Console.Write($"{word} ");
                }
                Console.WriteLine();
            }

            return sortByLength[value];
        }

        public static string ShortestWord(this string sentence, int value) //overload method
        {
            string[] stringOfWords = sentence.Split(' ');
            var sortByLength = (stringOfWords.OrderBy(s => s.Length)).ToArray();
            Console.WriteLine("Do you want to see the words ordered from smallest to largest? Y or N");
            string input = Console.ReadLine();
            if (input.ToUpper().Equals("Y"))
            {
                foreach (var word in sortByLength)
                {
                    Console.Write($"{word} ");
                }
                Console.WriteLine();
            }
            return sortByLength[value];
        }

        public static string ReadableNumberSelection(this int input)
        {
            string selection = input.ToString();

            //exceptions to the switch selection case are numbers ending in 11, 12 and 13
            if(selection.Length > 1)
            {
                if (selection.Substring(selection.Length -2).Equals("11") || selection.Substring(selection.Length - 2).Equals("12") || selection.Substring(selection.Length - 2).Equals("13"))
                {
                    return selection + "th";
                }
            }
           
            char lastNumberInSelectoin = selection[selection.Length - 1];
            switch (lastNumberInSelectoin) {
                case '1':
                    return selection + "st";
                case '2':
                    return selection + "nd";
                case '3':
                    return selection + "rd";
                default:
                    return selection + "th";
            }

        }
    }
}
