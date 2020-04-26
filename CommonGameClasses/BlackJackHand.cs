using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonGameClasses
{
    public class BlackJackHand: Hand
    {

        const int handsize = 5;
        

        public BlackJackHand() 
        {
            Size = handsize;    
        }

        // return the sum of cards in the blackjack hand
        public int getSumOfCards()
        {
            int sum = 0;
            int numOfAces = 0;

            
            for (int i = 0; i < this.CardCount; i++)
            {
                sum += cards[i].NumberValue;
                
                if (cards[i].FaceValue.Equals("Ace"))
                {
                    numOfAces++;
                }
            }

            while (sum > 21 && numOfAces > 0)
            {
                sum -= 10;
                numOfAces--;
            }

            return sum;
        }

        //compare two player hands
        public int compareFaceValue(Hand hand)
        {
            BlackJackHand otherHand = hand as BlackJackHand;
            if (hand != null)
            {
                return this.getSumOfCards().CompareTo(otherHand.getSumOfCards());
               
            }
            return 0;
        }

        public bool isBusted()
        {
            int sum = getSumOfCards();
            if (sum > 21)
            {
                return true;
            }
            else return false;
        }

        public bool hasBlackJack()
        {
            int sum = getSumOfCards();
            if (sum == 21)
            {
                return true;
            }
            else return false;

        }

        public bool isTied(BlackJackHand otherHand)
        {
            int sum = getSumOfCards();

            if (sum == otherHand.getSumOfCards())
            {
                return true;
            }
            else return false;
        }    
       
    }
}
