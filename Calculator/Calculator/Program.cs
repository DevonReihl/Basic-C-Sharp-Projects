using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for user input
            Console.WriteLine("Please give me a number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please give me another number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //Call methods
            Console.WriteLine("If we add your numbers you get: " + mathOperation.add(num1, num2));
            Console.WriteLine("If we subtrate your numbers you get: " + mathOperation.minus(num1, num2));
            Console.WriteLine("If we multiple your numbers you get: " + mathOperation.times(num1, num2));
            Console.WriteLine("If we divide your numbers you get rounded: " + mathOperation.divide(num1, num2));

            Console.ReadLine();
        }
    }
}
