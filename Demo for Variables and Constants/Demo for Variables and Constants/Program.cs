using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_for_Variables_and_Constants
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 2; // var can be used instead of the data type
            int count = 10;
            float price = 21.50f;
            char character = 'A';
            string name = "Israel";
            bool isWorking = true;
            const float pi = 3.14f;
            pi = 1; // This will not work\

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(price);
            Console.WriteLine(character);
            Console.WriteLine(name);
            Console.WriteLine(isWorking);

            Console.WriteLine("{0} to {1}", byte.MinValue, byte.MaxValue); // format string


        }
    }
}
