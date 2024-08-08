using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenges
{
    public class TopKFrequentElements
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            List<int> repsArray = new List<int>();
            int reps = 1;

            List<int> test = nums.ToList();
            var result = test.GroupBy(n => n).Select(c => new { Key = c.Key, total = c.Count() });

            return result.OrderByDescending(x => x.total).Select(x=> x.Key).ToArray()[0..k].ToArray();
                //.Where(x => x.total == k).Select(x => x.Key).ToArray();
        }
    }
}
