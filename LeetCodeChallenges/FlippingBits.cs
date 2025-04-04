using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenges;

public class FlippingBits
{
    public static long flippingBits(long n)
    {
        return n ^ 0xFFFFFFFF;
    }
}