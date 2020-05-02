using System;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            //var result = Warmup.SockMerchant.GetTotalMatchingPairs(9, new[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 });
            var result = Warmup.JumpingOnTheClouds.GetMinJumps(new[] { 0, 0, 1, 0, 0, 1, 0 });
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
