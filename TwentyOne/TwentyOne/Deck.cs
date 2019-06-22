using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        //=========================================
        // Properties of this class (constructor)
        //=========================================
        public Deck()
        {
            Cards = new List<Card>();
            
            for(int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }
            
        }
        //=========================================
        //Property accessors
        //=========================================
        public List<Card> Cards { get; set; }
        //=========================================
        //Methods of this class
        //=========================================

        //=========================================
        //Static vs not
        //=========================================
        //public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        //{
        //    timesShuffled = 0;
        //    for (int i = 0; i < times; i++)
        //    {
        //        timesShuffled++;
        //        List<Card> TempList = new List<Card>();
        //        Random random = new Random();

        //        while (deck.Cards.Count > 0)
        //        {
        //            int randomIndex = random.Next(0, deck.Cards.Count);
        //            TempList.Add(deck.Cards[randomIndex]);
        //            deck.Cards.RemoveAt(randomIndex);
        //        }
        //        deck.Cards = TempList;
        //    }
        //    return deck;

        //}

        public void Shuffle( int times = 1)
        {
            
            for (int i = 0; i < times; i++)
            {
               
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
                //this.Cards = TempList; // optional was to do it
            }
            //=========================================
            //no need to return anymore
            //=========================================
            //return deck;

        }
    }
}
