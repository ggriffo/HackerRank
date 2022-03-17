using NUnit.Framework;

namespace TestSolutions
{
    public class LengthOfLongestStringTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Testbbbbbb()
        {
            LeetCodeChallenges.LengthOfLongestString lengthOfLongestString = new LeetCodeChallenges.LengthOfLongestString();
            Assert.AreEqual(lengthOfLongestString.LengthOfLongestSubstring("bbbbb"), 1);
        }

        [Test]
        public void Testabcabcbb()
        {
            LeetCodeChallenges.LengthOfLongestString lengthOfLongestString = new LeetCodeChallenges.LengthOfLongestString();
            Assert.AreEqual(lengthOfLongestString.LengthOfLongestSubstring("abcabcbb"), 3);
        }

        [Test]
        public void Testpwwkew()
        {
            LeetCodeChallenges.LengthOfLongestString lengthOfLongestString = new LeetCodeChallenges.LengthOfLongestString();
            Assert.AreEqual(lengthOfLongestString.LengthOfLongestSubstring("pwwkew"), 3);
        }

        [Test]
        public void Testohvhjdml()
        {
            LeetCodeChallenges.LengthOfLongestString lengthOfLongestString = new LeetCodeChallenges.LengthOfLongestString();
            Assert.AreEqual(lengthOfLongestString.LengthOfLongestSubstring("ohvhjdml"), 6);
        }

        [Test]
        public void TestoSpace()
        {
            LeetCodeChallenges.LengthOfLongestString lengthOfLongestString = new LeetCodeChallenges.LengthOfLongestString();
            Assert.AreEqual(lengthOfLongestString.LengthOfLongestSubstring(" "), 1);
        }

        [Test]
        public void Testdvdf()
        {
            LeetCodeChallenges.LengthOfLongestString lengthOfLongestString = new LeetCodeChallenges.LengthOfLongestString();
            Assert.AreEqual(lengthOfLongestString.LengthOfLongestSubstring("dvdf"), 3);
        }

        [Test]
        public void Testjbpnbwwd()
        {
            LeetCodeChallenges.LengthOfLongestString lengthOfLongestString = new LeetCodeChallenges.LengthOfLongestString();
            Assert.AreEqual(lengthOfLongestString.LengthOfLongestSubstring("jbpnbwwd"), 4);
        }
    }
}
