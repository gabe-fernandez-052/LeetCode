namespace LeetCode.Challenges.Easy
{
    /// <summary>
    /// Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
    /// </summary>
    public class ContainsDuplicate : ILeetCode
    {
        public bool Run(int[] nums)
        {
            var hashSet = new HashSet<int>(nums);
            return hashSet.Count == nums.Length;
        }
    }
}