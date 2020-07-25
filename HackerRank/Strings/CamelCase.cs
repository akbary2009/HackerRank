using System.Linq;

namespace HackerRank.Strings
{
    public static class CamelCase
    {
        public static int WordsCount(string s)
        {
            if (string.IsNullOrEmpty(s)) return default;

            return s.Count(c => char.IsUpper(c)) + 1;
        }
    }
}
