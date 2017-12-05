using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_for_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Israel";
            var lastName = "Mesa";

            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("{0} {1}", firstName, lastName);
            Console.WriteLine(myFullName);

            var names = new string[3] { "Juan", "Jose", "Maria" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            var text = @"Hi Juan
                        Look into the following paths
                        c:\folder1\folder2
                        c:\folder3\folder4";
            Console.WriteLine(text);
        }
    }
}
