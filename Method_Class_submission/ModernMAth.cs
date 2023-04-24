using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Class_submission
{
     public  class ModernMAth
    {
      public void NumberFun(int num1)
        {
            Console.WriteLine(num1 / 2); // devides num1 by 2
        }
        public void NumberFun( decimal num1, out int num2 ) // out is good when using void methods
        {       // 
            num2 = 1; // using out allows value of num2 to be accessed in void methods but value must be assigned
            Console.WriteLine(num1 / 1 );
        }

    }
}
