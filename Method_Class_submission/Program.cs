using System;

namespace Class_submission
{
    class Program
    {
        static void Main()
        {
            ModernMAth test = new ModernMAth();
            int input = Convert.ToInt32(Console.ReadLine()); // converts user input string into int named input
            test.NumberFun(input); // calls numberfun mnethod and passes in user input string converted into int called input
            Console.ReadLine();

            test.NumberFun(3.0m, out int num2); // calls method using instance of class MOdernmath called test
            Console.WriteLine(num2); // displays num2 as a string
            Console.ReadLine();
        }
    }
}
