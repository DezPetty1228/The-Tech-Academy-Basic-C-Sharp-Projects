using System;


// A game of 21 or blackjACK
namespace Twentyone // methods must be inside the namespace
{
     class Program 
    {
        //"I will be a Millionare and create generational welath for myself and my family";
        static void Main() // function or method or routine = Main
        {
            
            DateTime datetime = new DateTime(1992, 12, 28, 14, 30, 18);
            
            Console.WriteLine("Welcome to the West Coast Family Casino. Lets's start by reminding me your name. ");
            string playerName = Console.ReadLine();
            Console.WriteLine("How Much Money did you bring to play with? ");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Hello, {0} . would you like to play a game of 21 ? ", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.IsActivelyPlaying = true;
                while (player.IsActivelyPlaying && player.Balance >0 )
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thanks For playing! ");
            }
            Console.WriteLine("Feel free to look around ");
            Console.ReadLine();
        }
    }
 }
   