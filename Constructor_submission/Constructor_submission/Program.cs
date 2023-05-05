using System;

namespace Constructor_submission
{
    class Program
    {
        static void Main(string[] args)
        {
            const int century = 100; // Create a const variable.

            var Name  = 100;    //Create a variable using the keyword “var.”

        }
    }

    public class NewEmployee    //Chain two constructors together.

    {
        public string firstName;
        public string lastName;
        public NewEmployee()
        {
            Console.WriteLine("Reserving new record for the upcoming employee.");
        }
        public NewEmployee(string firstName)
        {
            this.firstName = firstName;
            Console.WriteLine("Creating new record for the upcoming employee, with firstName!");
        }
        public NewEmployee(string firstName, string lastName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            Console.WriteLine("Creating new record for the upcoming employee, with firstName and lastName!");
        }
    }
}
