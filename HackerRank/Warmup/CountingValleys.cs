using System;
using System.Linq;

namespace HackerRank.Warmup
{
    public class CountingValleys
    {
        private const char Uphill = 'u';
        private const char Downhill = 'd';

        public static int GetTotalValleys(int n, string s)
        {
            if (n < 2)
                throw new ArgumentOutOfRangeException(nameof(n));
            var steps = s?.Trim().ToLower().Select(step => step).ToArray();
            if (steps.Any(step => !new[] { Uphill, Downhill }.Contains(step)))
                throw new ArgumentOutOfRangeException(nameof(s));

            var currentAltitude = 0;
            var totalValleys = 0;
            for (int i = 0; i < steps.Count(); i++)
            {
                var step = steps.ElementAt(i);
                if (step == Uphill)
                {
                    currentAltitude++;
                }
                else
                {
                    if (currentAltitude == 0)
                        totalValleys++;
                    currentAltitude--;
                }
            }

            return totalValleys;
        }
    }
}
