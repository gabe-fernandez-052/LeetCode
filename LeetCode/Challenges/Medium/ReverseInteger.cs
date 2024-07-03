using System.Text;

namespace LeetCode.Challenges.Medium
{
    /// <summary>
    /// Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.
    /// Assume the environment does not allow you to store 64-bit integers(signed or unsigned).
    /// </summary>
    public class ReverseInteger : ILeetCode
    {
        public int Run(int x)
        {
            var negative = x < 0;
            var stringRepresentation = x.ToString();
            var reversedStringRep = new StringBuilder();

            for (int i = stringRepresentation.Length - 1; i >= 0; i--)
            {
                if (stringRepresentation[i] == '-')
                {
                    break;
                }

                reversedStringRep.Append(stringRepresentation[i]);
            }

            _ = int.TryParse(reversedStringRep.ToString(), out int reversedX);

            return negative ? reversedX * -1 : reversedX;
        }
    }
}