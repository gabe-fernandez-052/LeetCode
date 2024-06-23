namespace LeetCode.Challenges
{
    /// <summary>
    /// Given a non-negative integer x, return the square root of x rounded down to the nearest integer. The returned integer should be non-negative as well.
    /// You must not use any built-in exponent function or operator.
    /// </summary>
    public class Sqrt : ILeetCode
    {
        public int Run(int x)
        {
            if (x == 0)
            {
                return 0;
            }

            if (x == 1)
            {
                return x;
            }

            for (double i = 0; i <= x; i++)
            {
                if (i * i > x)
                {
                    return Convert.ToInt32(i - 1);
                }
            }

            return 0;
        }
    }
}