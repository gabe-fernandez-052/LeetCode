using System.Text;

namespace LeetCode.Challenges.Medium
{
    /// <summary>
    /// The count-and-say sequence is a sequence of digit strings defined by the recursive formula:
    /// countAndSay(1) = "1"
    /// countAndSay(n) is the run-length encoding of countAndSay(n - 1).
    /// Run-length encoding(RLE) is a string compression method that works by replacing consecutive identical characters(repeated 2 or more times) with the concatenation of the character and the number marking the count of the characters(length of the run). For example, to compress the string "3322251" we replace "33" with "23", replace "222" with "32", replace "5" with "15" and replace "1" with "11". Thus the compressed string becomes "23321511".
    /// Given a positive integer n, return the nth element of the count-and-say sequence.
    /// </summary>
    public class CountAndSay : ILeetCode
    {
        public string Run(int n)
        {
            if (n == 1)
            {
                return "1";
            }
            else
            {
                return Say(Run(n - 1));
            }
        }

        private string Say(string s)
        {
            var results = new StringBuilder();
            int currentCount = 0;

            for (int i = 0; i < s.Length - 1; i++)
            {
                currentCount++;

                if (s[i] != s[i + 1])
                {
                    results.Append(currentCount);
                    results.Append(s[i]);
                    currentCount = 0;
                }
            }

            currentCount++;
            results.Append(currentCount);
            results.Append(s[s.Length - 1]);

            return results.ToString();
        }
    }
}