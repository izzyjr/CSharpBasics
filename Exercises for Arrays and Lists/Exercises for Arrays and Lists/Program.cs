using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_for_Arrays_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise2

            Console.WriteLine("Enter name: ");
            var name = Console.ReadLine();
            var nameArray = name.ToCharArray();
            var length = nameArray.Length;
            var reversed = new char[length];
            Array.Reverse(nameArray);

            for (var i = 0; i < length; i++)
            {
                reversed[i] = nameArray[i];
            }
            string.Join("", reversed);
            Console.WriteLine(reversed);

            //Exercise3

            var numbers = new int[5];
            var count = 0;

            Console.WriteLine("Enter a number: ");
            var input = Convert.ToInt32(Console.ReadLine());
            numbers[count] = input;


            while (count < 4)
            {

                Console.WriteLine("Another a number: ");
                input = Convert.ToInt32(Console.ReadLine());
                foreach (var number in numbers)
                {
                    while (input == number)
                    {
                        Console.WriteLine("Error, another number please!: ");
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                }
                count++;
                numbers[count] = input;
            }

            Console.WriteLine();
            Array.Reverse(numbers);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //Exercise4

            var numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a number or Quit: ");
                var input = Console.ReadLine();

                if (input == "Quit")
                {
                    break;
                }
                else
                {
                    numbers.Add(Convert.ToInt32(input));
                }
            }

            var unique = new List<int>();
            foreach (var number in numbers)
            {
                if (!unique.Contains(number))
                {
                    unique.Add(number);
                }
            }
            foreach (var number in unique)
            {
                Console.WriteLine(number);
            }

            //Exercise5

            string[] numbers;
            while(true)
            {
                Console.WriteLine("Enter a list of numbers separated by ',': ");
                var input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    numbers = input.Split(',');
                    if (numbers.Length >= 5)
                    {
                        break;
                    }
                }
                Console.WriteLine("Invalid list!");
            }
            var numbers2 = new List<int>();
            foreach (var number in numbers)
            {
                numbers2.Add(Convert.ToInt32(number));
            }

            var smallests = new List<int>();
            while (smallests.Count < 3)
            {
                var min = numbers2[0];
                foreach (var number in numbers2)
                {
                    if (number < min)
                    {
                        min = number;
                    }
                }
                smallests.Add(min);
                numbers2.Remove(min);
            }

            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallests)
            {
                Console.WriteLine(number);
            }
                
        }
    }
}
