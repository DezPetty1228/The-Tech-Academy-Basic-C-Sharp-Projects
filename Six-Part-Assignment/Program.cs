using System;
using System.Collections.Generic;

namespace Six_Part_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment part 1
            // One-dimensional array of strings
            string[] months = { "none", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            //Then create a second loop that prints off each string in the array one at a time.
            foreach (string i in months)
            {
                Console.WriteLine(i);
            }

            // Ask user for input:
            //A loop that iterates through each string in the array and adds the user's text input to the end of each string
            Console.WriteLine(" What number month were you born ");
            int numberMonth = Convert.ToInt32(Console.ReadLine());
            
            for(int j = 0;  j < months.Length; j++)
               {
                Console.WriteLine(months[j] + numberMonth);
            }
            
            // Assignment part 2
            // Create an infinite loop
            while (true)
            {
            //This statement will be printed infinite times
                Console.WriteLine(" infinite loop incoming ");
                break; // This Fixes the infinite loop 

            }

            // Assignment Part 3
            //A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator
            int[] scores = { 98, 94, 78, 69, 96, 87, 81, 92, 100 };

            for (int i = 0; scores.Length > i; i++)
            {
                // compares value in 
                if (scores[i] < 70)
                {
                    Console.WriteLine("you Score is: " + scores[i] + " You did not pass");
                }
                else if (scores[i] <= 59)
                 {
                    Console.WriteLine(" Your score was: " + scores[i] + "Unfortunately you Fail");
                }

                // Assignment 4
                // A list of strings where each item in the list is unique.
                List<string> daysList = new List<string>();
                daysList.Add("Monday");
                daysList.Add("Tuesday");
                daysList.Add("Wednesday");
                daysList.Add("Thursday");
                daysList.Add("Friday");
                daysList.Add("Saturday");
                daysList.Add("Sunday");

                // Ask the user to input text to search for in the list.
                Console.WriteLine(" What is your Favorite day of the week?");
                string yourDay = Console.ReadLine();

                // A loop that iterates through the list and then displays the index of the list item that contains matching text on the screen.
                for (int t = 0; daysList.Count > t; t++)
                {
                    if (daysList = (t))
                    {
                        Console.WriteLine(daysList(t));
                    }
                    else
                    {
                        Console.WriteLine("That is not on the list, Please CApitalize First letter");
                        Console.ReadLine();
                    }
                }
                    // Assignment 5
                    //A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.
                    List<string> words = new List<string>();
                    words.Add("Dezden");
                    words.Add("Alissa");
                    words.Add("Kaden");
                    words.Add("Brynn");
                    words.Add("Jesse");
                    words.Add("Kim");
                    words.Add("Alan");
                    words.Add("Kierra");

                    // Create a loop that iterates through the list and then displays the indices of the items matching the user-selected text.
                    // Ensure to remove any break statements that may prevent your code from returning multiple matches.

                    Console.WriteLine(words);
                    Console.WriteLine("Which name do you like the most ?");
                    string faveName = Console.ReadLine();

                    for (int k = 0; k < words.Count; k++)
                    {
                        if (words == faveName)
                        {
                            Console.WriteLine();
                        }
                        else // Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is 
                        {
                            Console.WriteLine("Your input is not on the list ");
                        }
                    }

                // Assignment part 6
                //  Create a list of strings that has at least two identical strings in the list.
                List<string> letters = new List<string>();
                letters.Add("A");
                letters.Add("B");
                letters.Add("C");
                letters.Add("K");
                letters.Add("B");
                letters.Add("D");

                //Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
                foreach(<string> in letters)
            }
        }
        }
    }
