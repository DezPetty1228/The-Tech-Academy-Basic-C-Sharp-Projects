using System;

namespace AbstractClassSubmissionAsignment
{
    public class Program
    {
      public static void Main()
        {   // Inside the Main() method, instantiate an Employee object with firstName “Sample” and lastName “Student”. Call the SayName() method on the object.
            Employee teacher = new Employee();
            teacher.FirstName = "Scott";
            teacher.LastName = "Perkins";
            teacher.ID = 12541;

            Employee janitor = new Employee();
            janitor.FirstName = "Sample";
            janitor.LastName = "student";
            janitor.ID = 14510;
            janitor.SayName();
            Console.ReadLine();

            Employee dean = new Employee();
            dean.FirstName = "Scott";
            dean.LastName = "Perkins";
            dean.ID = 12541;

            // instantiated IQuittable as quitter
            IQuittable quitter = new Employee();
            quitter.Quit();

            Console.WriteLine(teacher == janitor); // checks to see if the employee id's ARE THE SAME
            Console.ReadLine();
        }
    }
}
