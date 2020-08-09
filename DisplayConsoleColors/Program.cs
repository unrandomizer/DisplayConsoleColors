using System;

namespace DisplayConsoleColors
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = color;
                Console.Write($"\tSweety Black on {color} background");
                Console.ResetColor();
                Console.WriteLine("\n");

                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = color;
                Console.Write($"\tSweety White on {color} background");
                Console.ResetColor();
                Console.WriteLine("\n");

                Console.ForegroundColor = color;
                Console.Write($"\tSweety {color}");
                Console.ResetColor();
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
