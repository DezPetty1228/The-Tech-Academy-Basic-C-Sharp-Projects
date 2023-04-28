using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassSubmissionAsignment
{
    class Employee : Person, IQuittable
    {   //Create another class called Employee and have it inherit from the Person class.

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }

        //
        public static override Employee operator ==(Employee employee, Employee employee1)
        {
            if (employee.ID == employee1.ID)
            {
                Console.WriteLine(" You cannot compare the same person");
            }
        }
        public static Person operator!= (Employee employee, Employee employee1)
        {
            if (employee.ID != employee1.ID)
            {
                Console.WriteLine("these are not the same id ");
            }
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
