using NUnit.Framework;
using LeetCodeChallenges;
using System.Collections.Generic;

namespace TestSolutions
{
    public class StringFunctionCalculationTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void StringFunctionCalculationTestCase0()
        {
            Assert.AreEqual(12, StringFunctionCalculation.maxValue(t: "aaaaaa"));
        }

        [Test]
        public void StringFunctionCalculationTestCase1()
        {
            Assert.AreEqual(9, StringFunctionCalculation.maxValue(t: "abcabcddd"));
        }
    }
}