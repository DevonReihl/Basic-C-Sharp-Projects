using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booleanOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //AND OPERATOR
            Console.WriteLine(true && true);
            Console.WriteLine(false && false);
            Console.WriteLine(true && false);
            Console.WriteLine(true && true && true);

            //OR OPERATOR
            Console.WriteLine(true || true);
            Console.WriteLine(false || false);
            Console.WriteLine(true || false);

            //EQUALS OPERATOR
            Console.WriteLine(true == true);
            Console.WriteLine(true == false);
            Console.WriteLine(false == false);

            //IS NOT OPERATOR
            Console.WriteLine(true != true);
            Console.WriteLine(true != false);
            Console.WriteLine(false != false);

            //ONE BUT NOT BOTH ARE TRUE
            Console.WriteLine(true ^ true);
            Console.WriteLine(true ^ false);
            Console.WriteLine(false ^ false);
            Console.ReadLine();
        }
    }
}
