using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuess = number == 12;
            
            do
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again.");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 26:
                        Console.WriteLine("You guessed 26. Try again.");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 19:
                        Console.WriteLine("You guessed 19. Try again.");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 12:
                        Console.WriteLine("You guessed 12. That is correct!");
                        isGuess = true;
                        break;

                    default:
                        Console.WriteLine("Try again");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuess);
            
            Console.ReadLine();
        }
    }
}
