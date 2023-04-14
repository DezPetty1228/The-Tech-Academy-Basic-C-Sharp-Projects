using System;

namespace Math_and_Comparison_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program!");
            Console.WriteLine("Person 1: What is your hourly Rate? please round to nearest dollar!");
            string perHour1 = Console.ReadLine();
            double hourlyRate1 = Convert.ToDouble(perHour1);
            Console.WriteLine("How Many hours weekly?");
            string hrs1 = Console.ReadLine();
            double hoursPerWeek1 = Convert.ToDouble(hrs1);
            Console.WriteLine("Person 2: What is your Hourly rate? please round to nearest dollar!");
            string perHour2 = Console.ReadLine();
            double hourlyRate2 = Convert.ToDouble(perHour2);
            Console.WriteLine("How many Hours weekly?");
            string hrs2 = Console.ReadLine();
            double hoursPerWeek2 = Convert.ToDouble(hrs2);
            double weeks = 52;
            double annualSalary1 = hourlyRate1 * hoursPerWeek1 * weeks;
            double annualSalary2 = hourlyRate2 * hoursPerWeek2 * weeks;
            Console.WriteLine("Person 1 Annual Salary: " + annualSalary1);
            Console.WriteLine("Person 2 Annual Salary: " + annualSalary2);
            bool p1Up = annualSalary1 > annualSalary2;
            Console.WriteLine("Is person 1's Annual Salary more than person 2? " + p1Up);
        }
    }
}
