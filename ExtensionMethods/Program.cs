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
       // static Queue<string> menuTasks = new Queue<String>();

        
        static void Main(string[] args)
        {
            bool running = true;
            List<string> menuTasks = new List<string>();
            addTaskToList(menuTasks);
            while (running)
            {
                Console.WriteLine("Choose an extension method to try");
                // call method to display the menu to the user, they can choose what they want
                DisplayMenu();
                DisplayMenUQueue();
                string choice = Console.ReadLine();
                string choiceUpper = choice.ToUpper();


                switch (choiceUpper)
                {
                    case "1":
                        Console.WriteLine("Enter a string");
                        string input = Console.ReadLine();

                        //test ToLong, it will round since Long truncates with tryparse64
                        long value = input.ToLong();
                        Console.WriteLine(value);
                        break;
                    case "2":
                        Console.WriteLine("Enter a string");
                        string input2 = Console.ReadLine()
                        Console.WriteLine($"The number of words in the string is: {input2.WordCount()}");
                        break;
                    case "3":
                        Console.WriteLine("Enter a string");
                        string input3 = Console.ReadLine();
                        Console.WriteLine($"The shortest word in the string is: {input3.ShortestWord()}");
                        break;
                    case "4":
                        Console.WriteLine("Enter a string");
                        string input4 = Console.ReadLine();
                        Console.WriteLine($"The longest word in the string is: {input4.LongestWord()}");
                        break;
                    case "5":
                        Console.WriteLine("Enter a string");
                        string input5 = Console.ReadLine();
                        Console.WriteLine("What word do you want, the 2nd largest, 3rd? Enter a index, 1 being the largest");
                        int input6 = 0;
                        int.TryParse(Console.ReadLine(), out input6);
                        Console.WriteLine($"The {input6.ReadableNumberSelection()} shortest word in the string is: {input5.ShortestWord(input6 - 1)}");
                        break;
                    case "6":
                        Console.WriteLine("Enter a string");
                        string input7 = Console.ReadLine();
                        Console.WriteLine("What word do you want, the 2nd largest, 3rd? Enter a index, 1 being the largest");
                        int input8 = 0;
                        int.TryParse(Console.ReadLine(), out input8);
                        Console.WriteLine($"The {input8.ReadableNumberSelection()} longest word in the string is: {input7.LongestWord(input8 - 1)}");
                        break;
                    case "7":
                        Console.WriteLine("Enter a number");
                        string input9 = Console.ReadLine();
                        Console.WriteLine($"The number is {input9.ToInt()}");
                        break;
                    case "8":
                        Console.WriteLine("Enter a number spelled out: ");
                        string input10 = Console.ReadLine();
                        Console.WriteLine($"The number {input10} is now an int {input10.ConvertTextToNumber()}.");
                        break;
                    case "9":
                        DateTime dateTime = DateTime.Now;
                        Console.WriteLine($"The day in setence format is {dateTime.OutputDayAsSetenceFomat()}");
                        break;
                    case "10":
                        Console.WriteLine("What is the string you want to search?");
                        string stringToSearch = Console.ReadLine();
                        Console.WriteLine("What are you searching for in the string?");
                        string x = Console.ReadLine();
                        Console.WriteLine($"The string contains {stringToSearch} {stringToSearch.InStringCount(x)} times.");
                        break;
                    case "11":
                        Console.WriteLine("Enter a string to be converted to char");
                        string stringToBeConverted = Console.ReadLine();
                        Console.WriteLine($"The char is: {stringToBeConverted.ToChar()}");
                        break;
                    case "12": //this method I use two extension methods in one, the extension method to convert from string to char and then to int
                        Console.WriteLine("Enter a char to be converted to int");
                        string stringToBeConverted2 = Console.ReadLine();
                        Console.WriteLine($"The string was converted to a char to an int: {stringToBeConverted2.ToChar().charToInt()}");
                        break;
                    case "13": 
                        Console.WriteLine("Enter a paragraph to be converted to sentence case");
                        string paragraph = Console.ReadLine();
                        Console.WriteLine($"Your new and corrected sentence: \n{paragraph.toSentenceCase()}"); 
                        break;
                    case "14":
                        Console.WriteLine("Enter a paragraph to be converted to sentence case");
                        string fullName = Console.ReadLine();
                        Console.WriteLine($"Your name in proper format: \n{fullName.toNameCase()}");
                        break;
                    case "15": 
                        Console.WriteLine("Enter the file path");
                        string path = Console.ReadLine();
                        string correctPath = @path;
                        correctPath.LargestFile();
                        break;
                    case "16":
                        Console.WriteLine("Enter the file path");
                        string path2 = Console.ReadLine();
                        string correctPath2 = @path2;
                        Console.WriteLine("How many of the largest files do you want? ");
                        int amount = Console.ReadLine().ToChar().charToInt();
                        amount.GetType();
                        correctPath2.LargestFile(amount);
                        break;
                    case "Q":
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

                Console.WriteLine("Press any key to run another program...");
                Console.ReadKey();
            }
     

        }

        private static void DisplayMenUQueue()
        {
            menuTasks.ToArray();
            for(int i = 0; x > menuTasks.Count(); i++)
                Console.WriteLine($"({i}) {menuTasks[i]}");
        }

        private static void DisplayMenu()
        {

            Console.WriteLine("(1) Convert a string to Long");
            //Console.WriteLine("(2) Count the number of words in a string");
            //Console.WriteLine("(3) Find the shortest word in a string");
            //Console.WriteLine("(4) Find the longest word in a string");
            //Console.WriteLine("(5) Find the x shortest word in a string");
            //Console.WriteLine("(6) Find the x longest word in a string");
            //Console.WriteLine("(7) Convert a string to int, if not a valid parse then it gives 0");
            //Console.WriteLine("(8) Convert a word number to a numeric int");
            //Console.WriteLine("(9) Get the day in sentence format");
            //Console.WriteLine("(10) Count how many times the string is in another string");
            //Console.WriteLine("(11) Get the first char in string, making it a char");
            //Console.WriteLine("(12) Convert a char to int");
            //Console.WriteLine("(13) Convert a paragraph into sentence case");
            //Console.WriteLine("(14) Convert name to 'sentence case'");
            //Console.WriteLine("(15) Find the biggest file in a direcory");
            //Console.WriteLine("(16) Find the x biggest files in a direcory");
            //Console.WriteLine("(17) Convert a number to double");
            //Console.WriteLine("(Q) Quit the program");
        }

        

        public static void addTaskToList(List<string> menuTasks)
        {
            menuTasks.Add("Convert a string to Long");
            menuTasks.Add("Count the number of words in a string");
            menuTasks.Add("Find the shortest word in a string");
            menuTasks.Add("Find the longest word in a string");
            menuTasks.Add("Find the x shortest word in a string");
            menuTasks.Add("Find the x longest word in a string");
            menuTasks.Add("Convert a string to int, if not a valid parse then it gives 0");
            menuTasks.Add("Convert a word number to a numeric int");
            menuTasks.Add("Get the day in sentence format");
            menuTasks.Add("Count how many times the string is in another string");
            menuTasks.Add("Get the first char in string, making it a char");
            menuTasks.Add("Convert a char to int");
            menuTasks.Add("Convert a paragraph into sentence case");
            menuTasks.Add("Convert name to 'sentence case'");
            menuTasks.Add("Find the biggest file in a direcory");
            menuTasks.Add("Find the x biggest files in a direcory");
            menuTasks.Add("Convert a number to double");
            menuTasks.Add("(Q) Quit the program");


        }

        
    }


}
