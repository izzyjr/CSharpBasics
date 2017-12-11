using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_for_String2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Israel Mesa ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);

            Console.WriteLine("firstName: " + firstName);
            Console.WriteLine("lastName: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("firstName: " + names[0]);
            Console.WriteLine("lastName: " + names[1]);

            Console.WriteLine(fullName.Replace("Israel", "Saboru"));
            Console.WriteLine(fullName.Replace("s", "z"));

            if (String.IsNullOrEmpty(" ".Trim()))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }


            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 25.95f;
            var currency = price.ToString("C");
            Console.WriteLine(currency);
            Console.WriteLine(price.ToString("C0"));
            Console.WriteLine(price.ToString("C1"));
        }
    }
}
