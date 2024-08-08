using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenges
{
    public class ScoreOfAString
    {
        public static int Solution(string s)
        {
            int total = 0;

            for (int i = 0; i < s.Length - 1; i++)
            {
                total += Math.Abs((int)s[i] - (int)s[i + 1]);
            }

            return total;
        }
    }
}
