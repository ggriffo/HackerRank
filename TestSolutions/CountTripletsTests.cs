using NUnit.Framework;
using System.Collections.Generic;
using LeetCodeChallenges;

namespace TestSolutions
{
    internal class CountTripletsTests
    {
        [Test]
        public void CountTriplets_SimpleCase_ReturnsCorrectCount()
        {
            var arr = new List<long> { 1, 2, 2, 4 };
            long r = 2;
            long result = CountTriplets.CountTripletsSolution(arr, r);
            Assert.AreEqual(2, result); // Triplets: (1, 2, 4) and (2, 2, 4)
        }

        [Test]
        public void CountTriplets_NoTriplets_ReturnsZero()
        {
            var arr = new List<long> { 1, 3, 9, 27 };
            long r = 2;
            long result = CountTriplets.CountTripletsSolution(arr, r);
            Assert.AreEqual(0, result); // No triplets with ratio 2
        }

        [Test]
        public void CountTriplets_MultipleTriplets_ReturnsCorrectCount()
        {
            var arr = new List<long> { 1, 3, 9, 9, 27, 81 };
            long r = 3;
            long result = CountTriplets.CountTripletsSolution(arr, r);
            Assert.AreEqual(4, result); // Triplets: (1, 3, 9), (1, 3, 9), (3, 9, 27), (9, 27, 81)
        }

        [Test]
        public void CountTriplets_SameElements_ReturnsCorrectCount()
        {
            var arr = new List<long> { 1, 1, 1, 1 };
            long r = 1;
            long result = CountTriplets.CountTripletsSolution(arr, r);
            Assert.AreEqual(4, result); // Triplets: (1, 1, 1) four times
        }

        [Test]
        public void CountTriplets_LargeNumbers_ReturnsCorrectCount()
        {
            var arr = new List<long> { 1000000000, 1000000000, 1000000000, 1000000000 };
            long r = 1;
            long result = CountTriplets.CountTripletsSolution(arr, r);
            Assert.AreEqual(4, result); // Triplets: (1000000000, 1000000000, 1000000000) four times
        }

        [Test]
        public void CountTriplets_EmptyArray_ReturnsZero()
        {
            var arr = new List<long> { };
            long r = 2;
            long result = CountTriplets.CountTripletsSolution(arr, r);
            Assert.AreEqual(0, result); // No elements, no triplets
        }
    }
}