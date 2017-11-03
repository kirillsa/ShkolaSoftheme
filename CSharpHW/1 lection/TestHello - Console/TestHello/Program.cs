using System;

namespace TestHello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}