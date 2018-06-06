using System;

namespace OverrideExample
{
    class Program
    {
        static void Main(string[] args)
        {
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                Console.Write("Enter a number: ");
                int input = Convert.ToInt32(Console.ReadLine());

                Square s = new Square(input);

                Console.WriteLine("Area is: " + s.Area());
            }
        }
    }
}
