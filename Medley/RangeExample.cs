using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Medley
{
    class RangeExample
    {
        public void PrintSquareRange(int start, int end)
        {
            IEnumerable<int> squares = Enumerable.Range(start, end).Select(num => num * num);

            foreach (var sqr in squares)
            {
                Console.WriteLine(sqr);
            }
        }
    }
}
