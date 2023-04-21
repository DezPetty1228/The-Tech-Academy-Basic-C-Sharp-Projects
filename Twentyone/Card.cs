using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Twentyone
{
    public class Card  // Design of object is the class 
    {
        public Card()
        {   // Default Constructor
            Suit = "spades";
            Face = "Two";
        }
        // The Card clas has a property of data type string called Suite
        public string Suit { get; set; } // you can Get and Or Set the property
        
        // The Card clas has a property of data type string called Face
        public string Face { get; set; } // you can Get and Or Set the property
    }
}
