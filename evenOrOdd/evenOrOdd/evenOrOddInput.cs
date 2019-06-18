using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenOrOdd
{
    public static class evenOrOddInput
    {
        //==========================================
        // user inputs string with numeric values
        //==========================================
        public static void response(int num)
        {
            Console.WriteLine("Thank you for entering a whole number.");
        }

        //==========================================
        // user inputs string with non numeric values
        //==========================================
        public static void response(string userInput)
        {
            Console.WriteLine("Something went wrong.");
        }
    }
}
