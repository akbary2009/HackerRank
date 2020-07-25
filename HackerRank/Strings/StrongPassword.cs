using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Strings
{
    public static class StrongPassword
    {
        public static int NumberOfNeededChars(string password)
        {
            return Criteria.GetMinimumRequiredChars(password);
        }

        private static class Criteria
        {
            private static IEnumerable<char> _validSpecialCharacters => "!@#$%^&*()-+".Select(c => c);
            private const int MinimumLength = 6;

            public static int GetMinimumRequiredChars(string password)
            {
                return new[]
                {
                    LengthCriteria(password),
                    DigitsCriteria(password) + UpperCaseCriteria(password) + LowerCaseCriteria(password) + SpecialCharacterCriteria(password),
                }.Max();
            }

            private static int LengthCriteria(string password) => password.Length > MinimumLength ? 0 : MinimumLength - password.Length;

            private static int DigitsCriteria(string password) => password.Any(c => char.IsDigit(c)) ? 0 : 1;

            private static int UpperCaseCriteria(string password) => password.Any(c => char.IsUpper(c)) ? 0 : 1;

            private static int LowerCaseCriteria(string password) => password.Any(c => char.IsLower(c)) ? 0 : 1;

            private static int SpecialCharacterCriteria(string password) => password.Any(c => _validSpecialCharacters.Contains(c)) ? 0 : 1;
        }
    }
}
