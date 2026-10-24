using System.Runtime.InteropServices;

namespace dice_duel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int roundNumber = 1;
            int player = 0;
            int computer = 0;

            printStart();

            while (player < 3 && computer < 3)
            {
                PrintRound(roundNumber, player, computer);

                RollThreeDice(out int playerScore, out int computerScore);

                if (playerScore > computerScore)
                {
                    player++;
                    Console.WriteLine("PLAYER wins this round!");
                }
                else if (computerScore > playerScore)
                {
                    computer++;
                    Console.WriteLine("COMPUTER wins this round!");
                }
                else
                {

                    Console.WriteLine("It's a draw!");
                }
                roundNumber++;
                Console.WriteLine("Press ENTER to continue...");
                while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;

                Console.Clear();
                PrintRound(roundNumber, player, computer);

                Console.Clear();
                Console.WriteLine("========== GAME OVER ==========");

                if (player == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("PLAYER WINS THE GAME!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("COMPUTER WINS THE GAME!");
                    Console.ResetColor();
                }
                

            }
            static void printStart()
            {
                Console.WriteLine("=== DICE DUEL ===");
                Console.WriteLine("beste out if five wins!");
                Console.WriteLine("Pres ENTER to start...");
                while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;

            }
            static int PrintRound(int round, int playerWins, int computerWins)
            {
                Console.Clear();
                Console.WriteLine($"--- ROUND {round} --- ");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Player wins {playerWins} | ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Computer wins {computerWins}");
                Console.ResetColor();
                Console.WriteLine();



                return round;

            }
            static void RollThreeDice(out int PlayerScore, out int computerScore)
            {

                Random random = new Random();
                int playerDice1 = random.Next(1, 7);
                int playerDice2 = random.Next(1, 7);
                int playerDice3 = random.Next(1, 7);

                Console.WriteLine("PLAYER rolled: ");
                Console.WriteLine($"dice:1 {playerDice1}");
                Console.WriteLine($"dice:2 {playerDice2}");
                Console.WriteLine($"dice:3 {playerDice3}");

                PlayerScore = playerDice1 + playerDice2 + playerDice3;
                Console.WriteLine($"Total player score: {PlayerScore}");



                int computerDice1 = random.Next(1, 7);
                int computerDice2 = random.Next(1, 7);
                int computerDice3 = random.Next(1, 7);
                Console.WriteLine("");
                Console.WriteLine("COMPUTER rolled: ");
                Console.WriteLine($"dice:1 {computerDice1}");
                Console.WriteLine($"dice:2 {computerDice2}");
                Console.WriteLine($"dice:3 {computerDice3}");

                computerScore = computerDice1 + computerDice2 + computerDice3;
                Console.WriteLine($"Total computer score: {computerScore}");

            }
        }
    }
}

