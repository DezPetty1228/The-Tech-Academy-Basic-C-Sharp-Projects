using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// A game of 21 or blackjACK
namespace Twentyone // methods must be inside the namespace
{
    class Program 
    {
        static void Main(string[] args) // function or method or routine = Main
        {
            Game game = new TwentyOneGame();
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "julius";
            game = game + player;
            game = game - player;
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
   