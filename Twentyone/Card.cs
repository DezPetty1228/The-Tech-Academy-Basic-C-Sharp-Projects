using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Twentyone
{
    public struct Card // Design of object is the class 
    {
        public string Suit { get; set; } // you can Get and Or Set the property -   // The Card clas has a property of data type string called Suite
        public string Face { get; set; } // you can Get and Or Set the property - //        // The Card clas has a property of data type string called Face
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

