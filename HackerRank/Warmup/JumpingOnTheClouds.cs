using System;
using System.Linq;

namespace HackerRank.Warmup
{
    public class JumpingOnTheClouds
    {
        public static int GetMinJumps(int[] c)
        {
            if (c?.Length < 2)
                throw new ArgumentOutOfRangeException(nameof(c));
            if (c.Any(cloud => !new[] { 0, 1 }.Contains(cloud)))
                throw new ArgumentOutOfRangeException(nameof(c));
            if (c.First() != 0 || c.Last() != 0)
                throw new ArgumentOutOfRangeException(nameof(c));

            var requiredSteps = 0;
            var currentCloud = 0;
            while (currentCloud < c.Length - 1)
            {
                var canTakeTwoJumps = (currentCloud + 2 < c.Length) && c.ElementAt(currentCloud + 2) == 0;
                currentCloud += canTakeTwoJumps ? 2 : 1;
                requiredSteps++;
            }

            return requiredSteps;
        }
    }
}
