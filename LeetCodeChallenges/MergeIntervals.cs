using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenges
{
    public class MergeIntervals
    {
        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length == 0)
            {
                return new int[0][];
            }
            List<int[]> result = new List<int[]>();
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
            int start = intervals[0][0];
            int end = intervals[0][1];
            for (int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0] <= end)
                {
                    end = Math.Max(end, intervals[i][1]);
                }
                else
                {
                    result.Add(new int[] { start, end });
                    start = intervals[i][0];
                    end = intervals[i][1];
                }
            }
            result.Add(new int[] { start, end });
            return result.ToArray();
        }
    }
}