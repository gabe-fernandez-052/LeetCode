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
            var nums1Pointer = m - 1;
            var nums2Pointer = n - 1;
            var endNums1Pointer = nums1.Length - 1;

            while (nums2Pointer >= 0)
            {
                if (nums1Pointer >= 0 && nums1[nums1Pointer] > nums2[nums2Pointer])
                {
                    nums1[endNums1Pointer] = nums1[nums1Pointer];
                    nums1Pointer--;
                }
                else
                {
                    nums1[endNums1Pointer] = nums2[nums2Pointer];
                    nums2Pointer--;
                }
                endNums1Pointer--;
            }
        }
    }
}