using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Twentyone
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>(); // instantiates empty list called cards
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" }; //creates list
            List<string> Faces = new List<string>() // creates list with faces
            { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight",
                "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces) // for each face possibility loop through the possible faces
            {
                foreach (string suit in Suits) // For each suit and face combination possibility
                {
                    Card card = new Card(); // create a new object called card
                    card.Suit = suit; // give each card object a suit
                    card.Face = face; // gives each card object a face
                    Cards.Add(card); // add each card to the list Cards
                }
            }
        }
        public List<Card> Cards { get; set; }
    }
}
