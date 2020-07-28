using System;
using System.Linq;
using System.Text;

namespace HackerRank.Strings
{
    public static class Palindrome
    {
        private const string Impossible = "-1";
        private const char HighestNumber = '9';


        public static string HighestValue(string s, int n, int k)
        {
            if (k <= 0)
                return IsPalindrome(s) ? s : Impossible;

            var palindrome = new StringBuilder(s);

            for (int rightIndex = 0; rightIndex < s.Length / 2; rightIndex++)
            {
                int leftIndex = s.Length - rightIndex - 1;
                var rightChar = s[rightIndex];
                var leftChar = s[leftIndex];

                if (k <= 0)
                    break;
                else if (leftChar != rightChar)
                {
                    leftChar = rightChar = new[] { leftChar, rightChar }.Max();
                    k--;
                }
                palindrome[rightIndex] = rightChar;
                palindrome[leftIndex] = leftChar;
            }

            if (k > 0)
            {
                for (int rightIndex = 0; rightIndex <= s.Length / 2; rightIndex++)
                {
                    int leftIndex = s.Length - rightIndex - 1;
                    var rightChar = palindrome[rightIndex];
                    var leftChar = palindrome[leftIndex];

                    if (k <= 0) break;
                    var newK = k;
                    if (leftChar < HighestNumber && leftChar == s[leftIndex]) newK--;
                    if (rightChar < HighestNumber && rightChar == s[rightIndex] && rightIndex != leftIndex) newK--;

                    if (newK >= 0)
                    {
                        k = newK;
                        palindrome[rightIndex] = palindrome[leftIndex] = HighestNumber;
                    }
                }
            }

            return IsPalindrome(palindrome.ToString()) ? palindrome.ToString() : Impossible;
        }

        private static bool IsPalindrome(string s) => s.Equals(string.Join("", s.Reverse()));
    }
}
