using System;

namespace SeveralTextTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "AB";
            string str2 = "ABCDEFGHIJKL";

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                CompareChars(str1, str2);
            }            
        }

        public static void CompareChars(string str1, string str2)
        {
            int length = str2.Length - 1;

            PrintEquality(str1, str2);

            for (int i = length; i > 0; i--)
            {
                string newStr = str2.Remove(i);

                PrintEquality(str1, newStr);
            }
        }

        public static void PrintEquality(string str1, string str2)
        {
            if (str1.Equals(str2))
            {
                Console.WriteLine(str1 + " and " + str2 + " are equal");
            }
            else
            {
                Console.WriteLine(str1 + " and " + str2 + " are not equal");
            }           
        }
    }
}
