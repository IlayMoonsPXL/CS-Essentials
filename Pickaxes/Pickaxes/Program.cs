namespace Pickaxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int durebilityStone = 131;
            int durebilityIron = 250;
            int durebilityDiamond = 1561; 
            int durebilityNetherite = 2031; 

            Console.Write("Hoeveel blokken wil je mijnen?: ");

            //string input = Console.ReadLine();
           //int.TryParse(input, out int blocks);

            int.TryParse(Console.ReadLine(),out int blocks);

            durebilityStone = durebilityStone - blocks;
            durebilityIron = durebilityIron - blocks;
            durebilityDiamond = durebilityDiamond - blocks;
            durebilityNetherite = durebilityNetherite - blocks;

            // durebilityNetherite -= blocks;
            Console.WriteLine();
            Console.WriteLine($"Stone: {durebilityStone} durability over");
            Console.WriteLine($"Iron: {durebilityIron} durability over");
            Console.WriteLine($"Diamond: {durebilityDiamond} durability over");
            Console.WriteLine($"Netherite: {durebilityNetherite} durability over");
            Console.WriteLine();
            Console.Write("Maak je eigen took .. geef een naam: ");
            string name = Console.ReadLine();

            Console.Write("wat is de maximale durability");
            int.TryParse(Console.ReadLine(), out int durability);
            Console.WriteLine();

            Console.WriteLine($"je tool {name} heeft nog {durability - blocks}: ");
                

            




        }
    }
}
