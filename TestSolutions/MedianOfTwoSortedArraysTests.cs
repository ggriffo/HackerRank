using NUnit.Framework;

namespace TestSolutions
{
    internal class MedianOfTwoSortedArraysTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            double result = LeetCodeChallenges.MedianOfTwoSortedArrays.Method(new int[] { 1, 3 }, new int[] { 2 });
            Assert.AreEqual(result, 2);
        }

        [Test]
        public void Test2()
        {
            double result = LeetCodeChallenges.MedianOfTwoSortedArrays.Method(new int[] { 1, 2 }, new int[] { 3, 4 });
            Assert.AreEqual(result, 2.5);
        }
    }
}
