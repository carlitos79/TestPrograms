using System;

namespace MiddleLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                Console.Write("Enter a string: ");
                string input = Console.ReadLine();

                Console.WriteLine("Result: " + FindMiddleChar(input));

                Console.WriteLine("Press ESC to quit or ENTER to continue");
            }
        }

        public static string FindMiddleChar(string s)
        {
            int middleChar = s.Length / 2;

            if (s.Length > 2 || s.Length < 8)
            {
                if (s.Length % 3 == 0)
                {
                    if (s.Length <= 3)
                    {
                        return s[middleChar].ToString();
                    }
                    return s[middleChar - 1] + s[middleChar].ToString();
                }
                else if (s.Length % 3 != 0)
                {
                    if (s.Length <= 4)
                    {
                        return s[middleChar - 1] + s[middleChar].ToString();
                    }
                    return s[middleChar].ToString();
                }
            }
            return "Error, the input string must contain at least three characters.";
        }
    }
}
