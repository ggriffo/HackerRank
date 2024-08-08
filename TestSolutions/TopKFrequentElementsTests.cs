using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolutions
{
    internal class TopKFrequentElementsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Testbbbbbb()
        {
            LeetCodeChallenges.TopKFrequentElements lengthOfLongestString = new LeetCodeChallenges.TopKFrequentElements();
            lengthOfLongestString.TopKFrequent(new int[] {1, 1, 1, 2, 2, 3 }, 2);
        }
    }
}
