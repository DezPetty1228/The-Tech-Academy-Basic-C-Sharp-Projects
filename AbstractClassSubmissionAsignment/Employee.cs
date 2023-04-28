﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassSubmissionAsignment
{
    class Employee : Person, IQuittable
    {   //Create another class called Employee and have it inherit from the Person class.

        public void Quit()
        {   
            Console.WriteLine(" Employee quit");
        }  // implement the quittable()
        public override void SayName()
        { // Implement the SayName() method inside of the Employee class.

            Console.WriteLine("Name: " + FirstName + LastName);
     
        }
    }
}