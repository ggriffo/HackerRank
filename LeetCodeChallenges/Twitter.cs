using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenges;

public class Twitter
{
    private Dictionary<int, HashSet<int>> followers;
    private Dictionary<int, List<Tweet>> tweets;

    public Twitter()
    {
        followers = new Dictionary<int, HashSet<int>>();
        tweets = new Dictionary<int, List<Tweet>>();
    }

    public void PostTweet(int userId, int tweetId)
    {
        if (!tweets.ContainsKey(userId))
        {
            tweets[userId] = new List<Tweet>();
        }
        tweets[userId].Add(new Tweet { Id = tweetId, Time = DateTime.Now });
    }

    public IList<int> GetNewsFeed(int userId)
    {
        var result = new List<int>();

        var followees = followers.ContainsKey(userId) ? followers[userId] : new HashSet<int>();
        followees.Add(userId);

        var feedTweets = new List<Tweet>();
        foreach (var followee in followees)
        {
            if (this.tweets.ContainsKey(followee))
            {
                feedTweets.AddRange(this.tweets[followee]);
            }
        }
        feedTweets = feedTweets.OrderByDescending(t => t.Time).Take(10).ToList();

        return feedTweets.Select(x => x.Id).ToArray();
    }

    public void Follow(int followerId, int followeeId)
    {
        if (followers.ContainsKey(followerId))
        {
            followers[followerId].Add(followeeId);
        }
        else
        {
            followers.Add(followerId, new HashSet<int>() { followeeId });
        }
    }

    public void Unfollow(int followerId, int followeeId)
    {
        if (followers.ContainsKey(followerId))
        {
            followers[followerId].Remove(followeeId);
        }
    }

    private class Tweet
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
    }
}