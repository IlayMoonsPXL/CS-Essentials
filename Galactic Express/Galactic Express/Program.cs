using System.Globalization;
using System.Net.NetworkInformation;
using System.Text;
namespace Galactic_Express
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Geef u naam in: ");
            string name = Console.ReadLine().Trim();

            Console.Write("Geef u besteming in minstens 3 letters : ");
            string destination = Console.ReadLine().Trim();

           

            if (destination.Length < 3)
            {
                Console.WriteLine("Geen geldige invoer waarden");
                return;
            }
            DateTime travelDate = new DateTime(2000, 01, 01);
            bool isgeldig = false;
            while (!isgeldig)
            {
                Console.Write("Geef u vertrek datum in (yyyy-MM-dd): ");
                if (DateTime.TryParse(Console.ReadLine(), out travelDate))
                {

                    if (DateTime.Today > travelDate)
                    {
                        Console.WriteLine("Incorect antwoord");

                    }
                    else
                    {
                        isgeldig = true;
                    }
                }
                else
                {
                    Console.WriteLine("Dit is geen geldige datum");

                }
            }
           
            Console.Write("Geef u gewicht van u bagage in kilogram: ");
            decimal.TryParse(Console.ReadLine(), out decimal weight);

            TimeSpan daysUntilTravel = travelDate - DateTime.Today;

            DayOfWeek dayOfTravel = travelDate.DayOfWeek;


            Random random = new Random();
            int number1 = random.Next(1, 13);
            int number2 = random.Next(1, 31);
            int number3 = random.Next(1, 6);
            int number4 = random.Next(1000, 9999);

            string code = destination[..3].ToUpper();
            string bookingscode = name.Replace(" ", "-");

            decimal basic = 89.95m;
            decimal baggagefeePerKg = 1.75m;

            decimal totalBaggageFee = weight * baggagefeePerKg;
            decimal totalPrice = basic + totalBaggageFee;

            DateTime retourDate = travelDate.AddDays(7);

            if (travelDate < DateTime.Today.AddDays(7))
            {
                totalPrice += 12.50m;
            }

            StringBuilder bp = new StringBuilder();
            bp.AppendLine(" ==================================                    ");
            bp.AppendLine("          GALACTIC EXPRESS                             ");
            bp.AppendLine("           GALAXY EXPRESS                              ");
            bp.AppendLine(" ==================================                    ");
            bp.AppendLine("                                                       ");
            bp.AppendLine($"reiziger            :{name}                           ");
            bp.AppendLine($"Bestemming          :{destination}                    ");
            bp.AppendLine($"code                :{code}                           ");
            bp.AppendLine($"vertrekdatum        :{travelDate.Date:yyyy-MM-dd}     ");
            bp.AppendLine($"vertrek dag         :{dayOfTravel}                    ");
            bp.AppendLine($"dagen tot vertrek   :{daysUntilTravel.Days} dag(en)   ");
            bp.AppendLine($"                                                      ");
            bp.AppendLine($"Gate                 :{number1}                       ");
            bp.AppendLine($"Stoel                :Rij {number1} - Stoel {number3} ");
            bp.AppendLine($"Controlecode         :{number4}                       ");
            bp.AppendLine($"                                                      ");
            bp.AppendLine($"Bagage               :{weight}                        ");
            bp.AppendLine($"Totale prijs         :€ {totalPrice}                  ");
            bp.AppendLine($"Boekingscode         :{bookingscode}                  ");
            bp.AppendLine($"                                                      ");
            bp.AppendLine($"Retourdatum          :{retourDate.Date:yyyy-MM-dd}    ");

            string resultaten = bp.ToString();
            Console.WriteLine($"{resultaten}");
  







        }
    }
}