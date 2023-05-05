using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Twentyone // all functions should be within the same NAmespace
{
    public class Deck // Classs Deck is the basic model of an object
    {       // deck is a collection of cards within a list
        public Deck() // The design for the object
        {  // Deck is the method name
            Cards = new List<Card>(); // instantiates empty list called Cards with "Card" as an accesible Object
  
            
            for (int i = 0; i < 4; i++) // for each face possibility loop through the possible faces
            {
                for (int j = 0; j < 13; j++) // For each suit and face combination possibility
                {
                    Card card = new Card(); // create a new object called card
                    card.Suit = (Suit)i; // give each card object a suit
                    card.Face = (Face)j; // gives each card object a face
                    Cards.Add(card); // add each card to the list Cards
                }
            }
        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)
        {
            for(int i =0; i < times; i++ )
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
            }
        }
    }
}
