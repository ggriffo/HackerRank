using NUnit.Framework;
using System.Collections.Generic;
using LeetCodeChallenges;

namespace TestSolutions
{
    internal class FrequencyQueryTests
    {
        [Test]
        public void FrequencyQuery_SimpleCase_ReturnsCorrectResults()
        {
            var queries = new List<List<int>>
            {
                new List<int> { 1, 5 },
                new List<int> { 1, 6 },
                new List<int> { 3, 2 },
                new List<int> { 1, 10 },
                new List<int> { 1, 10 },
                new List<int> { 1, 6 },
                new List<int> { 2, 5 },
                new List<int> { 3, 2 }
            };
            var result = FrequencyQuery.freqQuery(queries);
            CollectionAssert.AreEqual(new List<int> { 0, 1 }, result);
        }

        [Test]
        public void FrequencyQuery_NoOperations_ReturnsEmptyList()
        {
            var queries = new List<List<int>>();
            var result = FrequencyQuery.freqQuery(queries);
            CollectionAssert.AreEqual(new List<int>(), result);
        }

        [Test]
        public void FrequencyQuery_MultipleInsertionsAndDeletions_ReturnsCorrectResults()
        {
            var queries = new List<List<int>>
            {
                new List<int> { 1, 3 },
                new List<int> { 1, 3 },
                new List<int> { 2, 3 },
                new List<int> { 3, 1 }
            };
            var result = FrequencyQuery.freqQuery(queries);
            CollectionAssert.AreEqual(new List<int> { 1 }, result);
        }

        [Test]
        public void FrequencyQuery_CheckFrequency_ReturnsCorrectResults()
        {
            var queries = new List<List<int>>
            {
                new List<int> { 1, 3 },
                new List<int> { 1, 3 },
                new List<int> { 1, 3 },
                new List<int> { 3, 3 },
                new List<int> { 2, 3 },
                new List<int> { 3, 2 }
            };
            var result = FrequencyQuery.freqQuery(queries);
            CollectionAssert.AreEqual(new List<int> { 0, 1 }, result);
        }

        [Test]
        public void FrequencyQuery_EmptyAfterDeletions_ReturnsCorrectResults()
        {
            var queries = new List<List<int>>
            {
                new List<int> { 1, 3 },
                new List<int> { 2, 3 },
                new List<int> { 3, 1 }
            };
            var result = FrequencyQuery.freqQuery(queries);
            CollectionAssert.AreEqual(new List<int> { 0 }, result);
        }

        [Test]
        public void FrequencyQuery_LongInput_ReturnsCorrectResults()
        {
            var queries = new List<List<int>>
            {
                new List<int> { 1, 3 },
                new List<int> { 2, 3 },
                new List<int> { 3, 1 }
            };
            var result = FrequencyQuery.freqQuery(queries);
            CollectionAssert.AreEqual(new List<int> { 0 }, result);
        }
    }
}