namespace Gemiddelde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eerste geheel getal: ");
            double.TryParse(Console.ReadLine(), out double first);
            Console.Write("Tweede geheel getal: ");
            double.TryParse(Console.ReadLine(), out double second);
            Console.Write("Derde geheel getal: ");
            double.TryParse(Console.ReadLine(), out double third);
            Console.Write("Vierde geheel getal: ");
            double.TryParse(Console.ReadLine(), out double fourth);

            Console.WriteLine($"Het gemidelde ={(first + second + third + fourth) / 4}");

        }
    }
}
