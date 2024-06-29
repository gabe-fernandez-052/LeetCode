using System.Text;

namespace LeetCode.Challenges.Easy
{
    /// <summary>
    /// A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward.
    /// Alphanumeric characters include letters and numbers.
    /// Given a string s, return true if it is a palindrome, or false otherwise.
    /// </summary>
    public class ValidPalindrome : ILeetCode
    {
        public bool Run(string s)
        {
            var alphaNumeric = new StringBuilder();

            foreach (char c in s)
            {
                if ('A' <= c && c <= 'Z' || 'a' <= c && c <= 'z' || '0' <= c && c <= '9')
                {
                    alphaNumeric.Append(c);
                }
            }

            var array = alphaNumeric.ToString().ToLower().ToCharArray();

            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[array.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}