using System;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                Console.Write("Enter a string: ");

                string input = Console.ReadLine();
                string reverse = ReverseString(input);

                IsAnagram(input, reverse);

                Console.WriteLine("Press ESC to quit or ENTER to continue.");
            }
        }

        public static string ReverseString(string s)
        {
            char[] c = s.ToCharArray();
            Array.Reverse(c);

            return new string(c);
        }

        public static void IsAnagram(string a, string b)
        {
            if (a.Equals(b))
            {
                Console.WriteLine(a + " is an anagram.");
            }
            else
            {
                Console.WriteLine(a + " is not an anagram.");
            }
        }
    }
}
