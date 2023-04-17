using System;
using System.Collections.Generic; // Generic gives us the ability to 

namespace ArraysandLists
{
    class Program
    {
        static void Main()
        {
            // initializes and creates an instance of an array called wordArray1 
            String[] wordArray1 = { "Welcome to the Jungle", "We Are The Titans", "It goes Down in the DM's", "Leave The door open" }; 
            Console.WriteLine("pick a number between 1 and 8"); // Asks for user imput 
           int index = Convert.ToInt32(Console.ReadLine()); // reads and converts user imput
            if (index < 0 || index > wordArray1.Length) 
            {
                Console.WriteLine("That number is nt in the index");
            }
            else
            {
                Console.WriteLine(wordArray1[index]);
                Console.ReadLine();
            }

            int[] numArray = { 6, 21, 333, 111, 3, 4, 26, 420 };
            int index2 = Convert.ToInt32(Console.ReadLine()); // reads and converts user imput
            if (index < 0 || index2 > numArray.Length)
            {
                Console.WriteLine("That number is not in the index");
            }
            else
            {
                Console.WriteLine(wordArray1[index]);
                Console.ReadLine();
            }


            List<string> wordList = new List<string>();
            wordList.Add(" West Side ");
            wordList.Add("East Side");
            wordList.Add("North Side");
            wordList.Add("South Side");

            int index3 = Convert.ToInt32(Console.ReadLine()); // reads and converts user imput
            if (index3 < 0 || index3 > wordList.Count)
            {   // error mesage when user pics a number not in the index
                Console.WriteLine("That number is not in the index");
            }
            else
            {
                Console.WriteLine(wordList[index3]);
                Console.ReadLine();
            }
            //Console.WriteLine(wordList[0]);
            //Console.ReadLine();



            // n order to initialize an array, you must create a new Instance of that array.
            // must declare array length in the beginning 
            //int[] numArray = new int [5];  //array length is 5
            //numArray[0] = 5;
            //numArray[1] = 13;
            //numArray[2] = 9;
            //numArray[3] = 21;
            //numArray[4] = 16;
            //// exact same array writtien in a cleaner more optimized way
            //int[] numArray2 = new int[] { 5, 13, 9, 21, 16 };

            //int[] numArray3 = { 5, 13, 9, 21, 16, 64, 33, 26, 9 }; // easiest way to initialize an Array

            //numArray3[5] = 164; // Changes value in [5] from 64 to 164

            //Console.WriteLine(numArray[3]);
            //Console.ReadLine();
            //Console.WriteLine(numArray2[4]);
            //Console.ReadLine();
            //Console.WriteLine(numArray3[5]);
            //Console.ReadLine();

        }
    }
}
