using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age ?");
            string age = Console.ReadLine();
            int old = Convert.ToInt32(age);
            Console.WriteLine("Have you ever had a DUI? please answer true or false");
            string dui = Console.ReadLine();
            bool hasDUI = Convert.ToBoolean(dui);
            Console.WriteLine("How many speeding tickets do you have ?");
            string speed = Console.ReadLine();
            int tickets = Convert.ToInt32(speed);
            Console.WriteLine("Qualified ?");
            bool isQualified = old >= 16 && (hasDUI != true && tickets <= 1);
            Console.WriteLine(isQualified);

        }
    }
}
