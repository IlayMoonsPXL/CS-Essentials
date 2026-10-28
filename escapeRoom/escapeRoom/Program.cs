
using System;

namespace escapeRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowTitle();
            ShowIntro();
            StartGame();
        }

        static void StartGame()
        {
            int timeLeft = 15;
            bool keypadSolved = false;
            bool riddleSolved = false;
            bool escaped = false;
            int choice = 0;

            do
            {
                ShowTitle();
                ShowStatus(timeLeft, keypadSolved, riddleSolved);
                ShowMenu();
                choice = ReadAction();

                switch (choice)
                {
                    case 1:
                        if (!keypadSolved)
                        {
                            keypadSolved = TryKeypad();

                            if (!keypadSolved)
                            {
                                timeLeft = ApplyPenalty(timeLeft, 2);
                            }
                        }
                        else
                        {
                            ShowColoredText("Keypad already solved!",
                                ConsoleColor.Green, true);
                        }
                        break;

                    case 2:
                        if (!riddleSolved)
                        {
                            riddleSolved = SolveRiddle();

                            if (!riddleSolved)
                            {
                                timeLeft = ApplyPenalty(timeLeft, 2);
                            }
                        }
                        else
                        {
                            ShowColoredText("Riddle already solved!",
                                ConsoleColor.Green, true);
                        }
                        break;

                    case 3:
                        escaped = FinalDoor(riddleSolved, keypadSolved);
                        break;

                    case 9:
                        ShowColoredText("You gave up!",
                            ConsoleColor.Red, true);
                        break;

                    default:
                        ShowColoredText("Invalid choice.",
                            ConsoleColor.Red, true);
                        break;
                }

                if (timeLeft <= 0)
                {
                    ShowColoredText("Time is up! Game over!",
                        ConsoleColor.Red, true);
                    break;
                }
                else if (escaped)
                {
                    ShowColoredText("Congratulations! You escaped!",
                        ConsoleColor.Green, true);
                }

                if (!escaped && choice != 9)
                {
                    Console.WriteLine("\nPress Enter to continue...");
                    Console.ReadLine();
                }

            } while (choice != 9 && !escaped);
        }

        static void ShowTitle()
        {
            Console.Clear();
            Console.WriteLine(@"
                 ___                         ___
                | __|___ __ __ _ _ __  ___  | _ \___  ___ _ __
                | _|(_-</ _/ _` | '_ \/ -_) |   / _ \/ _ \ '  \
                |___/__/\__\__,_| .__/\___| |_|_\___/\___/_|_|_|
                                |_|
                ================================================
            ");
        }

        static void ShowIntro()
        {
            Console.WriteLine("Solve the puzzles before time runs out!");
            Console.WriteLine("Press enter to start your adventure...");
            Console.ReadLine();
        }

        static void ShowColoredText(string text, ConsoleColor color,
            bool appendLine = false)
        {
            Console.ForegroundColor = color;
            Console.Write(text);

            if (appendLine)
            {
                Console.WriteLine();
            }

            Console.ResetColor();
        }

        static void ShowStatus(int timeLeft, bool keypadSolved,
            bool riddleSolved)
        {
            ShowColoredText($"Time left: {timeLeft} minutes",
                ConsoleColor.Blue, true);

            ShowColoredText($"Keypad: {(keypadSolved ? "solved" : "unsolved")}",
                ConsoleColor.Blue, true);

            ShowColoredText($"Riddle: {(riddleSolved ? "solved" : "unsolved")}",
                ConsoleColor.Blue, true);

            Console.WriteLine();
        }

        static void ShowMenu()
        {
            ShowColoredText("Choose an action:", ConsoleColor.White, true);
            ShowColoredText("  1) Try keypad", ConsoleColor.White, true);
            ShowColoredText("  2) Solve riddle", ConsoleColor.White, true);
            ShowColoredText("  3) Open final door", ConsoleColor.White, true);
            ShowColoredText("  9) Give up", ConsoleColor.White, true);
            ShowColoredText("Your choice: ", ConsoleColor.White, false);
        }

        static int ReadAction()
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice))
            {
                return choice;
            }

            return -1;
        }

        static int ApplyPenalty(int timeLeft, int penalty)
        {
            int newTime = timeLeft - penalty;

            if (newTime < 0)
            {
                newTime = 0;
            }

            ShowColoredText($"Time penalty: -{penalty} minute(s).",
                ConsoleColor.DarkYellow, true);

            return newTime;
        }

        static bool TryKeypad()
        {
            ShowColoredText("Enter 3-digit keypad code: ",
                ConsoleColor.Magenta, false);

            string input = Console.ReadLine();

            if (!int.TryParse(input, out int code))
            {
                ShowColoredText("Invalid code (not a number).",
                    ConsoleColor.DarkRed, true);
                return false;
            }
            else if (input.Equals("314"))
            {
                ShowColoredText("Keypad unlocked!",
                    ConsoleColor.Green, true);
                return true;
            }
            else
            {
                ShowColoredText("Wrong code.",
                    ConsoleColor.Red, true);
                return false;
            }
        }

        static bool SolveRiddle()
        {
            ShowColoredText("Riddle: Speak friend and enter...",
                ConsoleColor.Magenta, true);

            ShowColoredText("Type the secret word: ",
                ConsoleColor.Magenta);

            string answer = Console.ReadLine();

            if (answer.Trim().Equals("open-sesame",
                StringComparison.OrdinalIgnoreCase))
            {
                ShowColoredText("The wall slides aside.",
                    ConsoleColor.Green, true);
                return true;
            }
            else
            {
                ShowColoredText("The wall remains silent.",
                    ConsoleColor.Red, true);
                return false;
            }
        }

        public static bool FinalDoor(bool riddleSolved, bool keypadSolved)
        {
            if (keypadSolved && riddleSolved)
            {
                ShowColoredText("Final number (1..5): ",
                    ConsoleColor.Magenta);

                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    if (number == 3)
                    {
                        ShowColoredText("The final door opens!",
                            ConsoleColor.Green, true);
                        return true;
                    }
                    else
                    {
                        ShowColoredText("Wrong number!",
                            ConsoleColor.Red, true);
                        return false;
                    }
                }
                else
                {
                    ShowColoredText("Invalid number!",
                        ConsoleColor.Red, true);
                    return false;
                }
            }
            else
            {
                ShowColoredText(
                    "The final door won't budge. Solve the other puzzles first.",
                    ConsoleColor.Red, true);
                return false;
            }
        }
    }
}
