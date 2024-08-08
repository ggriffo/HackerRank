using NUnit.Framework;

namespace TestSolutions
{
    internal class ScoreOfAStringTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(LeetCodeChallenges.ScoreOfAString.Solution("hello"), 13);
        }
    }
}
