namespace LeetCode.Challenges.Medium
{
    /// <summary>
    /// Given two integers dividend and divisor, divide two integers without using multiplication, division, and mod operator.
    /// The integer division should truncate toward zero, which means losing its fractional part.For example, 8.345 would be truncated to 8, and -2.7335 would be truncated to -2.
    /// Return the quotient after dividing dividend by divisor.
    /// </summary>
    public class DivideTwoIntegers : ILeetCode
    {
        public int Run(int dividend, int divisor)
        {
            if (divisor == dividend)
            {
                return 1;
            }

            if (divisor == 1)
            {
                return dividend;
            }

            if (divisor == -1)
            {
                if (dividend == int.MinValue)
                {
                    return int.MaxValue;
                }
                else
                {
                    return -dividend;
                }
            }

            var result = 0;

            // If both are positive
            if (dividend > 0 && divisor > 0)
            {
                while (dividend >= 0)
                {
                    if (int.MaxValue - 1 == result)
                    {
                        return int.MaxValue;
                    }

                    result++;
                    dividend -= divisor;
                }

                result--;
            }
            else if (dividend < 0 && divisor < 0)
            { // If both are negative
                while (dividend <= 0)
                {
                    if (int.MaxValue - 1 == result)
                    {
                        return int.MaxValue;
                    }

                    result++;
                    dividend -= divisor;
                }

                result--;
            }
            else if (dividend < 0 && divisor > 0)
            { // If dividend is negative
                while (dividend <= 0)
                {
                    if (int.MinValue + 1 == result)
                    {
                        return int.MinValue;
                    }

                    result--;
                    dividend += divisor;
                }

                result++;
            }
            else if (dividend > 0 && divisor < 0)
            { // If divisor is negative
                while (dividend >= 0)
                {
                    if (int.MinValue + 1 == result)
                    {
                        return int.MinValue;
                    }

                    result--;
                    dividend += divisor;
                }

                result++;
            }

            return result;
        }
    }
}