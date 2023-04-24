using System;
using System.Collections.Generic;
using System.Text;

namespace Twentyone
{
    // TwentyOneGame is able to inherit methods from : Game Classs
    public class TwentyOneGame : Game // : allows new classes to inherit methods from other classes. 
    {
       public void Play() // created a method callled play that will be specific to TwentyOneGame
        {
            throw new NotImplementedException(); // thows error if Play method is used without being defined first
        }

    }
}
