using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenges
{
    public class CountTriplets
    {
        public static long CountTripletsSolution(List<long> arr, long r)
        {
            long result = 0;
            Dictionary<long, long> potentialPairs = new Dictionary<long, long>();
            Dictionary<long, long> potentialTriplets = new Dictionary<long, long>();

            foreach (var val in arr)
            {
                // If val completes any triplet, add the count of such triplets to the result
                if (potentialTriplets.ContainsKey(val))
                {
                    result += potentialTriplets[val];
                }

                // If val can be the second element of any triplet, update the potential triplets
                if (potentialPairs.ContainsKey(val))
                {
                    if (potentialTriplets.ContainsKey(val * r))
                    {
                        potentialTriplets[val * r] += potentialPairs[val];
                    }
                    else
                    {
                        potentialTriplets[val * r] = potentialPairs[val];
                    }
                }

                // Every val can be the start of a new triplet
                if (potentialPairs.ContainsKey(val * r))
                {
                    potentialPairs[val * r]++;
                }
                else
                {
                    potentialPairs[val * r] = 1;
                }
            }

            return result;
        }
    }
}