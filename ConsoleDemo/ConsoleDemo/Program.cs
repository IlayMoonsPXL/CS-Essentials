namespace ConsoleDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //regel 1 vraagt voor gegevens
            //Reglel 2 vraagt naam en zocht dat de gebruiker kan typen 
            //Regel 3 de console leest de ingegeven input (name:)
            Console.WriteLine("gegevens aub....");
            Console.Write("name: ");
            string name = Console.ReadLine();

            //regel 4 vraagt voor leeftijd en zorgt dat de gebruiker kan typen
            // regel 5 De console leest de ingegeven input (Leeftijd:)

            Console.Write("Leeftijd: ");
            string input = Console.ReadLine();
            //convert input naar getal en bewaar getal in variabele (variabel= opslag doos)
            int age = int.Parse(input);

            //Rege 7 vraagt
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("welkom: " + name);
            Console.WriteLine("Uw leeftijd is: " + age);
            Console.ResetColor();

            Console.WriteLine("Druk op eender welke toets om verder te gaan");

            Console.ReadKey(true);

            

        }
    }
}
