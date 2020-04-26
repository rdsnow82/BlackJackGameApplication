using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CommonGameClasses
{
    
    public class Deck
    {
        List<Card> cards = new List<Card>();
        

        // creates a new deck of cards and shuffles them
        public void initializeDeck()
        {
            int suiteCount = Card.suite.Count<string>();
            int faceValueCount = Card.faceValue.Count<string>();
            
            cards.Clear();

            for (int i = 0; i < suiteCount; i++)
            {
                for (int j = 0; j < faceValueCount; j++)
                {
                    cards.Add(new Card(Card.suite[i], Card.faceValue[j], Card.numberValue[j], false));
                    
                }
            }
           
            shuffle();

            print();  //debugging
        }
    
        // gets the top card in the deck
        public Card drawTopCard(bool faceUp)
        {
            Card nextCard = cards[0];
            cards.RemoveAt(0);
            //nextCard.Faceup = faceUp;
            return nextCard;

        }

       
        public void shuffle()
        {
            Random rand = new Random();
            int firstCard, secondCard;

            //Swap each card in the deck with a second random card
            for (int i=0; i<cards.Count; i++)
            {
                firstCard = i;
                secondCard = rand.Next(cards.Count);

                //swap the cards
                Card card = cards[firstCard];
                cards[firstCard] = cards[secondCard];
                cards[secondCard] = card;
            }          

        }

        //
        public void print()
        {
            Console.WriteLine("******* Cards in Deck *******");
            for (int i=0; i<cards.Count; i++)
            {
                Console.WriteLine("{0} of {1}", cards[i].FaceValue, cards[i].Suite);
            }
        }

    }
}
