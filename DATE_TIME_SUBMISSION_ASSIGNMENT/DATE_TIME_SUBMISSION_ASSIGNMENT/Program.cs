using System;

namespace DATE_TIME_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("Current Date and Time: " + currentDateTime); // displays current time
            Console.WriteLine(" please enter a number between 1 and 20 ");   // ask for user to imput a number
            int hoursAhead = Convert.ToInt32(Console.ReadLine()); // converts user imput to int and assigns it to hoursAhead
            Console.WriteLine("in {0} hours the time will be: {1}", hoursAhead, currentDateTime.AddHours(hoursAhead));
            Console.WriteLine("in " + hoursAhead + " hours It will be " + currentDateTime.AddHours(hoursAhead));
        }
    }
}
