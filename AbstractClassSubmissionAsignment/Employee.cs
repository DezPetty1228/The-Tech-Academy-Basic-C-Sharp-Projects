using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassSubmissionAsignment
{
    class Employee : Person, IQuittable
    {   //Create another class called Employee and have it inherit from the Person class.

        public int ID { get; set; }
      
        public static bool operator== (Employee employee, Employee employee1)
        {
            return employee.ID == employee1.ID;
            // returns a boolean 
        }
        public static bool operator!= (Employee employee, Employee employee1)
        {
            return employee.ID != employee1.ID;
            // returns boolean if empoyee 1 and empoyee jave the same ID
        }



        public  void Quit()
        {   
            Console.WriteLine(" Employee quit");
        }  // implement the quittable()
        public override void SayName()
        { // Implement the SayName() method inside of the Employee class.

            Console.WriteLine("Name: " + FirstName + LastName);
     
        }
    }
}
