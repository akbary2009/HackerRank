using System;

namespace HackerRank.Arrays
{
    public class NewYearChaos
    {
        private const string NotPossible = "Too chaotic";

        public static void MinimumBribes(int[] q)
        {
            var numberOfBribes = 0;
            for (int i = q.Length - 1; i >= 0; i--)
            {
                var actualPerson = q[i];
                var expectedPerson = (i + 1);
                var diff = actualPerson - expectedPerson;
                if (diff > 2)
                {
                    Console.WriteLine(NotPossible);
                    return;
                }

                for (int j = Math.Max(0, actualPerson - 2); j < i; j++)
                {
                    if (actualPerson < q[j]) numberOfBribes++;
                }
            }

            //for (int i = 0; i < q.Length - 1; i++)
            //{
            //    var actualPerson = q[i];
            //    var expectedPerson = (i + 1);
            //    var diff = actualPerson - expectedPerson;
            //    if (diff > 2)
            //    {
            //        Console.WriteLine(NotPossible);
            //        return;
            //    }

            //    for (int j = i + 1; j <= Math.Min(q.Length - 1, actualPerson + 2); j++)
            //    {
            //        if (actualPerson > q[j]) numberOfBribes++;
            //    }
            //}

            Console.WriteLine(numberOfBribes);
        }
    }
}
