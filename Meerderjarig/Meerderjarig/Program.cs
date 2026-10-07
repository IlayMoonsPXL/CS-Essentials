namespace Meerderjarig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wat is je geboorte jaar: ");
            if (!int.TryParse(Console.ReadLine(), out int birthYear))
            {
                Console.WriteLine("Geen Geldig jaartal");
                return;
            }          
            int yearToday = DateTime.Today.Year;

            int age = (yearToday - birthYear);

            if (birthYear >= 1900 && birthYear <= yearToday)
             {
                Console.WriteLine(yearToday - birthYear);
             }                        
            else
            {
                Console.WriteLine("Geen geldig Geboorte jaar ");
            }

             if (age >=18)
            {
                Console.WriteLine("U BENT MEERDERJAARIG");
            }
             else
            {
                Console.WriteLine("U BENT MINDERJAARIG");
            }
        }
    }
}
