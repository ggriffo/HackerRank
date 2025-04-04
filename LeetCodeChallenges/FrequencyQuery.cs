using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenges
{
    public class FrequencyQuery
    {
        public static List<int> freqQuery(List<List<int>> queries)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();
            List<int> result = new List<int>();

            foreach (var query in queries)
            {
                int operation = query[0];
                int value = query[1];
                if (operation == 1)
                {
                    if (!freq.ContainsKey(value))
                    {
                        freq.Add(value, 1);
                    }
                    else
                    {
                        freq[value]++;
                    }
                }
                else if (operation == 2)
                {
                    if (!freq.ContainsKey(value))
                    {
                        freq.Add(value, 0);
                    }
                    else
                    {
                        freq[value]--;
                    }
                }
                else if (operation == 3)
                {
                    int count = freq.Count(x => x.Value == value);

                    result.Add(count == 0 ? 0 : 1);
                }
            }

            return result;
        }
    }
}