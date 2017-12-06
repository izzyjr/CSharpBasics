using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_for_While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (var i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //var i = 0;
            //while (i <= 10)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);

            //        i++;
            //    }
            //}

            while (true)
            {
                Console.WriteLine("Type your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }

                break;
            }
        }
    }
}
