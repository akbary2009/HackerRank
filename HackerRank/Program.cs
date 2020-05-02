using System;
using System.Linq;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            //var result = Warmup.SockMerchant.GetTotalMatchingPairs(9, new[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 });
            //var result = Warmup.JumpingOnTheClouds.GetMinJumps(new[] { 0, 0, 1, 0, 0, 1, 0 });
            //var result = Warmup.CountingValleys.GetTotalValleys(8, "UDDDUDUU");
            //var result = Warmup.RepeatedString.GetNumberOfOccurrences("a", 1_000_000_000_000);

            //var result = Arrays.HourglassSum.GetMaximumSum(new[] {
            //    new[] { 1, 1, 1, 0, 0, 0 },
            //    new[] { 0, 1, 0, 0, 0, 0 },
            //    new[] { 1, 1, 1, 0, 0, 0 },
            //    new[] { 0, 0, 2, 4, 4, 0 },
            //    new[] { 0, 0, 0, 2, 0, 0 },
            //    new[] { 0, 0, 1, 2, 4, 0 },
            //});
            var result = string.Join(' ', Arrays.LeftRotation.Get(new[] { 1, 2, 3, 4, 5 }, 4));

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
