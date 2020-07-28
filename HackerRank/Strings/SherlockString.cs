using System.Linq;

namespace HackerRank.Strings
{
    public static class SherlockString
    {
        public static string IsValid(string s)
        {
            var charCount = s.GroupBy(c => c).Select(c => c.Count());

            var isValid = charCount.Distinct().Count() == 1;
            if (!isValid && charCount.Distinct().Count() == 2)
            {
                var distinctCounts = charCount.GroupBy(count => count).Select(c => c.Count());
                isValid = distinctCounts.Min() == 1 && 
                    (charCount.Min() == charCount.Max() - 1 || 
                    (charCount.Min() == 1 && charCount.Count(c => c == charCount.Min()) == 1));
            }

            return isValid ? "YES" : "NO";
        }
    }
}
