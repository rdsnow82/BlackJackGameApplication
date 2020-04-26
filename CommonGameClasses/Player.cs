using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonGameClasses
{
    public class Player
    {
        protected double buyInAmt;
        protected double winnings;
        protected double wager;
        protected int gamesWon;
        protected String name;
        
        public double BuyInAmt { get; set; }

        public double Wager { get; set; }

        public double Winnings
        {
            get;
            set;
        }

        public int GamesWon
        {
            get;
            set;
        }


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        
    
    }

    
}
