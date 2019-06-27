using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var today = DateTime.Now;
                Console.WriteLine("Please tell me how old you are.");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0)
                {
                    throw new BornException();
                }
                int currentYear = today.Year;
                var yearOfBirth = currentYear - age;
                Console.WriteLine("You were born in the year {0} or " + (yearOfBirth - 1), yearOfBirth);
                Console.ReadLine();
            }
            catch (BornException)
            {
                Console.WriteLine("You have not been born yet how can you enter an age?");
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("You have made an error please restart.");
                Console.ReadLine();
            }
            
        }
    }
}
