using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //int currentTemperature = 70;
            int roomTemperature = 70;
            Console.WriteLine("Hi, what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hi " + name + ", what is the temperature outside where you are?");
            int currentTemperature = Convert.ToInt32(Console.ReadLine());

            if (currentTemperature == roomTemperature)
            {
                Console.WriteLine("It is exactly room temperature.");
            }
            else if (roomTemperature > currentTemperature)
            {
                Console.WriteLine("It is colder than room temperature");
            }
            else if (currentTemperature > roomTemperature)
            {
                Console.WriteLine("It is warmer than room temperature.");
            }
            else
            {
                Console.WriteLine("OPPS we have a problem Houston!!!");
            }

            //One line if/else statment
            //string comparisonResult = currentTemperature == roomTemperature ? "It is room temp." : "It is not room temp.";
            //Console.WriteLine(comparisonResult);
            Console.ReadLine();

        }
    }
}
