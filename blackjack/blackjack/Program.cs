using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace blackjack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerCard = 0;
            int play = 0;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("♥ ♦ ♣ ♠ B L A C K J A C K ♥ ♦ ♣ ♠");
            Console.WriteLine("");
            Console.WriteLine("     Welcome to the table!       ");
            Console.WriteLine("---------------------------------");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Are you feeling lucky?");
           
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  1. Hell yeah! Lets play!");
            Console.WriteLine("  2. Nah, maybe later.");
            Console.ResetColor();



            while (!int.TryParse(Console.ReadLine(), out play) | play > 3 | play < 1)
            {


                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invaldi choice, pleas try again");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("press ENTER to try again...");
                while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;
                Console.ResetColor();


                switch (play)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("your turn, press ENTER to draw a card ...");
                        while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;
                        Console.ResetColor();

                        break;
                    case 2:
                        break;

                }
            }
              DealPlayerCards();


        }
        static void PlayNextGame()
        {

        }
        static void DealPlayerCards()
        {
            int playerCard = GetRandomCard(0);

            Console.WriteLine($"You drew a {playerCard} your total is now {playerCard} ");
        }
        static void DealComputerCards()
        {

        }

        
        static int GetRandomCard(int card1)
        {
            Random card = new Random();
            card1 = card.Next(2, 12);

            return card1;
        }
    }
}
