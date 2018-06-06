using System;
using System.Collections.Generic;
using System.Linq;

namespace Medley
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddUsingMinus add = new AddUsingMinus();
            //add.AddWithMinusExe();

            CheckIfVowel ch = new CheckIfVowel();
            ch.IsVowelExe();

            Console.Write("\n" + "Press any key to exit ");
            Console.ReadKey();
        }
    }
}
