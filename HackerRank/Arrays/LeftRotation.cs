using System.Linq;

namespace HackerRank.Arrays
{
    public class LeftRotation
    {
        public static int[] Get(int[] a, int d)
        {
            var numberOfShifts = d < a.Length ? d : a.Length % d;
            return a.Skip(numberOfShifts).Concat(a.Take(numberOfShifts)).ToArray();
        }
    }
}
