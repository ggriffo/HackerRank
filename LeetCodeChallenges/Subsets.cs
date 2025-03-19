using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenges
{
    public class Subsets
    {
        public IList<IList<int>> SubsetsSolution(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            result.Add(new List<int>());
            for (int i = 0; i < nums.Length; i++)
            {
                int count = result.Count;
                for (int j = 0; j < count; j++)
                {
                    List<int> temp = new List<int>(result[j]);
                    temp.Add(nums[i]);
                    result.Add(temp);
                }
            }
            return result;
        }
    }
}