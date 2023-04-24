using System;

namespace Method_Submission_Assignment
{
    class Program
    {

        static void Main() // is the main Method 
        {
            // access modifier = static/ return type = void/ parameters are within the () 
            Console.Write("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            try
            {
                int num2 = int.Parse(Console.ReadLine());
                int result1 = TimeCalculations.AddNumbers(num1, num2);
                Console.WriteLine(result1);
            }
            catch
            {
                 int result1 = TimeCalculations.AddNumbers(num1);
                Console.WriteLine(result1);
            }
            Console.ReadLine();
        } 
        
       
    }
}
