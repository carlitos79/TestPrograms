using System;
using System.Collections;
using System.Collections.Generic;

namespace TestProgram
{
    class Program
    {
         static void Main(string[] args)
        {
            Coordinates coords = new Coordinates(10, 15);
            coords.printCoordinates();
            
            Console.WriteLine("Press ESC to stop");
            do
            {
                while (!Console.KeyAvailable)
                {
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }
    }
}
