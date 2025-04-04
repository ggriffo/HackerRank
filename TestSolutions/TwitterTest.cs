using NUnit.Framework;
using LeetCodeChallenges;
using System.Collections.Generic;

namespace TestSolutions
{
    public class TwitterTest
    {
        private Twitter twitter;

        [SetUp]
        public void Setup()
        {
            twitter = new Twitter();
        }

        [Test]
        public void RobotClashTest()
        {
            List<int> key = new List<int> { 5, 10, 20, 10, 15, 5 };
            int maxChange = 2;
            int result = RobotClash.findVulnerabilityFactor(key, maxChange);
            Assert.AreEqual(2, result);
            // result should be 2 (subarray [10, 20] or [20, 10] can be modified to have GCD > 1 with two changes)
        }

        [Test]
        public void TwitterTestCase0()
        {
            twitter.PostTweet(1, 5);
            twitter.PostTweet(1, 3);
            var result = twitter.GetNewsFeed(1);
            Assert.AreEqual(3, result[0]);
            Assert.AreEqual(5, result[1]);
        }

        [Test]
        public void TwitterTestCase1()
        {
            twitter.PostTweet(1, 5);
            twitter.Follow(1, 2);
            twitter.PostTweet(2, 6);
            var result = twitter.GetNewsFeed(1);
            Assert.AreEqual(6, result[0]);
            Assert.AreEqual(5, result[1]);
        }

        [Test]
        public void TwitterTestCase2()
        {
            twitter.PostTweet(1, 5);
            twitter.Follow(1, 2);
            twitter.PostTweet(2, 6);
            twitter.Unfollow(1, 2);
            var result = twitter.GetNewsFeed(1);
            Assert.AreEqual(5, result[0]);
            Assert.AreEqual(1, result.Count);
        }

        [Test]
        public void TwitterTestCase3()
        {
            twitter.PostTweet(1, 5);
            twitter.PostTweet(1, 3);
            twitter.PostTweet(1, 101);
            twitter.PostTweet(1, 13);
            twitter.PostTweet(1, 10);
            twitter.PostTweet(1, 2);
            twitter.PostTweet(1, 94);
            twitter.PostTweet(1, 505);
            twitter.PostTweet(1, 333);
            twitter.PostTweet(1, 22);
            twitter.PostTweet(1, 11);
            var result = twitter.GetNewsFeed(1);
            Assert.AreEqual(10, result.Count);
            Assert.AreEqual(11, result[0]);
            Assert.AreEqual(22, result[1]);
            Assert.AreEqual(333, result[2]);
            Assert.AreEqual(505, result[3]);
            Assert.AreEqual(94, result[4]);
            Assert.AreEqual(2, result[5]);
            Assert.AreEqual(10, result[6]);
            Assert.AreEqual(13, result[7]);
            Assert.AreEqual(101, result[8]);
            Assert.AreEqual(3, result[9]);
        }

        [Test]
        public void TwitterTestCase4()
        {
            twitter.PostTweet(1, 5);
            twitter.Follow(1, 2);
            twitter.PostTweet(2, 6);
            twitter.Follow(2, 1);
            var result = twitter.GetNewsFeed(2);
            Assert.AreEqual(6, result[0]);
            Assert.AreEqual(5, result[1]);
        }

        [Test]
        public void TwitterTestCase5()
        {
            twitter.PostTweet(1, 5);
            twitter.Follow(1, 2);
            twitter.PostTweet(2, 6);
            twitter.Follow(2, 1);
            twitter.PostTweet(2, 7);
            var result = twitter.GetNewsFeed(1);
            Assert.AreEqual(7, result[0]);
            Assert.AreEqual(6, result[1]);
            Assert.AreEqual(5, result[2]);
        }
    }
}