using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variableTypeMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 12;
            decimal num2 = 12;
            string num3 = "12";

            variableTypes multiply = new variableTypes();
            Console.WriteLine("The integer times 10 is: " + multiply.mathOp(num));
            Console.ReadLine();

            variableTypes divide = new variableTypes();
            Console.WriteLine("the decimal number divide by 2 is: " + divide.mathOp(num2));
            Console.ReadLine();

            variableTypes addition = new variableTypes();
            Console.WriteLine("Adding  100 to your string equals: " + addition.mathOp(num3));
            Console.ReadLine();
        }
    }
}
