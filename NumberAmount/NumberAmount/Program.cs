using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAmount
{
    class Program
    {
        static void Main(string[] args)
        {
            Number value = new Number();
            value.Amount = 300000000000000000;


            Console.WriteLine("The amount is: " + value.Amount);
            Console.ReadLine();
        }
    }
}
