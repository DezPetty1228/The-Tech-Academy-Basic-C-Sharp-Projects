using System;

namespace MethodAndObjects
{
    class Program
    {
        static void Main()
        {     // Inside of the Main method, instantiate and initialize an Employee object with a first name of “Sample” and a last name of “Student”.
            Person student = new Person();
            student.FirstName = "Sample";
            student.LastName = "Student";
            student.SayName();
            Console.ReadLine();
        }
    }
}
