using System.Diagnostics.Metrics;

namespace PretParkcontrole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welkom in Pretland!");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Naam: ");
            string visitorName = Console.ReadLine();

            if (visitorName == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Geef een geldige Naam in. ");
                Console.ResetColor();
                return; //Dit zorgt er voor dat de applicatie beeindigd wordt
            }
            Console.Write("Leeftijd: ");
            if (!int.TryParse(Console.ReadLine(), out int visitorAge)) //De ! Zort er voor dat als het het niet kan omzetten naar een getal dan gebeurt het volgende 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Geef een geldige leeftijd in. ");
                Console.ResetColor();
                return; //Dit zorgt er voor dat de applicatie beeindigd wordt
            }
            Console.Write("Geef lengte in cm: ");
            if (!int.TryParse(Console.ReadLine(), out int visitorLength)) //De ! Zort er voor dat als het het niet kan omzetten naar een getal dan gebeurt het volgende 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Geef een geldige Lengte in. ");
                Console.ResetColor();
                return; //Dit zorgt er voor dat de applicatie beeindigd wordt
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welke attractie wil je bezoeken");
            Console.WriteLine("  1 Meteor Rush");
            Console.WriteLine("  2 Jungle Splash");
            Console.WriteLine("  3 Haunted Lab");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Maak je keuze: ");
            String attractionchoice = Console.ReadLine();

            int minimumLengt = 0;
            int minimumAge = 0;
            decimal price = 0;
            string attractionName = " ";

            switch (attractionchoice)
            {
                case "1":
                    attractionName = "Meteor Rush";
                    minimumAge = 12;
                    minimumLengt = 140;
                    price = 18m;
                    break;
                case "2":
                    attractionName = "Jungle Splash";
                    minimumAge = 8;
                    minimumLengt = 120;
                    price = 14m;

                    break;
                case "3":
                    attractionName = "Haunted Lab";
                    minimumAge = 16;
                    minimumLengt = 120;
                    price = 11m;

                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Geen Geldige keuzen");
                    Console.ResetColor();
                    return;
                    break;
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Minmum leeftijd : {minimumAge}");
            Console.WriteLine($"Minmum lengte : {minimumLengt}");
            Console.WriteLine($"Basis ticket prijs: {price:C}");

            bool hasAccess;
            string reasonDenied;


            if (visitorAge < minimumAge)
            {
                hasAccess = false;
                reasonDenied = $"De minimum leeftijd voor deze attractie is {minimumAge}";
            }
            if (visitorLength< minimumLengt)
            {
                hasAccess = false;
                reasonDenied = $"De minimum lengte voor deze attractie is {minimumLengt}";

            }
            else
            {
                hasAccess = true;
                reasonDenied = string.Empty;// is het zelfde als ""
            }
            string result = hasAccess == true ? "TOEGELAATEN" : "GEWEIGERD";
            /* string result;
            if (hasAccess == true)
            {
                result = "TOEGELATEN";

            }
            else
            {
                result = "GEWEIGERD"; 
           }*/
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(result);

            if(hasAccess == false)
            {
                Console.ResetColor();
                return;
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welke ticet wil je aan kopen?");
            Console.WriteLine("  1 Standaart ticket");
            Console.WriteLine("  2 Fastlane ticket");
           

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Maak je keuze: ");
            String ticketchoice = Console.ReadLine();


            switch (ticketchoice)
            {
                case "1":
                    if (visitorAge < 12)
                    {
                        price -= 2;
                    }

                    break;

                case "2":
                    price += 5;
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Geen Geldige keuzen");
                    Console.ResetColor();
                    return;
            }
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"Uw naam: {visitorName}");
                    Console.WriteLine($"Gekozen attracie: {attractionName}");
                    Console.WriteLine($"prijs voor ticket: {price:C}");
                    Console.WriteLine($"Have fun");
                    Console.ResetColor();
            }
        }
            
        }
    
