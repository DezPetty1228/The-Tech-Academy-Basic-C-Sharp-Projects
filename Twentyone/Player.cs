using System;
using System.Collections.Generic;
using System.Text;

namespace Twentyone
{
    public class Player
    {   // different properties of object player
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Nme { get; set; }
        public bool IsActivelyPlaying { get; set; }
    }
}
