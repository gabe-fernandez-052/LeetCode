namespace LeetCode.Challenges.Medium
{
    /// <summary>
    /// Given an array of integers nums sorted in non-decreasing order, find the starting and ending position of a given target value.
    /// If target is not found in the array, return [-1, -1].
    /// You must write an algorithm with O(log n) runtime complexity.
    /// </summary>
    public class FindFirstAndLast : ILeetCode
    {
        public int[] Run(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;
            var mostLeftIndex = -1;

            while (left <= right)
            {
                var middle = (left + right) / 2;

                if (nums[middle] < target)
                {
                    left = middle + 1;
                }
                else if (target < nums[middle])
                {
                    right = middle - 1;
                }
                else
                {
                    mostLeftIndex = middle;
                    right = middle - 1;
                }
            }

            left = 0;
            right = nums.Length - 1;
            var mostRightIndex = -1;

            while (left <= right)
            {
                var middle = (left + right) / 2;

                if (nums[middle] < target)
                {
                    left = middle + 1;
                }
                else if (target < nums[middle])
                {
                    right = middle - 1;
                }
                else
                {
                    mostRightIndex = middle;
                    left = middle + 1;
                }
            }

            return [mostLeftIndex, mostRightIndex];
        }
    }
}