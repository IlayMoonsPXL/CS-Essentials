using System.ComponentModel.Design;
using System.Runtime.ExceptionServices;

namespace Grootste_getal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("eerste geheel getal: ");
            int.TryParse(Console.ReadLine(), out int first);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Tweede gheel getal: ");
            int.TryParse(Console.ReadLine(), out int second);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Tweede gheel getal: ");
            int.TryParse(Console.ReadLine(), out int third);

            int biggest;

                Console.ForegroundColor = ConsoleColor.Red;
            if (first > second)
            {
                biggest = first;

            }
            else 
            {
                biggest = second;
            }
            if (third>biggest)
            {
                biggest = third;
            }
            Console.WriteLine($"Het grootste getal is {biggest}");
        }
    }
}
