using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteFruit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you guess my favorite fruit?");
            string fruit = Console.ReadLine();
            bool favFruit = fruit =="kiwi";

            while (!favFruit);
            {
                switch (fruit)
                {
                    case "apple":
                        Console.WriteLine("Apples are great with peanut butter, but not my favorite fruit.");
                        Console.Write("Please guess again?");
                        break;

                    case "pear":
                        Console.WriteLine("I dont really like pears.");
                        Console.Write("Please guess again?");
                        break;

                    case "strawberry":
                        Console.WriteLine("Strawberries are my favorite berry but not my favorite fruit.");
                        Console.Write("Please guess again?");
                        break;

                    case "kiwi":
                        Console.WriteLine("Kiwi is my favorite fruit!");
                        break;

                    default:
                        Console.WriteLine("Try again");
                        break;
                }
            }            

            Console.ReadLine();
        }
    }
}
