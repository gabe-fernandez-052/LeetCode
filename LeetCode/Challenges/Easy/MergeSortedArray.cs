namespace LeetCode.Challenges.Easy
{
    /// <summary>
    /// You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
    /// Merge nums1 and nums2 into a single array sorted in non-decreasing order.
    /// The final sorted array should not be returned by the function, but instead be stored inside the array nums1.
    /// To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.
    /// </summary>
    public class MergeSortedArray : ILeetCode
    {
        public void Run(int[] nums1, int m, int[] nums2, int n)
        {
            var pointer1 = m - 1;
            var pointer2 = n - 1;
            var lastIndex = m + n - 1;

            while (pointer2 >= 0)
            {
                if (pointer1 >= 0 && nums1[pointer1] > nums2[pointer2])
                {
                    nums1[lastIndex] = nums1[pointer1];
                    pointer1--;
                }
                else
                {
                    nums1[lastIndex] = nums2[pointer2];
                    pointer2--;
                }

                lastIndex--;
            }
        }
    }
}