using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericSelectionSort s = new GenericSelectionSort();

            int[] x = { 5, 4, 3, 2, 1 };

            char[] z = {'u', 'o', 'i', 'e', 'a' };

            s.GenericSelectionSorts(z);

            Console.ReadKey();
        }
    }
}
