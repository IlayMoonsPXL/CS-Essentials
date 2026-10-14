using System.ComponentModel.Design;

namespace knightsVsGoblins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int knightHealth;
            int goblinHealth;

            Random healthtBar = new Random();
            goblinHealth = healthtBar.Next(1, 101);

            bool isValid = false;



            while (!isValid)
            {
                Console.WriteLine("Geef de knighthealth waar u mee wilt beginnen");

                if (!int.TryParse(Console.ReadLine(), out knightHealth) || knightHealth < 1 || knightHealth > 100) ;
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Dit is geen geldig getal ");
                    isValid = false;
                   

                }
                else
                {
                    isValid = true;
                }
               

            }
            while (!isValid)
            {
                Console.WriteLine("Geef de knighthealth waar u mee wilt beginnen");

                if (!int.TryParse(Console.ReadLine(), out knightHealth) || knightHealth < 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Dit is geen geldig getal");
                    isValid = false;
                }
                else
                {
                    isValid = true;
                }
            }



        }
    }
}
