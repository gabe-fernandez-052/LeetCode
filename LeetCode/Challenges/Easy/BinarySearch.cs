namespace LeetCode.Challenges.Easy
{
    /// <summary>
    /// Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums.
    /// If target exists, then return its index. Otherwise, return -1.
    /// You must write an algorithm with O(log n) runtime complexity.
    /// </summary>
    public class BinarySearch : ILeetCode
    {
        public int Run(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                var middle = (left + right) / 2;

                if (nums[middle] == target)
                {
                    return middle;
                }
                else if (nums[middle] < target)
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