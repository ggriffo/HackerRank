using NUnit.Framework;

namespace TestSolutions
{
    internal class ValidNumberTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(LeetCodeChallenges.ValidNumber.Method("2"), true);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(LeetCodeChallenges.ValidNumber.Method("0089"), true);
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(LeetCodeChallenges.ValidNumber.Method("+6e-1"), true);
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(LeetCodeChallenges.ValidNumber.Method("53.5e93"), true);
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual(LeetCodeChallenges.ValidNumber.Method("-123.456e789"), true);
        }

        [Test]
        public void Test6()
        {
            Assert.AreEqual(LeetCodeChallenges.ValidNumber.Method("abc"), false);
        }

        [Test]
        public void Test7()
        {
            Assert.AreEqual(LeetCodeChallenges.ValidNumber.Method("1a"), false);
        }

        [Test]
        public void Test8()
        {
            Assert.AreEqual(LeetCodeChallenges.ValidNumber.Method("1e"), false);
        }

        [Test]
        public void Test9()
        {
            Assert.AreEqual(LeetCodeChallenges.ValidNumber.Method("e3"), false);
        }

        [Test]
        public void Test10()
        {
            Assert.AreEqual(LeetCodeChallenges.ValidNumber.Method("99e2.5"), false);
        }

        [Test]
        public void Test11()
        {
            Assert.AreEqual(LeetCodeChallenges.ValidNumber.Method("Infinity"), false);
        }
    }
}
