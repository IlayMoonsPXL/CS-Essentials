using System.ComponentModel.DataAnnotations;

namespace Raadspelletje
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int randomNumber = random.Next(1, 101);


            StartCheck(randomNumber);




            int answer;
           

            Console.WriteLine("Raadspel");
            

        }

        static void StartCheck(int randomNumber)
        {
            int answer;
            do
            {
                answer = GiveAnswer();
                CheckAnswer( answer, randomNumber);
            } while (answer != randomNumber);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("het getal is geraden ");
            Console.ResetColor();

        }

        static int GiveAnswer()
        {
            int number;

            do
            {
                Console.WriteLine("Geef een getal tussen 1 en 100");

            } while (!int.TryParse(Console.ReadLine(), out number) || number < 1 || number > 100);
         
            return number;
        }

        static void CheckAnswer( int answer, int randomNumber)
        {
            if (answer < randomNumber)
            {
                Console.WriteLine("Raad hoger!");

            }
            else if (answer > randomNumber)
            {
                Console.WriteLine("Raad lager!");
            }
           
        }
    }
}
