using System;

namespace Medley
{
    class CheckIfVowel
    {
        public bool IsVowel(char ch)
        {
            ch = Char.ToLower(ch);

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void IsVowelExe()
        {
            Console.Write("Enter a vowel: ");
            char c = Console.ReadKey().KeyChar;

            if (IsVowel(c))
            {
                Console.WriteLine(c + " is a vowel");
            }
            else
            {
                Console.WriteLine(c + " is not a vowel");
            }
        }
    }
}
