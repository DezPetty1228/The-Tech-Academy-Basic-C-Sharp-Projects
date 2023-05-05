using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
namespace Twentyone
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }

        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(Deck.Cards.First());
            using (StreamWriter file = new StreamWriter(@"C:\Users\Dezden\Desktop\Logs\Logs.txt", true))    // logs cards to text file in logs
            {
                file.WriteLine(card); // dictates what is being logged
            }
                Deck.Cards.RemoveAt(0);
        }
    }
}
