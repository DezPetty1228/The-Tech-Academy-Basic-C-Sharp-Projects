using System;
using System.Collections.Generic;
using System.Text;

namespace CAlling_Method_Submission_Assignment
{

    public class Program
    {
        static
            
            void Main()
        {
            // Instantiate the class MAthOperations callled mathops
            MathOperations mathOps = new MathOperations();

            // Call the first method, passing in an integer
            int result1 = mathOps.PerformMathOperation(10);
            Console.WriteLine("Result of integer math operation: " + result1);

            // Call the second method, passing in a decimal
            int result2 = mathOps.PerformMathOperation(5.5M);
            Console.WriteLine("Result of decimal math operation: " + result2);

            // Call the third method, passing in a string that represents an integer
            int result3 = mathOps.PerformMathOperation("15");
            Console.WriteLine("Result of string math operation: " + result3);
        }
    }

    // Class that performs math operations
    public class MathOperations
    {
        // Method that performs a math operation on an integer
        public int PerformMathOperation(int num)
        {
            int result = num + 5;
            return result;
        }

        // Method that performs a math operation on a decimal
        public int PerformMathOperation(decimal num)
        {
            int result = (int)(num * 2);
            return result;
        }

        // Method that performs a math operation on a string that represents an integer
        public int PerformMathOperation(string numString)
        {
            // Convert the string to an integer
            int num = Convert.ToInt32(numString);

            int result = num - 10;
            return result;
        }
    }
}



