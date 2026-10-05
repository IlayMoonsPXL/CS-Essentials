namespace Rkenmaschine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("eerste geheel getal: ");
            string input = Console.ReadLine();
            int number1 = int.Parse(input);

            Console.Write("tweede geheel getal: ");
            string input1 = Console.ReadLine();
            int number2 = int.Parse(input1);

            Console.WriteLine($"resultaat: {number1} + {number2} = {number1 + number2}");
        }
    }
}
