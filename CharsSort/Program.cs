using System;
using System.Linq;

namespace CharsSort
{
    class Program
    {
        static void Main(string[] args)
        {
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                Console.Write("Enter a string: ");

                string input = Console.ReadLine();
                string result = SorterCleaner(input);

                Console.WriteLine(result);

                Console.WriteLine("Press ESC to quit or ENTER to continue");
            }
        }

        public static string SorterCleaner(string s)
        {
            s = s.ToLower();
            string p = new string(s.Where(c => !char.IsPunctuation(c)).ToArray());
            string r = String.Concat(p.OrderBy(c => c));

            return r;
        }
    }
}
