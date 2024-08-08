using LeetCodeChallenges;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolutions
{
    internal class RemoveNthNodeFromEndofListTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            var result = LeetCodeChallenges.RemoveNthFromEnd.Method(head, 4);
            Assert.IsNull(result);
        }

        [Test]
        public void Test2()
        {
            double result = LeetCodeChallenges.MedianOfTwoSortedArrays.Method(new int[] { 1, 2 }, new int[] { 3, 4 });
            Assert.AreEqual(result, 2.5);
        }
    }
}
