using System;

namespace CAlling_Method_Submission_Assignment
{
    class Program
    {
        static void Main()
        {
            // Ask the user what number they want to perform math operations on.
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            // Call each of the MathOperations methods with the user's input and display the result to the screen.
            int result1 = MathOperations.AddTwo(number);
            Console.WriteLine($"Adding 2: {result1}");

            int result2 = MathOperations.MultiplyByFive(number);
            Console.WriteLine($"Multiplying by 5: {result2}");

            int result3 = MathOperations.Square(number);
            Console.WriteLine($"Squaring: {result3}");

            // Wait for user input before closing the console window.
            Console.ReadLine();
        }
    }
}
