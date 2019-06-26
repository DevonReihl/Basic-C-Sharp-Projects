using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "here is some text.";
            //File.WriteAllText(@"C:\Users\user\Desktop\TechAcademy\C#-.net\The-Tech-Academy-Basic-C-Sharp-Projects\log.txt", text);

            //string text = File.ReadAllText(@"C:\Users\user\Desktop\TechAcademy\C#-.net\The-Tech-Academy-Basic-C-Sharp-Projects\log.txt");

            //Date time and timestamp examples
            DateTime dateTime = new DateTime(2018, 6, 26);
            DateTime yearOfBirth = new DateTime(2000, 6, 26);
            DateTime yearOfGraduation = new DateTime(2013, 5, 15);

            TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;


            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by giving me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("Hi, {0} and how much money did you bring to play with today?", playerName);
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Would you like to join a game of 21 right now?");
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "ya" || answer == "yeah" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to come back and play at anytime.");
            Console.ReadLine();
        }
       
    }
}
