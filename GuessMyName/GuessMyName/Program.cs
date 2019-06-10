using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you guess my name?");
            string name = Console.ReadLine();
            bool nameGuess = name == "Rumpelstiltskin";

            do
            {
                switch (name)
                {
                    case "Steve":
                        Console.WriteLine("Steve is not my name, try again.");
                        name = Console.ReadLine();
                        break;

                    case "Michele":
                        Console.WriteLine("Michele is not my name, try again.");
                        name = Console.ReadLine();
                        break;

                    case "Rumpelstiltskin":
                        Console.WriteLine("That is my name how did you guess?");
                        nameGuess = true;
                        break;

                    default:
                        Console.WriteLine("Guess again");
                        name = Console.ReadLine();
                        break;
                }
            }
            while (!nameGuess);
            Console.ReadLine();
        }


    }
}
