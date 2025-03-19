using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenges
{
    internal class TwoSum
    {
        public int[] TwoSumSolution(int[] nums, int target)
        {
            List<int> result = new List<int>();
            var filtered = nums.ToList();

            for (int i = 0; i < filtered.Count; i++)
            {
                int num1 = filtered[i];
                int num2 = filtered.Find(x => x == (target - num1));
                int index2 = filtered.FindIndex(x => x == (target - num1));
                if (index2 != -1 && index2 != i)
                {
                    if (!result.Contains(i))
                    {
                        result.Add(i);
                    }
                    if (!result.Contains(index2))
                    {
                        result.Add(index2);
                    }
                }
            }

            return result.ToArray();
        }
    }
}