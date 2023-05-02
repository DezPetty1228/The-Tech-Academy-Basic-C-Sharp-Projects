using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// A game of 21 or blackjACK
namespace Twentyone // methods must be inside the namespace
{
    public class Program 
    {
        static void Main(string[] args) // function or method or routine = Main
        {
            Card card1 = new Card();
            Card card2 = card1;
            card1.Face = Face.Eight;
            card2.Face = Face.King;
            Console.WriteLine(card1.Face);
            
            Deck deck = new Deck();
            deck.Shuffle(3);
           
            foreach (Card card in deck.Cards)
            {
            Console.WriteLine(card.Face + " of " + card.Suit); // lists faces and suites of each card in deck
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
            }
        }
   }
   