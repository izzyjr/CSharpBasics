using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_FLow_Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Speed Limit: ");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Car Speed: ");
            int carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                int demerit = (carSpeed - speedLimit) / 5;
                if (demerit < 12)
                {
                    Console.WriteLine("Demerit Points: " + demerit);
                }
                else
                {
                    Console.WriteLine("License Suspended!");
                }
            }
        }
    }
}
