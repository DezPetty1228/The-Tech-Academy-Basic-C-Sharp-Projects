using System;

namespace MATH_AND_COMPARISON_OPERATOR_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1: What is your hourly Rate? please round to nearest dollar.");
            string perHour1 = Console.ReadLine();
            double hourlyRate1 = Convert.ToDouble(perHour1);
            Console.WriteLine("How many hours weekly ?");
            string hrs1 = Console.ReadLine();
            double hoursPerWeek1 = Convert.ToDouble(hrs1);
            Console.WriteLine("person 2: What is your hourly rate? please round to nearest dollar.");
            string perHour2 = Console.ReadLine();
            double hourlyRate2 = Convert.ToDouble(perHour2);
            Console.WriteLine("How many hours weekly ?");
            string hrs2 = Console.ReadLine();
            double hoursPerWeek2 = Convert.ToDouble(hrs2);
            int weeks = 52;
            double annualSalary1 = hourlyRate1 * hoursPerWeek1 * weeks;
            double annualSAlary2 = hourlyRate2 * hoursPerWeek2 * weeks;
            Console.WriteLine("Person 1 Anual Salary:" + annualSalary1);
            Console.WriteLine("Person 2 Annual Salary: " + annualSAlary2);
            Console.WriteLine("Does Person 1 make more than Person 2 ?");
            
        }
    }
}
