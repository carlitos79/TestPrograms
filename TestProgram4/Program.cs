using System;
using System.Collections.Generic;

namespace TestProgram4
{
    class Program
    {
        static void Main(string[] args)
        {
            string origString = "Juan03,Pedro04,Raul01,Marcos05,Jose02";

            var splitOrigString = origString.Split('0', ',');            

            List<int> ids = new List<int>();
            List<string> names = new List<string>();

            List<Tuple<string, int>> tuples = new List<Tuple<string, int>>();

            for (int i = 0; i < splitOrigString.Length; i += 2)
            {
                names.Add(splitOrigString[i]);
            }

            for (int i = 1; i < splitOrigString.Length; i += 2)
            {
                ids.Add(Int32.Parse(splitOrigString[i]));
            }

            for (int i = 0; i < splitOrigString.Length / 2; i++)
            {
                tuples.Add(Tuple.Create(names[i], ids[i]));
            }

            tuples.Sort((x, y) => x.Item2.CompareTo(y.Item2));

            //foreach (var x in tuples)
            //{
            //    Console.WriteLine(x);
            //}

            var lastIndex = names.Count;
            Console.WriteLine("The person with the highest index is "  + tuples[lastIndex - 1].Item1);

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
