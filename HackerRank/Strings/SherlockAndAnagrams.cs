using System.Linq;

namespace HackerRank.Strings
{
    public static class SherlockAndAnagrams
    {
        public static int SubsetCount(string s)
        {
            var count = 0;
            for (int length = 1; length < s.Length; length++)
            {
                for (int firstIndex = 0; firstIndex < s.Length - length; firstIndex++)
                {
                    for (int secondIndex = firstIndex + 1; secondIndex <= s.Length - length; secondIndex++)
                    {
                        var firstString = s.Substring(firstIndex, length);
                        var secondString = s.Substring(secondIndex, length);
                        if (IsAnagram(firstString, secondString))
                            count++;
                    }
                }
            }
            return count;


            bool IsAnagram(string a, string b)
            {
                var counts = Enumerable.Repeat(0, 26).ToList();
                for (int i = 0; i < a.Length; i++)
                {
                    counts[a[i] - 'a']++;
                    counts[b[i] - 'a']--;
                }
                return counts.All(c => c == 0);
            }
        }
    }
}
