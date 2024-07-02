using System.Text;

namespace LeetCode.Challenges.Medium
{
    public class LongestPalindromeSubstring : ILeetCode
    {
        public string Run(string s)
        {
            var results = new StringBuilder();

            if (!string.IsNullOrEmpty(s))
            {
                results.Append(s[0].ToString());
                var resultsLength = 1;

                for (int i = 0; i < s.Length; i++)
                {
                    var leftPointer = i;
                    var rightPointer = i;

                    while (leftPointer >= 0 && rightPointer < s.Length && s[leftPointer] == s[rightPointer])
                    {
                        if (rightPointer - leftPointer + 1 > resultsLength)
                        {
                            results.Clear();
                            results.Append(s.Substring(leftPointer, rightPointer - leftPointer + 1));
                            resultsLength = rightPointer - leftPointer + 1;
                        }

                        leftPointer--;
                        rightPointer++;
                    }

                    leftPointer = i;
                    rightPointer = i + 1;

                    while (leftPointer >= 0 && rightPointer < s.Length && s[leftPointer] == s[rightPointer])
                    {
                        if (rightPointer - leftPointer + 1 > resultsLength)
                        {
                            results.Clear();
                            results.Append(s.Substring(leftPointer, rightPointer - leftPointer + 1));
                            resultsLength = rightPointer - leftPointer + 1;
                        }

                        leftPointer--;
                        rightPointer++;
                    }
                }
            }

            return results.ToString();
        }
    }
}