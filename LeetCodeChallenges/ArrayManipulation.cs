using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenges
{
    public class ArrayManipulation
    {
        public static long arrayManipulation(int n, List<List<int>> queries)
        {
            long max = 0;
            Dictionary<int, long> map = new Dictionary<int, long>();

            foreach (var query in queries)
            {
                int a = query[0] - 1; //initial array index
                int b = query[1] - 1; //final array index
                int k = query[2]; //number to add between the array indexed (inclusive)

                for (; a <= b; a++)
                {
                    if (map.ContainsKey(a))
                        map[a] += k;
                    else
                        map.Add(a, k);

                    if (map[a] > max) max = map[a];
                }
            }

            return max;
        }
    }
}