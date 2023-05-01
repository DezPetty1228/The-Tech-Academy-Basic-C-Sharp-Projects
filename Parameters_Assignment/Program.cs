using System;

namespace Parameters_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            // Prompt the user to enter the current day of the week.
            Console.WriteLine(" Please enter the day of the week. ");

            try
            {
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine());
                Console.WriteLine(day);
            }
            catch
            {
                Console.WriteLine("That was not a day of the week");
            }
            Console.ReadLine();

        }

        //Create an enum for the days of the week.

        public enum DaysOfTheWeek
        { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

        // Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week.” to the console if an error occurs.


    }
}
