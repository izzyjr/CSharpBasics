﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_for_Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 21;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's Morning");
            }
            else if (hour > 12 && hour < 18)
            {
                Console.WriteLine("It's Afternoon");
            }
            else
            {
                Console.WriteLine("It's Evening");
            }

            bool isGoldCustomer = true;

            //float price;
            //if (isGoldCustomer)

            //    price = 19.95f;
            //else
            //    price = 29.95f;

            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);


        }
    }
}
