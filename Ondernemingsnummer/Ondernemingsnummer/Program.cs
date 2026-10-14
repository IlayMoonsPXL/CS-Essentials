namespace Ondernemingsnummer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string ondernemingstext = " ";
            while (true)
            {
                Console.ResetColor();

                Console.Write("Geef u ondernemingsnummer deze is 10 cijfers lang: ");
                ondernemingstext = Console.ReadLine();

                if (ondernemingstext == null || ondernemingstext.Trim().Length != 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ondernemingsnummer Moet 10 cijfers bevatten");
                    
                    continue;
                }
                 
                if (!long.TryParse(ondernemingstext, out long ondernemingsnummer))
                {
                    Console.WriteLine("Geef cijfers in ");
                    continue;
                }
                
                // Everything is fine. We have 10 digits now let's see if the module 97 is also correct.
                long lastTwoNumbers = ondernemingsnummer % 100;
                long firstEightNumbers = ondernemingsnummer / 100;

                long rest = firstEightNumbers % 97;
                long result = 97 - rest;

                if (result != lastTwoNumbers)
                {
                    Console.WriteLine("ondernemingsnummer nummer is niet corect");
                    continue;
                }

                // We arrived at the end. Meaning, modulo 97 passed and the number is valid.
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Het is een corect Ondernemingsnummer");
                Console.ResetColor();
                break;

            }

            







        }
    }
        
}
