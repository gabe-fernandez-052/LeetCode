namespace LeetCode.Challenges.Medium
{
    /// <summary>
    /// Given an array nums of distinct integers, return all the possible permutations. You can return the answer in any order.
    /// </summary>
    public class Permutations : ILeetCode
    {
        private List<List<int>> _results = new();
        private List<int> _solution = new();

        public List<List<int>> Run(int[] nums)
        {
            BackTrack(nums);
            return _results;
        }

        /// <summary>
        /// DFS
        /// </summary>
        /// <param name="nums"></param>
        private void BackTrack(int[] nums)
        {
            if (_solution.Count == nums.Length)
            {
                _results.Add(new List<int>(_solution));
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (!_solution.Contains(nums[i]))
                {
                    _solution.Add(nums[i]);
                    BackTrack(nums);
                    _solution.Remove(nums[i]);
                }
            }
        }
    }
}