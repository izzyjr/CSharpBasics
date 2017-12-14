using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercisese_for_Working_with_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1
            Console.WriteLine("Enter a few numbers separated by a hyphen: ");
            var input = Console.ReadLine();
            var changedInput = input.Split('-');
            var count = 0;

            for (var i = 0; i < changedInput.Length; i++)
            {
                if (i != (changedInput.Length - 1))
                {
                    if (Convert.ToInt32(changedInput[i]) < Convert.ToInt32(changedInput[i + 1]))
                    {
                        count++;
                    }
                }
            }
            if ((changedInput.Length - 1) == count)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }

            //Exercise2


        }
    }
}
