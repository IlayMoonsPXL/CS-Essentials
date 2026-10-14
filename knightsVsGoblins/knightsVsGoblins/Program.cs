using System.ComponentModel.Design;

namespace knightsVsGoblins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int knightHealth = 0;
            int goblinHealth;
            int goblinAttack;

           Random healthtBar = new Random();
            goblinHealth = healthtBar.Next(1, 101);

            

          


            bool isValid = false;


            while (!isValid)
            {

                Console.Write("Enter the health point for your knight: ");

                if (!int.TryParse(Console.ReadLine(), out knightHealth) || knightHealth < 1 || knightHealth > 100)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Pleas enter a valid number beween 0 and 100!");
                    Console.ResetColor();
                    isValid = false;


                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"knight health:{knightHealth} ");
                    Console.WriteLine($"Goblin health: {goblinHealth} ");
                    Console.ResetColor();

                    isValid = true;
                }
                
            }


                while (knightHealth > 0 && goblinHealth > 0) 
                {
                    Random attack = new Random();
                    goblinAttack = attack.Next(5, 17);


                    Console.WriteLine("choose your next move carefully ");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("1. Attack");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("2. Heal ");     
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("3. poisen ");
                    Console.WriteLine();
                   Console.ResetColor();

                Console.Write("Enter the number of your choice: ");
                    Console.WriteLine();

                if (!int.TryParse(Console.ReadLine(), out int choice)
                        || choice < 1 || choice > 3 )
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("invalid values ​​- 5 health");
                        Console.ResetColor();
                        Console.WriteLine();

                    knightHealth -= 5;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"knight health:{knightHealth} ");
                        Console.WriteLine($"Goblin health: {goblinHealth}");
                        Console.ResetColor();
                        Console.WriteLine();
                        continue;
                    }

                    switch (choice)
                    {                
                        case 1:
                            choice = 1;
                            goblinHealth -= 10;
                            knightHealth -= goblinAttack;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("You attaced the goblin for 10 damage!");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine($"The gobline Attack you for {goblinAttack} damage! ");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"knight health:{knightHealth} ");
                            Console.WriteLine($"Goblin health: {goblinHealth}");
                            Console.ResetColor();
                             break;

                        case 2:
                            choice = 2;
                            knightHealth = Math.Min(knightHealth + 10, 100);
                            knightHealth -= goblinAttack;
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("You heald yourself for 10 healt points!");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine($"The gobline Attack you for {goblinAttack} damage! ");
                            Console.WriteLine();

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($" knight health:{knightHealth} ");
                            Console.WriteLine($"Goblin health: {goblinHealth} ");
                            Console.ResetColor();

                        break;

                    case 3:
                        choice = 3;
                        knightHealth = Math.Min(knightHealth + 100, 100);
                        goblinHealth /= 2 ;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("You heald yourself to 100 procent!");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine($"Yoe took 50 procent of the goblin his health");
                        Console.WriteLine();

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($" knight health:{knightHealth} ");
                        Console.WriteLine($"Goblin health: {goblinHealth} ");
                        Console.ResetColor();

                        break;




                }
                if (knightHealth <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Defeat! you were Killed by the boblin!");
                    Console.ResetColor();
                }
                if (goblinHealth <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You won the goblin has died !!!! ");
                    Console.ResetColor();
                }
                }

               

            
            



        }
    }
}
