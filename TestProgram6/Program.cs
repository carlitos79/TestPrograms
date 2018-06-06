using System;

namespace TestProgram6
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = new B();
            Console.WriteLine(value.GetValueFromParent());            

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
