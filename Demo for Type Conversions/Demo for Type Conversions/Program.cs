using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_for_Type_Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte b = 1;
            //int i = b;
            //Console.WriteLine(i);

            //int i = 6;
            int i = 1000; 
            //byte b = i;
            byte b = (byte)i; // bits will be lost and console will print 232
            Console.WriteLine(b);
            //Cannot implicitly convert type 'int' to 'byte'. An explicit conversion exists (are you missing a cast?)

            //string number = "1234";
            //int a = Convert.ToInt32(number);
            //Console.WriteLine(a);

            try
            {
                var number = "1234";
                byte a = Convert.ToByte(number);
                Console.WriteLine(a);
            }
            catch (Exception)
            {

                Console.WriteLine("number could not be converted to a byte.");
            }

            try
            {
                string str = "true";
                bool c = Convert.ToBoolean(str);
                Console.WriteLine(c);
            }
            catch (Exception)
            {

                Console.WriteLine("number could not be converted to a byte.");
            }

        }
    }
}
