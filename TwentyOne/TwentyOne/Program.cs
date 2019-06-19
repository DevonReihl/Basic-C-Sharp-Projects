using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //=================================
            //Instantiate class and call method
            //=================================

            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jesse", "Bill", "Mary" };
            //game.ListPlayers();
            //Console.ReadLine();
           


            Deck deck = new Deck();

            deck.Shuffle();

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            //Console.WriteLine("Times shuffled: {0} times", timesShuffled); //{0}, var easy way to pass variable into string
            Console.ReadLine();
        }



       
    }
}
