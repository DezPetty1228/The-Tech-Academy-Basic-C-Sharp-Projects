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
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" }; //creates list of strings that includes the 4 Suites
            List<string> Faces = new List<string>() // creates list with faces
            { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight",
                "Nine", "Ten", "Jack", "Queen", "King", "Ace"
                // Within each one Card it has both a face and a Suit as defined in the "Card" Class
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
