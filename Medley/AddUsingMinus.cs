using System;

namespace Medley
{
    class AddUsingMinus
    {
        public int AddWithMinus(int x, int y)
        {
            return x - (-y);
        }

        public void AddWithMinusExe()
        {
            Console.Write("Enter the first number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int z = AddWithMinus(x, y);

            Console.WriteLine("Result: " + z);
        }
    }
}
