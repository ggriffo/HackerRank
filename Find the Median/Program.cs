using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_the_Median
{
    class Program
    {
        static int findMedian(int[] arr)
        {
            List<int> median = arr.ToList();
            median.Sort();

            return median[median.Count / 2];
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int result = findMedian(arr);

            Console.WriteLine(result);
        }
    }
}
