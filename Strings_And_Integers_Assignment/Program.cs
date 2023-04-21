using System;
using System.Collections.Generic
    ;

namespace Strings_And_Integers_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbList = new List<int> { 100, 200, 300, 400, 500 };
            Console.WriteLine(" Pick a number?");
            int userPick = Convert.ToInt32(Console.ReadLine());
            foreach (int i in numbList) //Write a loop that takes each integer in the list,
            {
                try
                {
                    int result = i / userPick;  // divides it by the number the user entered
                    Console.WriteLine(result);
                    Console.ReadLine(); // and displays the result to the screen.
                }
                catch (DivideByZeroException) //
                {
                    Console.WriteLine("Please don't divide by zero");
                }
                catch (FieldAccessException ex)
                {
                    Console.WriteLine(" please type a whole number. ");
                }
                catch (Exception ex) // runs if error occurs
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
}
