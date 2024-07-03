namespace LeetCode.Challenges.Medium
{
    /// <summary>
    /// Implement the myAtoi(string s) function, which converts a string to a 32-bit signed integer.
    /// The algorithm for myAtoi(string s) is as follows:
    /// Whitespace: Ignore any leading whitespace(" ").
    /// Signedness: Determine the sign by checking if the next character is '-' or '+', assuming positivity is neither present.
    /// Conversion: Read the integer by skipping leading zeros until a non-digit character is encountered or the end of the string is reached.If no digits were read, then the result is 0.
    /// Rounding: If the integer is out of the 32-bit signed integer range [-231, 231 - 1], then round the integer to remain in the range. Specifically, integers less than -231 should be rounded to -231, and integers greater than 231 - 1 should be rounded to 231 - 1.
    /// Return the integer as the final result.
    /// </summary>
    public class StringToInteger : ILeetCode
    {
        public int Run(string s)
        {
            long result = 0;
            var negative = false;

            var startingIndex = -1;
            var endingIndex = -1;

            for (int i = 0; i < s.Length; i++)
            {
                if (IsAlpha(s[i]))
                {
                    break;
                }

                if (s[i] == '-' && i + 1 != s.Length)
                {
                    if (IsNumeric(s[i + 1]) && startingIndex == -1)
                    {
                        startingIndex = i + 1;
                        negative = true;
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                var numeric = IsNumeric(s[i]);

                if (numeric)
                {
                    if (startingIndex == -1)
                    {
                        startingIndex = i;
                    }
                    else
                    {
                        endingIndex = i;
                    }
                }

                if (!numeric && startingIndex != -1)
                {
                    break;
                }
            }

            if (startingIndex != -1)
            {
                if (endingIndex == -1)
                {
                    result = Convert.ToInt64(s.Substring(startingIndex, 0));
                }
                else
                {
                    result = Convert.ToInt64(s.Substring(startingIndex, endingIndex - startingIndex + 1));
                }

                if (result != 0 && negative)
                {
                    result *= -1;
                }
            }

            if (result > int.MaxValue)
            {
                result = int.MaxValue;
            }
            else if (result < int.MinValue)
            {
                result = int.MinValue;
            }

            return Convert.ToInt32(result);
        }

        private bool IsAlpha(char c) => (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');

        private bool IsNumeric(char c) => c >= '0' && c <= '9';
    }
}