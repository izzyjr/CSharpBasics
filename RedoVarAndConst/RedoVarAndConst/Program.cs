using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedoVarAndConst
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = 1;
            const float pi = 3.14f; //const, data type, identifier

            //C# is case sensitive;
            //You can't use variable unless you initialize
            //Identifiers: can't start with a number, no whitespace, no key word, and always use meaningful names
            //Use camel case, but use pascal case for const variables
            //Double is the default data type used in the C# compiler therefore:

            float number = 1.2f; //add suffix f
            decimal otherNumber = 1.2m; //add suffix m
        }
    }
    }
}
