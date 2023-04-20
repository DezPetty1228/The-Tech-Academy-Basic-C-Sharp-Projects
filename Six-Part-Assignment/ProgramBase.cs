using System;
using System.Collections.Generic;
using System.Text;

namespace Six_Part_Assignment
{
    class ProgramBase
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

            for (int j = 0; j < months.Length; j++)
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

            for (int i = 0; scores.Length > i; i++) // must have the 3 conditions /starting value for loop == int i = 0
                                                    // / how long you want loop to run / i < scores.length
                                                    // incrimentation /i++
            {
                if (scores[i] < 71)
                {
                    Console.WriteLine("Congratulations you passed with a score of:  " + scores[i]);
                }
                // compares value in 
                if (scores[i] < 70)
                {
                    Console.WriteLine("you Score is: " + scores[i] + " You did not pass");
                }
                if (scores[i] <= 59)
                {
                    Console.WriteLine(" Your score was: " + scores[i] + "Unfortunately you Fail");
                }
            }
            // Assignment 4
            // A list of strings where each item in the list is unique.
            List<string> daysList = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            // Ask the user to input text to search for in the list.
            Console.WriteLine(" What is your Favorite day of the week?");
            string yourDay = Console.ReadLine();

            // A loop that iterates through the list and then displays the index of the list item that contains matching text on the screen.
            if (daysList.Contains(yourDay))
            {
                for (int t = 0; daysList.Count > t; t++)
                {
                    if (daysList[t] == yourDay)

                    {
                        Console.WriteLine(daysList[t] + " @INDEX " + t);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("That is not on the list, Please Capitalize First letter");
                Console.ReadLine();
            }
            
            // Assignment 5
            //A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.
            List<string> words = new List<string> { "Dezden", "Alissa", "Brynn", "Jesse", "MIke", "Kaden", "Dezden"};

            // Create a loop that iterates through the list and then displays the indices of the items matching the user-selected text.
            // Ensure to remove any break statements that may prevent your code from returning multiple matches.

            Console.WriteLine(words);
            Console.WriteLine("Which name do you like the most ?");
            string faveName = Console.ReadLine();

            if (words.Contains(faveName))
            {
                for (int k = 0; k < words.Count; k++)
                {
                    if (words[k] == faveName)
                    {
                        Console.WriteLine(words[k] + " @Index " + k);
                    }
                }
            }
            else // Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is 
            {
                Console.WriteLine("Your input is not on the list ");
                Console.ReadLine();
            }
            
                    // Assignment part 6
                    //  Create a list of strings that has at least two identical strings in the list.
                    List<string> letters = new List<string> { "A", "B", "C", "k", "B", "D", };
                    List<string> twins = new List<string>();
                    //Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
                    foreach (string dub in letters) // INDICATES HOW LONG THE foreah loop will go
                    {
                        if (twins.Contains(dub))
                        {
                            Console.WriteLine(" This is  Duplicate " + dub); // outputs that the value in dub is a duplic
                        }
                        else
                        {
                            Console.WriteLine(" This is is unique " + dub); // checks and displays wther or not value in dub is unique or not
                        }
                        twins.Add(dub); // adds duplicates to twis list

                    }
                    {

                    }
                }
            }
        }
