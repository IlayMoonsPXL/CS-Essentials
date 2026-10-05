using System.Runtime.CompilerServices;

namespace Leeftijd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Het huidige jaartal is " + DateTime.Today.Year);
            Console.Write("Wat is je geboortejaar");
            string input = Console.ReadLine();
            int birthyear = int.Parse(input);

            int age = DateTime.Today.Year - birthyear;

            Console.WriteLine($"Je leeftijd is momenteel {age}");


        }
    }
}
