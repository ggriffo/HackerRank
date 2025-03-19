using NUnit.Framework;
using LeetCodeChallenges;

namespace TestSolutions;

public class CoinChangeTests
{
    private CoinChange _coinChange;

    [SetUp]
    public void Setup()
    {
        _coinChange = new CoinChange();
    }

    [Test]
    public void CoinChange_AmountZero_ReturnsZero()
    {
        var result = _coinChange.CoinChangeSolution(new int[] { 1, 2, 5 }, 0);
        Assert.AreEqual(0, result);
    }

    [Test]
    public void CoinChange_SingleCoinEqualToAmount_ReturnsOne()
    {
        var result = _coinChange.CoinChangeSolution(new int[] { 1, 2, 5 }, 5);
        Assert.AreEqual(1, result);
    }

    [Test]
    public void CoinChange_MultipleCoins_ReturnsMinimumCoins()
    {
        var result = _coinChange.CoinChangeSolution(new int[] { 1, 2, 5, 6 }, 11);
        Assert.AreEqual(2, result); // 11 = 5 + 5 + 1
    }

    [Test]
    public void CoinChange_AmountNotPossible_ReturnsMinusOne()
    {
        var result = _coinChange.CoinChangeSolution(new int[] { 2 }, 3);
        Assert.AreEqual(-1, result);
    }

    [Test]
    public void CoinChange_LargeAmount_ReturnsMinimumCoins()
    {
        var result = _coinChange.CoinChangeSolution(new int[] { 1, 2, 5 }, 100);
        Assert.AreEqual(20, result); // 100 = 5 * 20
    }

    [Test]
    public void CoinChange_NoCoins_ReturnsMinusOne()
    {
        var result = _coinChange.CoinChangeSolution(new int[] { }, 7);
        Assert.AreEqual(-1, result);
    }
}