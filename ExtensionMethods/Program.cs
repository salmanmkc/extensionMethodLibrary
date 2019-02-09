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
            Console.WriteLine("(Q) Quit the program");
        }
    }


}
