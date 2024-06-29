namespace LeetCode.Challenges.Easy
{
    /// <summary>
    /// Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.
    /// </summary>
    public class MissingNumber : ILeetCode
    {
        public int Run(int[] nums)
        {
            var expectedSum = 0;

            for (int i = 1; i <= nums.Length; i++)
            {
                expectedSum += i;
            }

            var actualSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                actualSum += nums[i];
            }

            return expectedSum - actualSum;
        }
    }
}