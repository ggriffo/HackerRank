using System;
using System.Collections.Generic;
using System.Linq;

namespace Counting_Sort_1
{
    class Program
    {
        static int[] countingSort(int[] arr)
        {
            List<int> timesAppear = new List<int>();
            List<int> array = arr.ToList();

            for (int i = 0; i < 100; i++)
            {
                timesAppear.Add(array.FindAll(x => x == i).Count);
            }

            return timesAppear.ToArray();
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int[] result = countingSort(arr);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
