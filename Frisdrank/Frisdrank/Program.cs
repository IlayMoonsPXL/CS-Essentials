using System.Threading.Channels;

namespace Frisdrank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            double payed = 2.00;
            
            Console.WriteLine("prijs van de ge kozen frisdrank:");
            double.TryParse(Console.ReadLine(), out double totalPrice);

            double change = payed - totalPrice;
            
            int cent = (int)(change * 100);

            int oneEuro = cent/ 100;
            cent %= 100;

            int fiftyCent = cent / 50;
            cent %= 50;

            int twenty = cent/ 20;
            cent %= 20;

            int ten = cent / 10;
            cent %= 10;

            int five = cent / 5;
            cent %= 5;

            int two = cent / 2;
            cent %= 2;

            int one = cent / 1;
            cent %= 1;

            Console.WriteLine($"munten van 1: €{oneEuro} ");
            Console.WriteLine($"munten van 0,50: €{fiftyCent} ");
            Console.WriteLine($"munten van 0,20: €{twenty} ");
            Console.WriteLine($"munten van 0,10: €{ten} ");
            Console.WriteLine($"munten van 0,05: €{five} ");
            Console.WriteLine($"munten van 0,02: €{two} ");
            Console.WriteLine($"munten van 0,01: €{one} ");




            //double price = 12.3456;
            //Console.WriteLine($"Price: {price.ToString("c")}"); // Price: € 12,35
            // of
            // Console.WriteLine($"Price: {price:c}"); // Price: € 12,35
        }
    }
}
