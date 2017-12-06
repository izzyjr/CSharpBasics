using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Flow_Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            if (height > width)
            {
                Console.WriteLine("Portrait");
            }
            else if (width > height)
            {
                Console.WriteLine("Landscape");
            }
        }
    }
}
