using System;

namespace Six_Part_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment part 1
            // One-dimensional array of strings
            string[] months = { "none", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            foreach (string i in months)
            {
                Console.WriteLine(i);
            }

            // Ask user for input:
            Console.WriteLine(" What number month were you born ");
            int numberMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numberMonth(numberMonth));


            //A loop that iterates through each string in the array and adds the user's text input to the end of each string



            //Then create a second loop that prints off each string in the array one at a time.

            //
            // 

            // Assignment part 2
            //// Create an infinite loop
            //while (true)
            //{
            //    //This statement will be printed infinite times
            //    Console.WriteLine(" infinite loop incoming ");
            //}
            //    Console.ReadLine();
            //break;
            //// This Fixes the infinite loop 

            // Assignment Part 3
            //A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator
            int[] scores = { 98, 94, 78, 69, 96, 87, 81, 92, 100 };

            for (int i = 0; scores.Length > i; i++)
            {
                // compares value in 
                if (scores[i] < 70)
                    Console.WriteLine("you Score is: " + scores[i] + "You did not pass");

                if (scores[i] <= 59)
                    Console.WriteLine(" Your score was: " + scores[i] + "Unfortunately you Fail");
            





        }
    }
}
