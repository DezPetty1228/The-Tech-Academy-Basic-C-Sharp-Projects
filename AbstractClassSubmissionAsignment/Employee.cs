﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassSubmissionAsignment
{
    class Employee : Person
    {   //Create another class called Employee and have it inherit from the Person class.

        public void SayName()
        { // Implement the SayName() method inside of the Employee class.

            Console.WriteLine("Name: " + FirstName + LastName);
        }
    }
}
