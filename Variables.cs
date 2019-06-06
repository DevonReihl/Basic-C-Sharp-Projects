using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is how you comment
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Hello " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //Console.WriteLine("your favorite number is " + favoriteNumber);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is " +total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            char randomLetter = 'X';
            char questionMark = '\u2103';
            Console.WriteLine(questionMark);
            Console.ReadLine();

            short temperatureOnMars = -341;

            string myName = 'Devon';

            int currentAge = 42;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(raingingStatus);
            Console.ReadLine;

        }
    }
}
