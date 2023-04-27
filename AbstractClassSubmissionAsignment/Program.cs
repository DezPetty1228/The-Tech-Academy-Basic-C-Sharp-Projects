using System;

namespace AbstractClassSubmissionAsignment
{
    public class Program
    {
      public static void Main()
        {   // Inside the Main() method, instantiate an Employee object with firstName “Sample” and lastName “Student”. Call the SayName() method on the object.
            
            Employee janitor = new Employee();
            janitor.FirstName = "Sample";
            janitor.LastName = "student";
            janitor.SayName();
            Console.ReadLine();

            // instantiated IQuittable as quitter
            IQuittable quitter = new Employee();
            quitter.Quit();
            
        }
    }
}
