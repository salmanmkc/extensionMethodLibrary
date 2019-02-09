﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                char selected = choice[0];


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
                    case 'Q':
                        Console.WriteLine("Thank you for using my application");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Enter a valid option");
                        break;

                }

                //leave a line after each run
                Console.WriteLine();
            }
            //stop from automatically closing
            Console.ReadLine();

        }

        private static void DisplayMenu()
        {
            Console.WriteLine("(1) Convert a string to Long");
            Console.WriteLine("(2) Count the number of words in a string");
        }
    }


}
