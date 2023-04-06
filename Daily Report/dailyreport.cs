using System;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is as simple 
            //Console.WriteLine("What Is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            Console.WriteLine("What course are you on ?");
            string yourCourse = Console.ReadLine();

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pgNum = Convert.ToInt32(pageNumber);

            Console.WriteLine("Do you need help with anything? please answer true or false");
            string helpStatus = Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!” This is the end of the program.");

            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            //bool isStudying = false;
            //byte hoursWorked = 42;
            //sbyte currentTempature = -23;
            //char questionMark = '\u2103';

           // decimal moneyInBank = 100.5m;

            //double heightInCentimeters = 211.30202092;

           // float secondsLeft = 2.62f;

            //short tempatureOnMars = -341;

            //string myName = "Dezden";

            //int currentAge = 30;
           // string yearsOld = currentAge.ToString();

            //bool isDAmu = true;
            //string damuStatus = Convert.ToString(isDAmu);


            //Console.WriteLine(damuStatus);
           // Console.ReadLine();
        }
    }
}
