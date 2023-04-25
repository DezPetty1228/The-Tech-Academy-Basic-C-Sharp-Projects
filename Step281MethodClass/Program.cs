using System;


namespace Step281MethodClass
{
    class Program
    {
        static void Main()
        {
            MathTest math = new MathTest(); // In the Main() method of the console app, instantiate the class.

            // Call the method in the class, passing in two numbers.
            math.DivisionMath(numerator: 12, denominator: 2); // Call the method in the class, specifying the parameters by name
            Console.WriteLine();

            math.DivisionMath(25, 5);
            Console.ReadLine();
        }
    }
}
