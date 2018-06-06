using System;

namespace TestProgram5
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal = new B("my dog");
            animal.CanRun();
            animal.CanFly();

            Console.WriteLine('\n' + "Press ESC to stop");
            do
            {
                while (!Console.KeyAvailable)
                {
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
