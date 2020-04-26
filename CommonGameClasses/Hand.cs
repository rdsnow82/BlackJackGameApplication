using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonGameClasses
{
    public class Hand
    {
        protected List<Card> cards;
        private int size;
       

        public Hand()
        {
            cards = new List<Card>(size);
        }

     
        public int Size
        {
            get { return size; }
            set
            {
                size = value;
            }
        }

        public List<Card> Cards
        {
            get
            {
                return cards;
            }
            
        }
       

        public void addCard(Card c)
        {
            cards.Add(c); 
        }

         public void addCard(Card c, Boolean faceUp)
        {
            cards.Add(c);
            c.Faceup = faceUp;
        }


        public int CardCount
        {
            get
            {
                return cards.Count;
            }
        }

        public void clear()
        {
            cards.Clear();
        }

        // get the next (top) card in deck
        public Card getNextCard(int index)
        {
            Card nextCardInHand = cards.ElementAt<Card>(index);
            nextCardInHand.Faceup = true;
            return nextCardInHand;
        }

        public bool isEmpty()
        {
            return cards.Count == 0;
        }

        public void print(string playerName)
        {
            Console.WriteLine("***********************");
            Console.WriteLine("Hand for {0}", playerName);
            for (int i = 0; i < this.CardCount; i++)
            {
                Console.WriteLine("{0} card {1} - {2} of {3}", playerName, i, this.getNextCard(i).FaceValue, this.getNextCard(i).Suite, this.getNextCard(i).Faceup);
            }
        }
        
    }
}
