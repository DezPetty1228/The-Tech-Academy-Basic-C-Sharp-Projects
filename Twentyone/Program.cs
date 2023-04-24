using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// A game of 21 or blackjACK
namespace Twentyone // methods must be inside the namespace
{
    class Program // basic models of objects are Classes 
    {
        // acces modifier = static / return type= void
        static void Main(string[] args) // function or method or routine = Main
        {
            //deck is a 
            // instantiation of an object assigned to variable  "deck" using data type and class "Deck" as model
            Deck deck = new Deck(); //deck = shuffle(deck); // shuffles deck and then returns it as Deck
            int timesShuffled = 0;
            deck = shuffle(deck, out timesShuffled, 4); // NAmed parameter is Deck:

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit); // lists faces and suites of each card in deck
            }
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times shuffled: {0}", +timesShuffled);


            Console.ReadLine();
        }

        // creates a method called shuffle 
        // creates a list called tempList that holds shuffled cards and returns as a new deck
        public static Deck shuffle(Deck deck, out int timesShuffled, int times = 1)
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                timesShuffled++;
                List<Card> tempList = new List<Card>();
                Random random = new Random();
            
            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                tempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }
            deck.Cards = tempList;
        }
            return deck;
       }

        //
        //public static Deck shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
