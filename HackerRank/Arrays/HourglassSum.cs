using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Arrays
{
    public class HourglassSum
    {
        public static int GetMaximumSum(int[][] arr)
        {
            return GetHourglassSum(arr).Max();
        }

        private static IEnumerable<int> GetHourglassSum(int[][] arr)
        {
            for (int rowIndex = 0; rowIndex < arr.Length - 2; rowIndex++)
            {
                var firstRow = arr.ElementAt(rowIndex);
                var secondRow = arr.ElementAt(rowIndex + 1);
                var thirdRow = arr.ElementAt(rowIndex + 2);

                for (int columnIndex = 0; columnIndex < firstRow.Length - 2; columnIndex++)
                {
                    var firstRowVals = firstRow.Skip(columnIndex).Take(3);
                    var secondRowVals = secondRow.Skip(columnIndex + 1).Take(1);
                    var thirdRowVals = thirdRow.Skip(columnIndex).Take(3);

                    yield return firstRowVals.Sum() + secondRowVals.Sum() + thirdRowVals.Sum();
                }
            }
        }
    }
}
