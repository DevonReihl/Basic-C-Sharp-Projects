using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.WriteLine("Please enter you package weight now.");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter you package height now.");
                int packageHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter you package length now.");
                int packageLength = Convert.ToInt32(Console.ReadLine());

                int packageDimensions = (packageWeight + packageLength + packageHeight);
                if (packageDimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                }
                else
                {
                    int quote = packageDimensions * packageWeight / 100;
                    Console.WriteLine("Your estimated shipping cost is $" + quote);
                    Console.ReadLine();
                }
            
            }
            Console.ReadLine();

            //Console.WriteLine("Please enter you package height now.");
            //int packageHeight = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter you package length now.");
            //int packageLength = Convert.ToInt32(Console.ReadLine());

            //int packageDimensions = (packageWeight + packageLength + packageHeight);

            //if (packageWeight > 50)
            //{
            //    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            //}
            //else if (packageDimensions > 50)
            //{
            //    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
            //}
            //else
            //{
            //    int quote = packageDimensions * packageWeight / 100;
            //    Console.WriteLine("Your estimated shipping cost is $" + quote);
            //    Console.ReadLine();
            //}
        }
    }
}

