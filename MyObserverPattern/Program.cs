using System;

namespace MyObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject_Provider subject = new Subject_Provider();
            subject.NotifyObservers(5);


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
