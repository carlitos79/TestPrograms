using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class GenericSelectionSort
    {
        public void GenericSelectionSorts<T>(T[] arr) where T : IComparable
        {
            int pos_min, temp;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                pos_min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j].CompareTo(arr[pos_min]) < 0)
                    {
                        pos_min = j;
                    }
                }

                if (pos_min != i)
                {
                    temp = arr[i];
                    arr[i] = arr[pos_min];
                    arr[pos_min] = temp;
                }
            }

            for (int x = 0; x < arr.Length; x++)
            {
                Console.WriteLine(arr[x]);
            }
        }
    }
}
