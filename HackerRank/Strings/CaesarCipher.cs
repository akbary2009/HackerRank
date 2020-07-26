using System;
using System.Linq;

namespace HackerRank.Strings
{
    public static class CaesarCipher
    {
        public static string Encrypt(string s, int k)
        {
            if (string.IsNullOrEmpty(s) || k <= 0)
                return s;

            return string.Join("", s.Select(c => char.IsLetter(c) ? encryptChar(c) : c));


            char encryptChar(char c)
            {
                var n = 'z' - char.ToLower(c);
                var shiftsCount = k % 26;
                return shiftsCount > n
                    ? Convert.ToChar((char.IsLower(c) ? 'a' : 'A') + (shiftsCount - n - 1))
                    : Convert.ToChar(c + shiftsCount);
            }
        }
    }
}
