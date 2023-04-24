using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try // prefered path runs if proper user input is aknowledged
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
            catch (FormatException ex) // runs if format error occurs0
            {
                Console.WriteLine(" please type a whole number. ");
            }
            catch (DivideByZeroException) // Runs if user divides by 0
            {
                Console.WriteLine("Please don't divide by zero");
            }
            catch(Exception ex) // runs if error occurs
            {
                Console.WriteLine(ex.Message);
            }
            finally // runs no matter what
            {
                Console.ReadLine();

            }
        }
    }
}
