using System;
using System.Linq;
using System.Text;

namespace HackerRank.Strings
{
    // TODO: It doesn't cover 5 test cases; complete the alogorithem to have creating a palindrome in priority.
    // 2180212 2

    public static class Palindrome
    {
        private const string Impossible = "-1";
        private const char HighestNumber = '9';


        public static string HighestValue(string s, int n, int k)
        {
            if (k <= 0)
                return IsPalindrome(s) ? s : Impossible;

            //var minNeededSwapsCount = (s.Substring(0, s.Length / 2))
            //    .Zip(s.Substring((s.Length % 2 == 0 ? s.Length : s.Length + 1) / 2), (r, l) => r != l ? 1 : 0)
            //    .Sum();

            var palindrome = new StringBuilder(s);
            for (int rightIndex = 0; rightIndex <= s.Length / 2; rightIndex++)
            {
                int leftIndex = s.Length - rightIndex - 1;
                var rightChar = s[rightIndex];
                var leftChar = s[leftIndex];

                if (k <= 0)
                    break;
                else if (k == 1)
                {
                    if (rightChar != leftChar)
                    {
                        leftChar = rightChar = new[] { leftChar, rightChar, }.Max();
                        k--;
                    }
                    else if (rightIndex == leftIndex && rightChar < HighestNumber)
                    {
                        rightChar = leftChar = HighestNumber;
                        k--;
                    }
                }
                else
                {
                    if (leftChar < HighestNumber) k--;
                    if (rightChar < HighestNumber) k--;

                    leftChar = rightChar = HighestNumber;
                }

                palindrome[rightIndex] = rightChar;
                palindrome[leftIndex] = leftChar;
            }

            return IsPalindrome(palindrome.ToString()) ? palindrome.ToString() : Impossible;
        }

        private static bool IsPalindrome(string s) => s.Equals(string.Join("", s.Reverse()));
    }
}
