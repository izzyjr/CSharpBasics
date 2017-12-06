using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_for_Conditional_Statements_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch(season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's Autumn");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's Summer");
                    break;
                case Season.Spring:
                    Console.WriteLine("It's Spring");
                    break;
                case Season.Winter:
                    Console.WriteLine("It's Winter");
                    break;
                default:
                    Console.WriteLine("Huh? What are you talking about?");
                    break;
            }

        }
    }
}
