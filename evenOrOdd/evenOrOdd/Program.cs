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
            //int num = Convert.ToInt32(Console.ReadLine());
            string userInput = Console.ReadLine();
            
            int num=1;
            int result;
            if (int.TryParse(userInput, out result))
            {
                 num = result;
                //Console.WriteLine(evenOrOddInput.response(userInput)); not working
            }
            else
            {
                //Console.WriteLine(evenOrOddInput.response(num)); not working
            }
            

            evenOrOdd.calculateEvenOrOdd(num);
            Console.ReadLine();
        }
    }
}
