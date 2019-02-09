using System;
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
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();

            //test ToLong, it will round since Long truncates with tryparse64
            long value = input.ToLong();
            Console.WriteLine(value);

            //stop from automatically closing
            Console.ReadLine();

        }

       
    }


}
