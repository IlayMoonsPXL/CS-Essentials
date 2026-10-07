namespace Verzekering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Wat is u leeftijd");
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine("Geen geldige leeftijd");
                return;
            }
            
            double insurance = 0.00;
            if (age <18 )
            {
                Console.WriteLine($"Het te betaalen bedrag is € {insurance:F2}");
                return;
            }
        
            Console.WriteLine("Geef het nummer van u gewest in: ");
            Console.WriteLine("  1.Vlaanderen");
            Console.WriteLine("  2.Brussel");
            Console.WriteLine("  3.Wallonie");
            string gewest = Console.ReadLine();

            Console.WriteLine("bent u een rooker (JA OF NEE): ");
            string smoker = Console.ReadLine();

            

            if (age < 18)
            {
                insurance = 0.00;
            }

            if (age >= 18 && age < 67)
            {
                insurance = 150;
            }

            if (age >= 67)
            {
                insurance = 300;
            }
            

            if (gewest == "2")
            {
                insurance += 200;
            }

            if (smoker == "ja")
            {
                insurance *= 2;
            }
            Console.WriteLine($"Het te betaalen bedrag is € {insurance:F2}");
        }
    }
}
