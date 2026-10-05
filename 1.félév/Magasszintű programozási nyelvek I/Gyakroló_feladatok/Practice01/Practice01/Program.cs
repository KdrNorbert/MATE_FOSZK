using System;

namespace Practice01
{
    public class Program
    {
        static void Main(string[] args)
        {
            ChooseTask();
        }

        private static void GreetUser()
        {
            Console.WriteLine("╔═══════════════════════════════════════════════════╗");
            Console.WriteLine("║                   Üdvözöllek a                    ║");
            Console.WriteLine("║       Magas Szintű Programozási nyelvek I.        ║");
            Console.WriteLine("║                 gyakorlatsoron!                   ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════╝");
        }

        private static void ChooseTask()
        {
            Console.Clear();
            GreetUser();
            Console.WriteLine("\nKérlek válassz az alábbi feladatok közül:");
            Console.WriteLine("1. Téglalap kerület és terület számítás.");
            Console.Write("\nFeladat opció (1-17): ");

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine();

            if (keyInfo.Key == ConsoleKey.D1 || keyInfo.Key == ConsoleKey.NumPad1)
            {
                ShowTask01();
            }
        }

        private static void ShowTask01()
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("=== 1. Feladat: Téglalap kerület és terület ===\n");

                int aSide = ReadPositiveInt("Kérlek add meg a téglalap 'a' oldalát: ");
                int bSide = ReadPositiveInt("Kérlek add meg a téglalap 'b' oldalát: ");

                int area = aSide * bSide;
                int perimeter = 2 * (aSide + bSide);

                Console.WriteLine($"\nA téglalap területe: {area}");
                Console.WriteLine($"A téglalap kerülete: {perimeter}");

                Console.WriteLine("\n[ENTER] - Újrázás | [ESC] - Vissza a főmenübe");

                ConsoleKey pressedKey = Console.ReadKey(true).Key;

                if (pressedKey == ConsoleKey.Escape)
                {
                    running = false;
                    ChooseTask();
                }
                else if (pressedKey != ConsoleKey.Enter)
                {
                    running = false;
                }
            }
        }

        // Segédmetódus a biztonságos, pozitív egész számok beolvasására
        private static int ReadPositiveInt(string prompt)
        {
            int number;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (int.TryParse(input, out number) && number > 0)
                {
                    return number;
                }

                ShowErrorMessage();
            }
        }

        private static void ShowErrorMessage()
        {
            Console.WriteLine("Hibás bemenet! Csak pozitív egész számot adhat meg.\n");
        }
    }
}