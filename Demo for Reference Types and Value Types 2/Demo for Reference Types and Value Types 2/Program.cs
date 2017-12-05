using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_for_Reference_Types_and_Value_Types_2
{
    public class person
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            var person = new person {Age = 20};
            MakeOld(person);
            Console.WriteLine(person.Age);
        }

        public static void Increment (int number)
        {
            number += 10;   
        }
        
        public static void MakeOld(person person)
        {
            person.Age += 10;
        }
    }
}
