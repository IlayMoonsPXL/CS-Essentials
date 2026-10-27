
using System;

namespace oefenenenVoorPe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random random = new Random();
            int totalTicketsSold = 0;
            int keuze = -1;

            while (keuze != 0)
            {
                Console.Clear();
                Console.WriteLine("Welkom bij FunPark");
                Console.WriteLine($"Datum: {DateTime.Today:dd-MM-yyyy}");
                Console.WriteLine($"Totaal aantal tickets verkocht: {totalTicketsSold}");
                Console.WriteLine("__________________________________");
                Console.WriteLine("1) Nieuwe bestelling");
                Console.WriteLine("0) Afsluiten");
                Console.Write("Maak uw keuze: ");

                if (!int.TryParse(Console.ReadLine(), out keuze))
                {
                    ShowText("Ongeldige keuze.", ConsoleColor.Red);
                    Console.ReadKey();
                    keuze = -1;
                    continue;
                }

                if (keuze == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Nieuwe bestelling");
                    Console.WriteLine("__________________________________");

                    DateTime visitDate;
                    bool validDate = false;

                    do
                    {
                        Console.Write("Bezoekdatum (dd-MM-yyyy): ");

                        if (DateTime.TryParse(Console.ReadLine(), out visitDate)
                            && visitDate.Date >= DateTime.Today
                            && visitDate.Date <= DateTime.Today.AddMonths(1))
                        {
                            validDate = true;
                        }
                        else
                        {
                            ShowText(
                                "Ongeldige datum. Kies vandaag of een datum tot maximaal 1 maand vooruit.",
                                ConsoleColor.Red
                            );
                        }

                    } while (!validDate);

                    int ticketCount = 0;

                    do
                    {
                        Console.Write("Aantal tickets: ");

                        if (!int.TryParse(Console.ReadLine(), out ticketCount)
                            || ticketCount <= 0)
                        {
                            ShowText(
                                "Geef een geldig aantal tickets in.",
                                ConsoleColor.Red
                            );
                            ticketCount = 0;
                        }

                    } while (ticketCount <= 0);

                    PlaceOrder(random, visitDate, ticketCount,
                        out int ticketsSold);

                    totalTicketsSold += ticketsSold;

                    Console.WriteLine();
                    Console.WriteLine("Druk op een toets om verder te gaan...");
                    Console.ReadKey();
                }
                else if (keuze != 0)
                {
                    ShowText("Kies 1 of 0.", ConsoleColor.Red);
                    Console.ReadKey();
                }
            }

            Console.WriteLine("Bedankt voor uw bezoek aan FunPark!");
        }

        public static void ShowText(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static decimal CalculatePrice(int age, DateTime date)
        {
            decimal price;

            if (age < 2)
            {
                price = 0M;
            }
            else if (age <= 11)
            {
                price = 15M;
            }
            else if (age < 65)
            {
                price = 25M;
            }
            else
            {
                price = 18M;
            }

            // Controleer of de bezoekdatum in het weekend valt.
            if (date.DayOfWeek == DayOfWeek.Saturday
                || date.DayOfWeek == DayOfWeek.Sunday)
            {
                price = price * 1.20M;
            }

            return price;
        }

        public static int GenerateOrderCode(Random random)
        {
            return random.Next(1000, 10000);
        }

        public static void PlaceOrder(
            Random random,
            DateTime visitDate,
            int ticketCount,
            out int ticketsSold)
        {
            decimal total = 0M;
            ticketsSold = 0;

            for (int i = 1; i <= ticketCount; i++)
            {
                int visitorAge;

                do
                {
                    Console.Write($"Leeftijd van bezoeker {i}: ");

                    if (!int.TryParse(Console.ReadLine(), out visitorAge)
                        || visitorAge < 0 || visitorAge > 120)
                    {
                        ShowText(
                            "Ongeldige ingave. Geef een leeftijd tussen 0 en 120.",
                            ConsoleColor.Red
                        );
                        visitorAge = -1;
                    }

                } while (visitorAge < 0 || visitorAge > 120);

                decimal price = CalculatePrice(visitorAge, visitDate);
                total += price;

                Console.WriteLine($"Ticketprijs: €{price:F2}");
            }

            ticketsSold = ticketCount;

            int orderCode = GenerateOrderCode(random);

            Console.WriteLine();
            Console.WriteLine("==== FUNPARK ====");
            Console.WriteLine($"Bestelcode: FP-{orderCode}");
            Console.WriteLine($"Bezoekdatum: {visitDate:dd-MM-yyyy}");
            Console.WriteLine($"Aantal tickets: {ticketCount}");

            if (visitDate.DayOfWeek == DayOfWeek.Saturday
                || visitDate.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Weekendtoeslag: 20%");
            }

            Console.WriteLine($"Totaal: €{total:F2}");
        }
    }
}
