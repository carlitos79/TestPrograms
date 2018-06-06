using System;
using System.Collections.Generic;
using System.Text;

namespace Medley
{
    class IsEvenOrOdd
    {
        public void IsOddOrEven(int num)
        {
           if (num % 2 == 0)
           {
              Console.WriteLine(num + " is even");
           }
           else
           {
              Console.WriteLine(num + " is odd");
           }               
        }

        public void IsOddOrEvenMain()
        {
            while (true)
            {
                Console.Write("Enter a number: ");
                int input = Console.Read();

                IsOddOrEven(input);
            }           
        }
    }
}
