namespace LeetCode.Challenges
{
    /// <summary>
    /// You are climbing a staircase. It takes n steps to reach the top.
    /// Each time you can either climb 1 or 2 steps.In how many distinct ways can you climb to the top?
    /// </summary>
    public class ClimbingStairs : ILeetCode
    {
        public int Run(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            if (n == 2)
            {
                return 2;
            }

            var previousPrevious = 1;
            var previous = 2;
            var current = 0;

            for (int i = 3; i <= n; i++)
            {
                current = previousPrevious + previous;
                previousPrevious = previous;
                previous = current;
            }

            return current;
        }
    }
}