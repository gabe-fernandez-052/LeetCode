namespace LeetCode.Challenges.Medium
{
    /// <summary>
    /// There is an integer array nums sorted in ascending order (with distinct values).
    /// Prior to being passed to your function, nums is possibly rotated at an unknown pivot index k(1 <= k<nums.length) such that the resulting array is [nums[k], nums[k + 1], ..., nums[n - 1], nums[0], nums[1], ..., nums[k - 1]] (0-indexed).
    /// For example, [0, 1, 2, 4, 5, 6, 7] might be rotated at pivot index 3 and become[4, 5, 6, 7, 0, 1, 2].
    /// Given the array nums after the possible rotation and an integer target, return the index of target if it is in nums, or -1 if it is not in nums.
    /// </summary>
    public class SearchInRotatedSortedArray : ILeetCode
    {
        public int Run(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;
            while (left < right)
            {
                var middle = (left + right) / 2;

                if (nums[middle] > nums[right])
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle;
                }
            }

            var middleIndex = left; //could also be right since they are equal

            if (middleIndex == 0)
            {
                left = 0;
                right = nums.Length - 1;
            }
            else if (nums[0] <= target && target <= nums[middleIndex - 1])
            {
                left = 0;
                right = middleIndex - 1;
            }
            else
            {
                left = middleIndex;
                right = nums.Length - 1;
            }

            while (left <= right)
            {
                var middle = (left + right) / 2;

                if (nums[middle] == target)
                {
                    return middle;
                }

                if (nums[middle] < target)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            return -1;
        }
    }
}