using System.Linq;
using System.Text.RegularExpressions;

namespace HackerRank.Strings
{
    public static class MarsExploration
    {
        private static Regex AlteredPattern =>
            new Regex("[^sos]", RegexOptions.IgnoreCase | RegexOptions.Compiled);

        public static int AlteredCount(string s)
        {
            if (string.IsNullOrEmpty(s)) return default;

            var count = 0;
            for (int i = 0; i < s.Length - 2; i += 3)
                count += AlteredChars(s.Substring(i, 3));
            return count;
            return AlteredPattern.Matches(s).Count;


            static int AlteredChars(string s) =>
                s.ToLower().Zip("sos", (o, e) => o - e != 0 ? 1 : 0).Sum();
        }
    }
}
