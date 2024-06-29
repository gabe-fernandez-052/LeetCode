namespace LeetCode.Challenges.Easy
{
    /// <summary>
    /// Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
    /// You must implement a solution with a linear runtime complexity and use only constant extra space.
    /// </summary>
    public class SingleNumber : ILeetCode
    {
        public int Run(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                var pointer = 0;
                var unique = true;

                while (pointer < nums.Length)
                {
                    if (nums[i] == nums[pointer] && i != pointer)
                    {
                        unique = false;
                        break;
                    }
                    else
                    {
                        pointer++;
                    }
                }

                if (unique)
                {
                    return nums[i];
                }
            }

            return -1;
        }

        public int XOR(int[] nums)
        {
            int result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                result ^= nums[i];
            }

            return result;
        }
    }
}