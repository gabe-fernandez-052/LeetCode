namespace LeetCode
{
    /// <summary>
    /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// You can return the answer in any order.
    /// </summary>
    public class TwoSum : ILeetCode
    {
        public void BruteForce()
        {
            var target = 4;
            var nums = new int[] { 2, 1, 5, 3 };
            var indices = new int[2];

            for (var i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] + nums[i + 1] == target)
                {
                    indices[0] = i;
                    indices[1] = i + 1;

                    break;
                    //return indices;
                }
            }

            //return indices
        }

        public void Optimized()
        {
            var target = 4;
            var nums = new int[] { 2, 1, 5, 3 };
            var indices = new int[2];
            var dictIndices = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length - 1; i++)
            {
                var key = target - nums[i];

                if (dictIndices.TryGetValue(key, out int value))
                {
                    indices[0] = value;
                    indices[1] = i;

                    break;
                    //return indices
                }
                else
                {
                    dictIndices.Add(nums[i], i);
                }
            }

            //return indices
        }
    }
}