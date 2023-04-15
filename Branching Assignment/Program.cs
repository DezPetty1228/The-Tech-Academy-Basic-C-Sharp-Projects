using System;

namespace Branching_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.WriteLine("What is your package weight?");
            string weight = Console.ReadLine();
            double packWeight = Convert.ToDouble(weight);
            //checks if package weight is to big

            if (packWeight >= 51)
            {
                // error message if pachage is too heavy
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("What is the width of your package in inches? ");
                string inchWidth = Console.ReadLine();
                double packWidth = Convert.ToDouble(inchWidth);
                Console.WriteLine("What is the height of your package in inches? ");
                string inchHeight = Console.ReadLine();
                double packHeight = Convert.ToDouble(inchHeight);
                Console.WriteLine("What is the length of your package in inches? ");
                string inchLength = Console.ReadLine();
                double packLength = Convert.ToDouble(inchLength);

                // creates a variable using thw total of the user input dimensions;
                double totalDimensions = packHeight = packLength + packWidth;

                if (totalDimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    // Calculates shipping quote using user provided dimensions
                    double totalQuote = (packWidth * packLength * packHeight) * (packWeight) / 100;
                    Console.WriteLine(totalQuote);
                }
            }
        }
    }
}
