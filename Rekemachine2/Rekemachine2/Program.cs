namespace Rekemachine2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("geef een eerste getal: ");
            double.TryParse(Console.ReadLine(), out double first);

            Console.Write("geef een tweede getal: ");
            double.TryParse(Console.ReadLine(), out double second);


            Console.Write("geef een bewerking +, -, x of /: ");
            string mathe = Console.ReadLine();

            double add = (first + second);
            double subtract = (first - second);
            double times = (first * second);
            double divide = (first / second);

            switch (mathe)
            {
                case "+":
                    Console.WriteLine($"{first} + {second} ={add}");
                    break;

                case "-":
                    Console.WriteLine($"{first} - {second} ={subtract}"); 
                    break;

                case "x":
                    Console.WriteLine($"{first} x {second} ={times}");
                    break;

                case "/":
                    Console.WriteLine($"{first} / {second} ={divide}");
                    break;
                default:
                    Console.WriteLine("Geen geldige Waarde");
                    return;
            }
             








        }
        }
    }



