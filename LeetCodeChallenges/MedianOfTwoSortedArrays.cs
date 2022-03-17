using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenges
{
    public static class MedianOfTwoSortedArrays
    {
        public static double Method(int[] nums1, int[] nums2)
        {
            var newArray = nums1.Concat(nums2).ToArray();

            Array.Sort(newArray);

            int middle = newArray.Length % 2;
            if (middle == 1)
            {
                return newArray[newArray.Length / 2];
            }
            else
            {
                return (newArray[(newArray.Length-1)/2] + newArray[(newArray.Length + 1) / 2])/2.0;
            }
        }
    }
}
