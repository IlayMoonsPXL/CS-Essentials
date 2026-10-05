namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- normale tarief bedraagt: 9,10 euro");
            Console.WriteLine("- Kortingtarief bedraagt: 8,10 euro");
            Console.WriteLine("- Studententarief bedraagt: 6,90 euro");
            Console.WriteLine();
            double normal = (9.10);
            double discount = (8.10);
            double students = (6.90);
           
            Console.Write("Geef u aantal ticket voor normaal tarief: ");
            string input1 = Console.ReadLine();
            int normal1 = int.Parse(input1);

            Console.Write("Geef u aantal ticket voor kortingtarief: ");
           string input2 = Console.ReadLine();
           int discount1 = int.Parse(input2);

            Console.Write("Geef u aantal ticket voor studententarief: ");
            string input3 = Console.ReadLine();
            int students1 = int.Parse(input3);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"normaal tarief: {normal} x {normal1} = {normal * normal1}" );
            Console.WriteLine($"normaal tarief:{discount} x {discount1} = {discount * discount1}" );
            Console.WriteLine($"normaal tarief:{students} x { students1} = {students * students1}" );
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Uw totaal is:{normal * normal1 + discount * discount1 + students * students1} ");
            Console.ResetColor();
        }
    }
}
