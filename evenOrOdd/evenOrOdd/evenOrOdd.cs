using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenOrOdd
{
    class evenOrOdd
    {
        public void calculateEvenOrOdd(int num)
        {
            int results = num / 2;
            int results2 = num % 2;

            if (results2 == 0)
            {
                //==========================================
                //Evaluates input for even and give examples
                //==========================================
                Console.WriteLine("Your number divided by two is: " + results);
                Console.WriteLine("You entered an even number.");

                void evenExamples(out string message, out int num1, out int num2, out int num3, out int num4)
                {

                    message = "Like:";
                    num1 = 2;
                    num2 = 4;
                    num3 = 6;
                    num4 = 8;
                }
                string argMessage;
                int argNumber;
                int argNumber1;
                int argNumber2;
                int argNumber3;


                evenExamples(out argMessage, out argNumber, out argNumber1, out argNumber2, out argNumber3);

                Console.WriteLine(argMessage);
                Console.WriteLine(argNumber);
                Console.WriteLine(argNumber1);
                Console.WriteLine(argNumber2);
                Console.WriteLine(argNumber3);

            }
            else
            //==========================================
            // Evaluates for odd and give examples
            //==========================================
            {
                Console.WriteLine("Your number divided by two is: " + results);
                Console.WriteLine("You entered an odd number.");
                void oddExamples(out string message, out int oddNum, out int oddNum1, out int oddNum2, out int oddNum3)
                {

                    message = "Like:";
                    oddNum = 1;
                    oddNum1 = 3;
                    oddNum2 = 5;
                    oddNum3 = 7;
                }
                string argMessage;
                int argNumber;
                int argNumber1;
                int argNumber2;
                int argNumber3;


                oddExamples(out argMessage, out argNumber, out argNumber1, out argNumber2, out argNumber3);

                Console.WriteLine(argMessage);
                Console.WriteLine(argNumber);
                Console.WriteLine(argNumber1);
                Console.WriteLine(argNumber2);
                Console.WriteLine(argNumber3);
            }
        }

    }
}
