using System;

namespace Console_App_submisission
{
    class Program
    {
        static void Main(string[] args)
        {
            ////int currentTemperature = 48;
            ////int roomTemperature = 71;

            ////if (currentTemperature != roomTemperature)
            ////{
            ////    Console.WriteLine(" it is not exactly room tempature.");
            ////}
            ////else if (roomTemperature < currentTemperature)
            ////{
            ////    Console.WriteLine(" its pretty warm in here ");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("it is exactly room tempature");
            ////}
            ////Console.ReadLine();
            //int favNumber = 4;
            //Console.WriteLine(" pick a number between 1 and 10 .");
            //int numberPick = Convert.ToInt32(Console.ReadLine());
            //string result = numberPick == favNumber ? "you picked Dezden's Favorite number!." : " You did not pick the correct number !";
            //Console.WriteLine(result);
            //Console.ReadLine();

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;

                Console.WriteLine(" Guess a number ?");
            int number= Convert.ToInt32(Console.ReadLine());
            bool isGuessed = false;

            do
            {
                switch (number)
                {
                    case 4:
                        Console.WriteLine(" You picked Brynn's Number. ");
                        Console.WriteLine("Guess a number ?");
                        isGuessed = true;
                        break;
                    case 21:
                        Console.WriteLine("You picked #21 Prime Time");
                        isGuessed = true;
                        break;
                    case 3:
                        Console.WriteLine("You Picked # 3 Alissa's Soccer number");
                        isGuessed = true;
                        break;
                    case 34:
                        Console.WriteLine("You Picked #34, Dezden's College football number!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You picked incorectly please try again.");
                        Console.WriteLine("pick a number ?.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);
            }
        }
    }
}
