using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();

            words.Add("love");
            words.Add("patience");
            words.Add("hope");
            words.Add("passion");
            words.Add("virtue");

            var x = words.Any(w => w.Contains("patience"));
            Console.WriteLine(x);

            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);

            var y = numbers.Any(n => n.Equals(5));
            Console.WriteLine(y);

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
