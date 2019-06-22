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


            //Player<Card> player = new Player<Card>(); generic
            // player.Hand = new List<Card>(); generic

            

            Deck deck = new Deck();
            deck.Shuffle(3);

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
