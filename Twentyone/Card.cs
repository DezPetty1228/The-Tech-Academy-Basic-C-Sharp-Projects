using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Twentyone
{
    public struct Card // Design of object is the class 
    {
        public Suit Suit { get; set; } // you can Get and Or Set the property -   // The Card clas has a property of data type string called Suite
        public Face Face { get; set; } // you can Get and Or Set the property - //        // The Card clas has a property of data type string called Face
        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
    }

    public enum Suit
    {
        Clubs, Diamonds,Hearts,Spades
    }
    public enum Face
    {
        Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace
    }
 }

