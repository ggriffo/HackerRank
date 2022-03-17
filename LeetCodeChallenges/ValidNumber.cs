using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenges
{
    public static class ValidNumber
    {
        public static bool Method(string num)
        {
            return double.TryParse(num, out double _);
        }
    }
}
