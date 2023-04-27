using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassSubmissionAsignment
{   // Create an abstract class called Person with two properties: string firstName and string lastName.

    abstract class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }


        public abstract void SayName();   // Give this class a void method called SayName() ”.
        
            
    }
}
