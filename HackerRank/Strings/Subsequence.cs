namespace HackerRank.Strings
{
    public static class Subsequence
    {
        public static string HasSubsequence(string s, string word = "hackerrank")
        {
            var found = true;
            var stringIndex = 0;
            foreach (var c in word)
            {
                var charIndex = s.Substring(stringIndex).IndexOf(c);
                if (charIndex == -1)
                {
                    found = false;
                    break;
                }
                stringIndex += charIndex + 1;
            }

            return found ? "YES" : "NO";
        }
    }
}
