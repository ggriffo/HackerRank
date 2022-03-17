using NUnit.Framework;

namespace TestSolutions
{
    internal class ShortestSubarrayTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(LeetCodeChallenges.ShortestSubarray.Method(new int[] { 1 }, 1), 1);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(LeetCodeChallenges.ShortestSubarray.Method(new int[] { 1, 2 }, 4), -1);
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(LeetCodeChallenges.ShortestSubarray.Method(new int[] { 2, -1, 2 }, 3), 3);
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(LeetCodeChallenges.ShortestSubarray.Method(new int[] { 1, 1, 2, 1, 1, 3 }, 4), 2);
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual(LeetCodeChallenges.ShortestSubarray.Method(new int[] { 77, 19, 35, 10, -14 }, 19), 1);
        }

        [Test]
        public void Test6()
        {
            Assert.AreEqual(LeetCodeChallenges.ShortestSubarray.Method(new int[] { 48, 99, 37, 4, -31 }, 140), 2);
        }
    }
}
