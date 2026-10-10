namespace Galactic_Express
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef u naam in: ");
            string name = Console.ReadLine();

            Console.Write("Geef u besteming in minnstens 3letters : ");
            string destination = Console.ReadLine().Trim().ToUpper() ;
            if(destination.Length < 3) 
            {
                Console.WriteLine("Geen geldige invoer waarden");
                return;
            }
            Console.Write("Geef u vertrek datum in (yyyy-MM-dd): ");
            DateTime.TryParse(Console.ReadLine(), out DateTime travelDate);

            Console.Write("Geef u gewicht van u bagage in kilogram");
            double.TryParse(Console.ReadLine(), out double weight);

            string code = destination[..3].ToUpper();
            string bookingscode = name.Replace(" ", "-");

            Console.WriteLine($"uw naam is: {name}");
            Console.WriteLine($"uw besteming is: {code}");
            Console.WriteLine($"uw besemingscode is: {bookingscode}");
            Console.WriteLine("==================================");
            Console.WriteLine("         GALAXY EXPRESS            ");
            Console.WriteLine("===================================");


            TimeSpan daysUntilTravel = travelDate - DateTime.Today;

            DayOfWeek dayOfTravel = travelDate.DayOfWeek;

            Console.WriteLine($"{dayOfTravel}");


        }
    }
}