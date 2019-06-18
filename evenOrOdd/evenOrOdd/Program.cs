using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            evenOrOdd evenOrOdd = new evenOrOdd();

            Console.WriteLine("Please enter a whole number");
            int num = Convert.ToInt32(Console.ReadLine());

            evenOrOdd.calculateEvenOrOdd(num);
            Console.ReadLine();
        }
    }
}
