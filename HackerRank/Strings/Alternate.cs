using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HackerRank.Strings
{
    public static class Alternate
    {
        public static int LongestLength(string s)
        {
            var chars = s.GroupBy(c => c).OrderByDescending(c => c.Count()).ToList();
            if (chars.Count < 2)
                return default;

            var alternateStrings = new List<string>();
            for (int i = 0; i < chars.Count - 1; i++)
            {
                for (int j = i + 1; j < chars.Count; j++)
                {
                    var alternateString = new Regex($"[^{chars.ElementAt(i).Key}{chars.ElementAt(j).Key}]")
                        .Replace(s, string.Empty);
                    if (IsValidAlternatingString(alternateString))
                        alternateStrings.Add(alternateString);
                }
            }
            return alternateStrings.Any() ? alternateStrings.Max(a => a.Length) : 0;


            bool IsValidAlternatingString(string s)
            {
                for (int i = 0; i < s.Length - 1; i++)
                {
                    if (s.ElementAt(i) == s.ElementAt(i + 1))
                        return false;
                }

                return true;
            }
        }
    }
}
