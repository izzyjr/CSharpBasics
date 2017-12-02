using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_for_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;
            Console.WriteLine(a + b);
            Console.WriteLine(a / b); //both are integers
            Console.WriteLine((float)a / (float)b);

            Console.WriteLine(a > b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);

            var x = 1;
            var y = 2;
            var z = 3;
            Console.WriteLine(z > x && z > y);
            Console.WriteLine(z > x && z == y);
            Console.WriteLine(z > x || z == y);

        }
    }
}
