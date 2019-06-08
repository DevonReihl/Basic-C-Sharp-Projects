using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1, what is your:");
            Console.WriteLine("Hourly Rate?");
            int person1Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int person1Hours = Convert.ToInt32(Console.ReadLine());
            int wages1 = person1Rate * person1Hours;

            Console.WriteLine("Person 2, what is your:");
            Console.WriteLine("Hourly Rate?");
            int person2Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int person2Hours = Convert.ToInt32(Console.ReadLine());
            int wages2 = person2Rate * person2Hours;

            Console.WriteLine("Weekly wages for person 1 is $" + wages1.ToString());
            Console.WriteLine("Weekly wages for person 2 is $" + wages2.ToString());
            bool trueFalse = wages1 > wages2;
            Console.WriteLine("Does Person 1 make more money than Person 2? ");
            Console.WriteLine(trueFalse.ToString());
            Console.ReadLine();
        }
    }
}
