using NUnit.Framework;
using LeetCodeChallenges;

namespace TestSolutions;

public class LRUCacheTests
{
    private LRUCache _cache;

    [SetUp]
    public void Setup()
    {
        _cache = new LRUCache(2); // Assuming a capacity of 2 for the tests
    }

    [Test]
    public void LRUCache_PutAndGet_ReturnsCorrectValues()
    {
        _cache.Put(1, 1);
        _cache.Put(2, 2);
        Assert.AreEqual(1, _cache.Get(1)); // returns 1
        _cache.Put(3, 3); // evicts key 2
        Assert.AreEqual(-1, _cache.Get(2)); // returns -1 (not found)
        _cache.Put(4, 4); // evicts key 1
        Assert.AreEqual(-1, _cache.Get(1)); // returns -1 (not found)
        Assert.AreEqual(3, _cache.Get(3)); // returns 3
        Assert.AreEqual(4, _cache.Get(4)); // returns 4
    }

    [Test]
    public void LRUCache_ExceedCapacity_EvictsLeastRecentlyUsed()
    {
        _cache.Put(1, 1);
        _cache.Put(2, 2);
        _cache.Put(3, 3); // evicts key 1
        Assert.AreEqual(-1, _cache.Get(1)); // returns -1 (not found)
        Assert.AreEqual(2, _cache.Get(2)); // returns 2
        Assert.AreEqual(3, _cache.Get(3)); // returns 3
    }

    [Test]
    public void LRUCache_UpdateValue_UpdatesCorrectly()
    {
        _cache.Put(1, 1);
        _cache.Put(2, 2);
        _cache.Put(1, 10); // updates value of key 1
        Assert.AreEqual(10, _cache.Get(1)); // returns 10
        Assert.AreEqual(2, _cache.Get(2)); // returns 2
    }

    [Test]
    public void LRUCache_AccessUpdatesOrder_EvictsCorrectly()
    {
        _cache.Put(1, 1);
        _cache.Put(2, 2);
        _cache.Get(1); // access key 1
        _cache.Put(3, 3); // evicts key 2
        Assert.AreEqual(1, _cache.Get(1)); // returns 1
        Assert.AreEqual(-1, _cache.Get(2)); // returns -1 (not found)
        Assert.AreEqual(3, _cache.Get(3)); // returns 3
    }

    [Test]
    public void LRUCache_EmptyCache_ReturnsMinusOne()
    {
        Assert.AreEqual(-1, _cache.Get(1)); // returns -1 (not found)
    }
}