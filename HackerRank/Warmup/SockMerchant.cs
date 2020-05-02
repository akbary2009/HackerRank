using System;
using System.Linq;

namespace HackerRank.Warmup
{
    public class SockMerchant
    {
        public static int GetTotalMatchingPairs(int n, int[] ar)
        {
            if (ar?.Length != n)
                throw new ArgumentException($"There aren't enough colors.", nameof(ar));

            var totalMatches = ar
                .GroupBy(color => color)
                .Select(color => color.Count())
                .Select(pairs => pairs / 2)
                .Sum();
            return totalMatches;
        }
    }
}
