using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_for_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1
            for (var i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //Exercise2
            var sum = 0;
            while (true)
            {
                Console.Write("Enter a number (or 'ok' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;

                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("Sum of all numbers is: " + sum);

            //Exercise3
            Console.WriteLine("Type in a number: ");
            var input = Convert.ToInt32(Console.ReadLine());

            int total = 1;
            for (var i = 1; i <= input; i++)
            {
                total = total * i;
            }
            Console.WriteLine("{0}! = {1}", input, total);

            //Exercise4
            var random = new Random();
            int ran = random.Next(1, 10);

            Console.WriteLine("Guess a number between 1 and 10: ");

            for (var i = 0; i < 4; i++)
            {
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == ran)
                {
                    Console.WriteLine("You Won!");
                    break;
                }
                else
                {
                    Console.WriteLine("Try again!: ");
                }
            }
            Console.WriteLine(ran);

            //Exercise5

            Console.WriteLine("Enter numbers separated by ',': ");
            var input = Console.ReadLine();

            var numbers = input.Split(',');
            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine("Max is: " + max);

        }
    }
}
