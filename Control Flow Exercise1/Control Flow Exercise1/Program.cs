using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Flow_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter number between 1 and 10: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number < 10 && number > 1)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
