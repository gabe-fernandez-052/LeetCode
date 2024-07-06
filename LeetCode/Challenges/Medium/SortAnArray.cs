namespace LeetCode.Challenges.Medium
{
    /// <summary>
    /// Given an array of integers nums, sort the array in ascending order and return it.
    /// You must solve the problem without using any built-in functions in O(nlog(n)) time complexity and with the smallest space complexity possible.
    /// </summary>
    public class SortAnArray : ILeetCode
    {
        public int[] Run(int[] nums)
        {
            return MergeSort(nums, 0, nums.Length - 1);
        }

        private int[] MergeSort(int[] arr, int leftPointer, int rightPointer)
        {
            if (leftPointer == rightPointer)
            {
                return arr;
            }

            var middlePointer = (leftPointer + rightPointer) / 2;

            MergeSort(arr, leftPointer, middlePointer);
            MergeSort(arr, middlePointer + 1, rightPointer);
            Merge(arr, leftPointer, middlePointer, rightPointer);

            return arr;
        }

        private void Merge(int[] arr, int left, int mid, int right)
        {
            var leftPointer = mid - left + 1;
            var rightPointer = right - mid;
            var leftArray = new int[leftPointer + 1]; // Adding 1 extra for infinity
            var rightArray = new int[rightPointer + 1]; // Adding 1 extra for infinity

            for (int i = 0; i < leftPointer; i++)
            {
                leftArray[i] = arr[left + i];
            }

            leftArray[leftPointer] = int.MaxValue; // Infinity

            for (int j = 0; j < rightPointer; j++)
            {
                rightArray[j] = arr[mid + 1 + j];
            }

            rightArray[rightPointer] = int.MaxValue; // Infinity

            var leftIndex = 0;
            var rightIndex = 0;

            for (int i = left; i <= right; i++)
            {
                if (leftArray[leftIndex] <= rightArray[rightIndex])
                {
                    arr[i] = leftArray[leftIndex++];
                }
                else
                {
                    arr[i] = rightArray[rightIndex++];
                }
            }
        }
    }
}