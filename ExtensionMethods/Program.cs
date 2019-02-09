using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("Choose an extension method to try");
                // call method to display the menu to the user, they can choose what they want
                DisplayMenu();
                string choice = Console.ReadLine();
                string choiceUpper = choice.ToUpper();
                char selected = choiceUpper[0];


                switch (selected)
                {
                    case '1':
                        Console.WriteLine("Enter a string");
                        string input = Console.ReadLine();

                        //test ToLong, it will round since Long truncates with tryparse64
                        long value = input.ToLong();
                        Console.WriteLine(value);
                        break;
                    case '2':
                        Console.WriteLine("Enter a string");
                        string input2 = Console.ReadLine();
                        Console.WriteLine($"The number of words in the string is: {input2.WordCount()}");
                        break;
                    case '3':
                        Console.WriteLine("Enter a string");
                        string input3 = Console.ReadLine();
                        Console.WriteLine($"The shortest word in the string is: {input3.ShortestWord()}");
                        break;
                    case '4':
                        Console.WriteLine("Enter a string");
                        string input4 = Console.ReadLine();
                        Console.WriteLine($"The longest word in the string is: {input4.LongestWord()}");
                        break;
                    case '5':
                        Console.WriteLine("Enter a string");
                        string input5 = Console.ReadLine();
                        Console.WriteLine("What word do you want, the 2nd largest, 3rd? Enter a index, 1 being the largest");
                        int input6 = 0;
                        int.TryParse(Console.ReadLine(), out input6);
                        Console.WriteLine($"The {input6.ReadableNumberSelection()} shortest word in the string is: {input5.ShortestWord(input6 - 1)}");
                        break;
                    case '6':
                        Console.WriteLine("Enter a string");
                        string input7 = Console.ReadLine();
                        Console.WriteLine("What word do you want, the 2nd largest, 3rd? Enter a index, 1 being the largest");
                        int input8 = 0;
                        int.TryParse(Console.ReadLine(), out input8);
                        Console.WriteLine($"The {input8.ReadableNumberSelection()} longest word in the string is: {input7.LongestWord(input8 - 1)}");
                        break;
                    case '7':
                        Console.WriteLine("Enter a number");
                        string input9 = Console.ReadLine();
                        Console.WriteLine($"The number is {input9.ToInt()}");
                        break;
                    case '8':
                        Console.WriteLine("Enter a number spelled out: ");
                        string input10 = Console.ReadLine();
                        Console.WriteLine($"The number {input10} is now an int {input10.ConvertTextToNumber()}.");
                        break;
                    case '9':
                        DateTime dateTime = DateTime.Now;
                        Console.WriteLine($"The day in setence format is {dateTime.OutputDayAsSetenceFomat()}");
                        break;
                    case 'Q':
                        Console.WriteLine("Thank you for using my application");
                        Console.WriteLine("Closing applicatoin in 5 seconds");
                        for (int i = 5; i > 0; i--)
                        {
                            //use string interpolation
                            Console.Write($"{i} ");
                            // put main thread to sleep for 1 second every loop
                            Thread.Sleep(1000);
                        }
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Enter a valid option");
                        break;

                }

                // leave a blank line after running a handler
                Console.WriteLine();
            }
     

        }

        private static void DisplayMenu()
        {
            Console.WriteLine("(1) Convert a string to Long");
            Console.WriteLine("(2) Count the number of words in a string");
            Console.WriteLine("(3) Find the shortest word in a string");
            Console.WriteLine("(4) Find the longest word in a string");
            Console.WriteLine("(5) Find the x shortest word in a string");
            Console.WriteLine("(6) Find the x longest word in a string");
            Console.WriteLine("(7) Convert a string to int, if not a valid parse then it gives 0");
            Console.WriteLine("(8) Convert a word number to a numeric int");
            Console.WriteLine("(9) Get the day in sentence format");
            Console.WriteLine("(Q) Quit the program");
        }
    }


}
