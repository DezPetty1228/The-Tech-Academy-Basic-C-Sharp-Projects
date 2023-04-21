using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twentyone
{
    class Program
    {
        // acces modifier = static / return type= void
        static void Main(string[] args) // function or method or routine = Main
        {
            Deck deck = new Deck();
            deck = shuffle(deck); // shuffles dexk and then returns it as Deck

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit); // lists faces and suites of each card in deck
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        // creates a method called shuffle 
        // creates a list called tempList that holds shuffled cards and returns as a new deck
        public static Deck shuffle(Deck deck)
        {
            List<Card> tempList = new List<Card>();
            Random random = new Random();

            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                tempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }
            deck.Cards = tempList;
            return deck;
        }
    }
}
