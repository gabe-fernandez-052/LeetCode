namespace LeetCode.Challenges.Easy
{
    /// <summary>
    /// Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
    /// Note that you must do this in-place without making a copy of the array.
    /// </summary>
    public class MoveZeros : ILeetCode
    {
        public void Run(int[] nums)
        {
            //[0,1,0,3,12]
            for (int i = 0; i < nums.Length - 1; i++)
            {
                var pointer = i + 1;

                if (nums[i] == 0)
                {
                    while (nums[pointer] == 0)
                    {
                        if (pointer + 1 == nums.Length)
                        {
                            break;
                        }

                        pointer++;
                    }

                    nums[i] = nums[pointer];
                    nums[pointer] = 0;
                }
            }
        }

        public void QuickSort(int[] nums)
        {
            int left = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                if (nums[right] != 0)
                {
                    (nums[left], nums[right]) = (nums[right], nums[left]);
                    left++;
                }
            }
        }
    }
}