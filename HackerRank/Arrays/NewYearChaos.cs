using System;
using System.Linq;

namespace HackerRank.Arrays
{
    public class NewYearChaos
    {
        private const string NotPossible = "Too chaotic";

        public static void MinimumBribes(int[] q)
        {
            var numberOfBribes = 0;
            //for (int i = 0; i < q.Length; i++)
            //{
            //    var person = q.ElementAt(i);
            //    var currentPosition = i + 1;
            //    if (person > (currentPosition + 2))
            //    {
            //        Console.WriteLine(NotPossible);
            //        return;
            //    }
            //    else if (person > currentPosition)
            //        numberOfBribes += person - currentPosition;
            //}
            //Console.WriteLine(numberOfBribes);

            var initialQueue = Enumerable.Range(1, q.Length).ToList();
            // TODO: Improve the code, it's failing for certain unit tests either due to 
            // time-out or because of an exception.
            for (int i = 0; i < initialQueue.Count; i++)
            {
                var actualPersonInPosition = q.ElementAt(i);
                if (initialQueue.ElementAt(i) != actualPersonInPosition)
                {
                    var diff = initialQueue.IndexOf(actualPersonInPosition) - i;
                    if (diff > 0 && diff < 3)
                    {
                        numberOfBribes += diff;
                        var temp = initialQueue.Skip(i).Take(diff).ToArray();
                        initialQueue.RemoveRange(i, diff);
                        initialQueue.InsertRange(i + 1, temp);

                        //for (int j = diff; j > 0; j--)
                        //{
                        //    var temp = initialQueue[i + j];
                        //    initialQueue[i + j] = initialQueue[i + j - 1];
                        //    initialQueue[i + j - 1] = temp;
                        //}
                    }
                }
            }

            Console.WriteLine(initialQueue.SequenceEqual(q) ? numberOfBribes.ToString() : NotPossible);
        }
    }
}
