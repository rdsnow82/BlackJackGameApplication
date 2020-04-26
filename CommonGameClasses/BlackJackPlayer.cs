using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonGameClasses
{
    public class BlackJackPlayer: Player
    {
        public const int defaultWagerAmt = 5;
        public const int MaxStartingCash = 100;
        public BlackJackHand hand;


        public BlackJackPlayer()
        {
            this.hand = new BlackJackHand();
        }
        public BlackJackPlayer(string name)
        {
            this.Name = name;
            this.hand = new BlackJackHand();
        }

    }
}
