namespace LeetCode.Challenges
{
    /// <summary>
    /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// You can return the answer in any order.
    /// var nums = new int[10] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 7 };
    /// var target = 11;
    /// </summary>
    public class TwoSum : ILeetCode
    {
        public int[] Run(int[] nums, int target)
        {
            for (var outer = 0; outer < nums.Length; outer++)
            {
                for (var inner = outer + 1; inner < nums.Length; inner++)
                {
                    if (nums[outer] + nums[inner] == target)
                    {
                        return [outer, inner];
                    }
                }
            }

            return [];
        }

        public int[] TwoPass(int[] nums, int target)
        {
            var dictIndices = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                dictIndices.TryAdd(nums[i], i);
            }

            int complement;

            for (var i = 0; i < nums.Length; i++)
            {
                complement = target - nums[i];

                if (dictIndices.ContainsKey(complement) && dictIndices[complement] != i)
                {
                    return [i, dictIndices[complement]];
                }
            }

            return [];
        }

        public int[] OnePass(int[] nums, int target)
        {
            var dictIndices = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var key = target - nums[i];

                if (dictIndices.TryGetValue(key, out int value))
                {
                    return [value, i];
                }

                dictIndices.TryAdd(nums[i], i);
            }

            return [];
        }
    }
}