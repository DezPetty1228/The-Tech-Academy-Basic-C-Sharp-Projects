using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try // prefered path
            {
                Console.WriteLine("Pick a number");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a  second number");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two....");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " Divided by " + numberTwo + " equals " + numberThree);
                Console.ReadLine();
            }
            catch (FormatException ex) // if errors occur 
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
