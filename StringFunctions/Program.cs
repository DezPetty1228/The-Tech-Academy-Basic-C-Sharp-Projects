using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "Dezden"; // creates first string and names it "one"
            string two = "is"; // Creates 2nd string and names it "two"
            string three = "Pretty awsome"; // creates 3rd string and names it "three


            one = one.ToUpper(); // Changes string one so that it displays all capital letters 
            Console.WriteLine(one + two + three); // Concatenates all three strings and displays them on a single line like a sentence
            Console.ReadLine(); // stops the program so that you can read what is output
            Console.WriteLine(one); // displays the newly changed string one as all capital letters
            Console.ReadLine();

            StringBuilder sb = new StringBuilder(); // creates a buildable Stringbuilder called sb

            sb.Append("I've got 14 dollars in my wallet "); // added text to Stringbuilder SB 
            sb.Append(" plus one buisness card ");   // added text to Stringbuilder SB 
            sb.Append(" and Imma Call it ");    // added text to Stringbuilder SB 
            sb.Append("Noowwww ");  // added text to Stringbuilder SB 
            sb.Append("Right Nowww ");  // added text to Stringbuilder SB
            sb.Append("\" Masego - Saxs 5th Avenue\"");  // added text to Stringbuilder SB 

            Console.WriteLine(sb); // disploays sb as a full line of text.
            Console.ReadLine(); // stops program so that user can read input


        }
    }
}
