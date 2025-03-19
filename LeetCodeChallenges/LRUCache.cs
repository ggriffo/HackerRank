using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenges;

public class LRUCache
{
    private Dictionary<int, int> cache;
    private List<int> listOfLastCacheUsed;
    private int cap;

    public LRUCache(int capacity)
    {
        this.cache = new Dictionary<int, int>();
        this.listOfLastCacheUsed = new List<int>();
        this.cap = capacity;
    }

    public int Get(int key)
    {
        if (cache.ContainsKey(key))
        {
            listOfLastCacheUsed.Remove(key);
            listOfLastCacheUsed.Add(key);
            return cache[key];
        }
        else
        {
            return -1;
        }
    }

    public void Put(int key, int value)
    {
        if (!cache.ContainsKey(key))
        {
            if (cache.Count == cap)
            {
                cache.Remove(listOfLastCacheUsed[0]);
                listOfLastCacheUsed.Remove(listOfLastCacheUsed[0]);
            }
            listOfLastCacheUsed.Add(key);
            cache.Add(key, value);
        }
        else
        {
            listOfLastCacheUsed.Remove(key);
            listOfLastCacheUsed.Add(key);
            cache[key] = value;
        }
    }
}