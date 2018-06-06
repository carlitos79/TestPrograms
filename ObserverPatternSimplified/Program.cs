using System;

namespace ObserverPatternSimplified
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            new BinaryObserver(subject);
            new HexaObserver(subject);
            new OctalObserver(subject);

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.WriteLine("First state change: 15");
                subject.setState(15);
                Console.WriteLine("Second state change: 10");
                subject.setState(10);
            }
        }
    }
}
