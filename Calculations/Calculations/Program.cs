using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me a number?");
            int product = Convert.ToInt32(Console.ReadLine()) * 50;
            Console.WriteLine("Your number multiplied by 50 is " + product.ToString());
            Thread.Sleep(1000);

            Console.WriteLine("Please give me another number?");
            int addition = Convert.ToInt32(Console.ReadLine()) + 25;
            Console.WriteLine("Your number plus 25 is " + addition.ToString());
            Thread.Sleep(1000);

            Console.WriteLine("Please give me another number?");
            double quotient = Convert.ToDouble(Console.ReadLine()) / 12.5;
            Console.WriteLine("Your divided by 12.5 is " + quotient.ToString());
            Thread.Sleep(1000);

            Console.WriteLine("Another number please?");
            bool trueFalse = Convert.ToInt32(Console.ReadLine()) > 50;
            Console.WriteLine("Is your number greater then 50? " + trueFalse.ToString());
            Thread.Sleep(1000);

            Console.WriteLine("One last number please");
            int remainder = Convert.ToInt32(Console.ReadLine()) % 7;
            Console.WriteLine("Your number divided by 7 has a remainder of " + remainder.ToString());
            Console.ReadLine();

        }
    }
}
