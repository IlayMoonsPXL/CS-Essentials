namespace Seconden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secInMin = 60;
            int SecInHours = 3600;

            Console.Write("Geef aantal seconden in: ");
            int.TryParse(Console.ReadLine(), out int totalSeconds);

            int hours = totalSeconds / SecInHours;
            totalSeconds %= SecInHours;

            int min = totalSeconds/ secInMin;
            int sec = totalSeconds % secInMin;

            Console.WriteLine($"UUr:{hours} Min:{min} SEC: {sec}");




        }
    }
}
