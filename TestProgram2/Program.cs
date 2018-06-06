using System;

namespace TestProgram2
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowName nameToPrint = new ShowName();
            nameToPrint.GetName();
            nameToPrint.PrintName();


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
