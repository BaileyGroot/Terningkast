using System;

namespace Terningkast
{
    class Program
    {
        static void Main(string[] args)
        {
            // Terningkastet 

            Random random = new Random();

            int terningskast = random.Next(1, 7);



            if (terningskast == 1)

            {

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Du slog en etter");

            }

            else if (terningskast == 2)

            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Du slog en to'er");

            }

            if (terningskast == 3)

            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Du slog en Treer");

            }

            else if (terningskast == 4)

            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Du slog en Fire");

            }

            if (terningskast == 5)

            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Du slog en Femmer");

            }

            else if (terningskast == 6)

            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Du slog en sekser");

            }

            //Prevents the program from closing.
            Console.ReadKey();
        }
    }
}
