namespace LeetCode.Challenges.Medium
{
    /// <summary>
    /// Given an array nums with n objects colored red, white, or blue, sort them in-place so that objects of the same color are adjacent, with the colors in the order red, white, and blue.
    /// We will use the integers 0, 1, and 2 to represent the color red, white, and blue, respectively.
    /// You must solve this problem without using the library's sort function.
    /// </summary>
    public class SortColors : ILeetCode
    {
        public void Run(int[] nums)
        {
            QuickSort(nums, 0, nums.Length - 1);
        }

        private void QuickSort(int[] nums, int start, int end)
        {
            if (start < end)
            {
                var pivotIndex = Partition(nums, start, end);

                QuickSort(nums, start, pivotIndex - 1);
                QuickSort(nums, pivotIndex + 1, end);
            }
        }

        private static int Partition(int[] nums, int start, int end)
        {
            var pivot = nums[end];
            var i = start - 1;

            for (int j = start; j < end; j++)
            {
                if (nums[j] <= pivot)
                {
                    i++;

                    var tmp1 = nums[i];
                    nums[i] = nums[j];
                    nums[j] = tmp1;
                }
            }

            var tmp2 = nums[i + 1];
            nums[i + 1] = nums[end];
            nums[end] = tmp2;

            return i + 1;
        }
    }
}