namespace Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef temperatuur in °F: ");
            double.TryParse(Console.ReadLine(), out double fahrenheit);

          
           double celcius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"de graden in °C: { celcius:F2} ");
            //:F2 voor afteroden na 2 getallen na de coma 
           
        }
    }
}
