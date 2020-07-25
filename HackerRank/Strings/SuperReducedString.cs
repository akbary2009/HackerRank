using System;
using System.Linq;

namespace HackerRank.Strings
{
    public static class SuperReducedString
    {
        private const string Empty = "Empty String";

        public static string Get(string s)
        {
            int numberOfReductions;
            do
            {
                numberOfReductions = Reduce(ref s);
            } while (numberOfReductions > 0);

            return string.IsNullOrEmpty(s) ? Empty : s;


            static int Reduce(ref string s)
            {
                var count = 0;
                for (int i = 0; i < s.Length - 1; i++)
                {
                    var set = s.Substring(i, 2);
                    var areLowerCases = set.ToLower().Equals(set, StringComparison.Ordinal);
                    var areMatches = set.Last().Equals(set.First());
                    if (areLowerCases && areMatches)
                    {
                        count++;
                        s = s.Remove(i, 2);
                    }
                }
                return count;
            }
        }
    }
}
