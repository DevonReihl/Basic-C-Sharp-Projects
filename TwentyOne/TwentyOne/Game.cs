using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game // basic another word
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play();

        public virtual void ListPlayers() // virtual means method inherited by other class but can be overwritten
        {
            foreach( string player in Players)
            {
                Console.WriteLine(player);
            }

        }


    }
}
