namespace Leveringskosten
{
    internal class Program
    {
        static void Main(string[] args)
        {


            decimal priceProduct = 0;
            int productQuantity = 0;
            int btw = 0;

            while (true)
            {
                Console.WriteLine("Geef de prijs van een product: ");
                if (decimal.TryParse(Console.ReadLine(), out priceProduct))
                {
                    break;
                }
            }
            
               
                while (true)
                {
                    Console.WriteLine("Hoeveel wilt u hier van: ");
                    if (int.TryParse(Console.ReadLine(), out productQuantity))
                    {
                        break;
                    }

                }


                while (true)
                {
                    Console.WriteLine("Geef het BTW % in: ");
                    Console.WriteLine("6%");
                    Console.WriteLine("12%");
                    Console.WriteLine("21%");
                    if (int.TryParse(Console.ReadLine(), out btw))
                    {
                        break;
                    }

                }


                decimal deliveryCosts = 0;
                decimal subtotaal = priceProduct * productQuantity;
                decimal totaal = 0;

                if (productQuantity >= 10)
                {
                    subtotaal -= (subtotaal / 100) * 5;
                }
                if (subtotaal < 50)
                {
                    deliveryCosts = 15;
                }
                if (subtotaal >= 50 && subtotaal < 70)
                {
                    deliveryCosts = 12;
                }
                if (subtotaal >= 70)
                {
                    deliveryCosts = 10;
                }


                if (btw == 6)
                {
                    totaal = (subtotaal + deliveryCosts) * 1.06m;
                }
                if (btw == 12)
                {
                    totaal = (subtotaal + deliveryCosts) * 1.12m;
                }
                if (btw == 21)
                {
                    totaal = (subtotaal + deliveryCosts) * 1.21m;
                }
                Console.WriteLine($" het totaal inclusief leveringskosten = {totaal}");

            


        }
    }
}

