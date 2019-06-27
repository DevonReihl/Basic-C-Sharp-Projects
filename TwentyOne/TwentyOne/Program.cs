using System;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";//Constant key word

            //Guid identifier = Guid.NewGuid();

            Console.WriteLine("Welcome to the {0}. Let's start by giving me your name.", casinoName);
            string playerName = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("Hi, {0} and how much money did you bring to play with today?", playerName);
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no cents.");
            }
            if (bank < 0)
            {
                Console.WriteLine("Please come back when you have money to spend.");
            }
            else
            {
                Console.WriteLine("Would you like to join a game of 21 right now?");
            }
            
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "ya" || answer == "yeah" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\user\Desktop\TechAcademy\C#-.net\The-Tech-Academy-Basic-C-Sharp-Projects\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException)
                    {
                        Console.WriteLine("Secrurity has been called! Get out of our casino.");
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error occurred. Please contact your System Administrator.");
                        return;
                    }
                    
                }
                game -= player;
                
                
                
            }
            Console.WriteLine("Feel free to come back and play at anytime.");
            Console.ReadLine();
        }
       
    }
}
