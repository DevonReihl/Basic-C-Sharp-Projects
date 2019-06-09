using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            Console.WriteLine("Have you ever had a DUI? Please enter Yes or No");
            bool qualifyDui = Console.ReadLine() == "No";
            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            Console.WriteLine("Your age is: " +age);
            Console.WriteLine("You have not had a DUI: " +qualifyDui);
            Console.WriteLine("You have had " +tickets+ " speeding tickets.");
            bool qualifyAge = Convert.ToInt32(age) > 15;
            bool qualifyTickets = Convert.ToInt32(tickets) <= 3;
            Console.WriteLine("Does applicant qualify?");
            Console.WriteLine(qualifyAge && qualifyDui && qualifyTickets);
            Console.ReadLine();
        }
    }
}
