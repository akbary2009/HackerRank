using System;
using System.Linq;

namespace HackerRank.Warmup
{
    public class RepeatedString
    {
        public static long GetNumberOfOccurrences(string s, long n)
            => GetNumberOfOccurrences(s, n, 'a');

        private static long GetNumberOfOccurrences(string s, long n, char letter)
        {
            Func<char, bool> predicate = character => character == letter;

            var occurrencesInPrefixString = s.Where(predicate).LongCount();
            long remainder;
            var numberOfSubstrings = Math.DivRem(n, s.Length, out remainder);
            var occurencesInRemainder = s.Substring(0, (int)remainder).Where(predicate).LongCount();

            return (occurrencesInPrefixString * numberOfSubstrings) + occurencesInRemainder;
        }
    }
}
