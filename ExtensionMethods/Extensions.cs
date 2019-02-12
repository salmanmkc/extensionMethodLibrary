using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public static int ToInt(this string value)
        {
            int result;
            if (!int.TryParse(value, out result))
            {
                result = 0;
            }
            return result;
        }

        public static double ToDouble(this string value)
        {
            double result;
            if (!double.TryParse(value, out result))
                result = 0;
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
           
            char lastNumberInSelection = selection[selection.Length - 1];
            switch (lastNumberInSelection) {
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

        public static int ConvertTextToNumber(this string textNumber)
        {
            int x = 0;
            switch (textNumber.ToLower())
            {
                case "one":
                    return 1;
                case "two":
                    return 2;
                case "three":
                    return 3;
                case "four":
                    return 4;
                case "five":
                    return 5;
                case "six":
                    return 6;
                case "seven":
                    return 7;
                case "eight":
                    return 8;
                case "nine":
                    return 9;
                default:
                    return 0;

            }

        }

        public static string OutputDayAsSetenceFomat(this DateTime dateTime)
        {
            int day = dateTime.Day;
            string dayFormatted = day.ReadableNumberSelection();
            string fullFormattedDate = dayFormatted + " of " + dateTime.NumericMonthToName() + " " + dateTime.Year;
            return fullFormattedDate;
        }

        public static string NumericMonthToName(this DateTime dateTime)
        {
            int month = dateTime.Month;
            switch (month)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 9:
                    return "August";
                case 10:
                    return "September";
                case 11:
                    return "November";
                case 12:
                    return "December";
                default:
                    return null;
            }
        }

        public static int InStringCount(this string input, string checkIfIntString)
        {
            return Regex.Matches(checkIfIntString, input).Count;
        }
        
        public static char ToChar(this string input)
        {
            char charNow = input[0];
            return charNow;
        }

        public static int charToInt(this char input)
        {
            int x;
            if(!int.TryParse(input.ToString(), out x))
            {
                x = 0;
            }
            return x;
        }


        //both of the extension methods below are similar, I use string builders, regular expressions, and I switch between for loop/foreach loop


        //here I demonsrate using the for loop
        public static string toSentenceCase(this string input)
        {
            //split sentence using regular expressions
            string[] stringOfSentences = Regex.Split(input, @"(?<=[\.!\?])\s+");
            //make a list to add each sentence to
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i<stringOfSentences.Length; i++)
            {
                //add each sentence to the string builder, making the first letter in each a capital letter and leaving a space at the end
                sb.Append(stringOfSentences[i].Substring(0, 1).ToUpper() + stringOfSentences[i].Substring(1) + ' ');
            }
            return sb.ToString();
        }

        //here I demonstrate using the foreach loop
        public static string toNameCase(this string fullName)
        {
            string[] names = Regex.Split(fullName, " ");
            StringBuilder sb = new StringBuilder();
            foreach(string name in names)
            {
                sb.Append(name.Substring(0, 1).ToUpper() + name.Substring(1) + ' ');
            }
            return sb.ToString();
        }

        public static void LargestFile(this string path, int top=1)
        {
            var query = from file in new DirectoryInfo(path).GetFiles()
                        orderby file.Length descending
                        select file;
            foreach(var file in query.Take(top))
            {
                Console.WriteLine($"File: {file.Name, -20} | {file.Length,15:N0} bits");
            }
           
        }

        public static int addAllNumbersInArray(this List<int> inputarray)
        {
            int total = 0;
            foreach (int number in inputarray)
            {
                total += number;
            }
            return total;
        }

        public static int multiplyAllNumbersInArray(this List<int> inputarray)
        {
            int total = 0;
            int run = 0;
            foreach (int number in inputarray)
            {
                if (run != 0) total *= number;
                else total += number;
                run++;
            }
            return total;
        }

        public static double doubleDivide(this double var, double var2)
        {
            return var / var2;
        }

        public static int intDivide(this int var, int var2)
        {
            return var / var2;
        }


        public static long longDivide(this long var, long var2)
        {
            return var / var2;
        }


    }

}
