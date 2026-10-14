using System.Reflection.Metadata.Ecma335;

namespace Driehoek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef de lengte zijde A: ");
            if (!double.TryParse(Console.ReadLine(), out double A) || A < 0 )
            {
                Console.Write("Geen geldige invoer ");
                return;
            }
            Console.Write("Geef de lengte zijde B: ");
            if (!double.TryParse(Console.ReadLine(), out double B) || B < 0)                 
            {
                Console.Write("Geen geldige invoer ");
                return;
            }
            Console.Write("Geef de lengte zijde C: ");
            if (!double.TryParse(Console.ReadLine(), out double C) || C < 0) 
            {
                Console.Write("Geen geldige invoer ");
                return;
            }
            if(A + B > C && A + C >B && B + C > A)
            {
                double s = (A + B + C) / 2;
                double o = Math.Sqrt(s * (s - A) * (s - B) * (s - C));
                Console.WriteLine($"de opvervlakte is {o:F2}cm² ");



            }
            else
            {
                Console.WriteLine(" Geen geldige dierhoek ");
            }
            

            

           


        }
    } 
}
