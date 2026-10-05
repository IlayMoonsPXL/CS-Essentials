using System.Security.Cryptography.X509Certificates;

namespace FavorieteKleur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("naam: ");
            string name = Console.ReadLine();

            Console.Write("Wat is u favoriete kleur: ");
            string favorites = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Leuk op je te leren kennen " + name);
            Console.Write("je faforiete kleur is " + favorites);
            Console.ResetColor();

            

        }
    }
}
