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

            Deck deck = new Deck();

            //int counter = 0;
            //foreach (Card card in deck.Cards)
            //{
            //    if (card.Face == Face.Ace)
            //    {
            //        counter++;
            //    }
            //}  // in efficient but example

            int count = deck.Cards.Count(x => x.Face == Face.Ace); //Lambda function => means "where"

            Console.WriteLine(count);

            List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();

            foreach (Card card in newList)
            {
                Console.WriteLine(card.Face);
            }

            List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };

            int sum = numberList.Where(x => x > 20).Sum();

            Console.WriteLine(sum);
            
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.WriteLine("Times shuffled: {0} times", timesShuffled); //{0}, var easy way to pass variable into string
            Console.ReadLine();
        }
       
    }
}
