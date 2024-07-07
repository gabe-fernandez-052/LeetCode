namespace LeetCode.Challenges.Medium
{
    /// <summary>
    /// Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
    /// Notice that the solution set must not contain duplicate triplets.
    /// </summary>
    public class ThreeSum : ILeetCode
    {
        public IList<IList<int>> Run(int[] nums)
        {
            var results = new List<IList<int>>();
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
                else
                {
                    dict[nums[i]] = i;
                }
            }

            var seen = new HashSet<string>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int complement = -nums[i] - nums[j];

                    if (dict.ContainsKey(complement) && dict[complement] > j)
                    {
                        var triplet = new List<int> { nums[i], nums[j], complement };
                        triplet.Sort();

                        var key = string.Join(",", triplet);

                        if (!seen.Contains(key))
                        {
                            results.Add(triplet);
                            seen.Add(key);
                        }
                    }
                }
            }

            return results;
        }
    }
}