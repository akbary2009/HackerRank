using System.Collections.Generic;

namespace HackerRank.Arrays
{
    public static class MinimumSwaps
    {
        public static int Get(int[] arr)
        {
            if (arr?.Length <= 1)
                return 0;

            var swapCounter = 0;
            var indexDictionary = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                indexDictionary.Add(arr[i], i);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                var value = arr[i];
                var correctValue = i + 1;
                if (value != correctValue)
                {
                    int swapIndex = indexDictionary[correctValue];
                    indexDictionary[value] = swapIndex;
                    arr[swapIndex] = value;
                    arr[i] = correctValue;
                    swapCounter++;
                }
            }
            return swapCounter;
        }
    }
}
