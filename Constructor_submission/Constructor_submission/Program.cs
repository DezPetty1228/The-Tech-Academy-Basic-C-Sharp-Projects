using System;

namespace Constructor_submission
{
    class Program
    {
        static void Main(string[] args)
        {
            const int century = 100; // Create a const variable.

            var player = "Dez";    //Create a variable using the keyword “var.”

        }
    }

    public class NewEmployee    //Chain two constructors together.
    {
        private int id;
        private string name;
        public NewEmployee() : this(0001, "")
        {

        }
        public NewEmployee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public NewEmployee(int id) : this(id, "")
        {

        }
    }
}
