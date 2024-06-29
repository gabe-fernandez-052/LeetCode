namespace LeetCode.Challenges.Easy
{
    /// <summary>
    /// Given an array nums of size n, return the majority element.
    /// The majority element is the element that appears more than ⌊n / 2⌋ times.You may assume that the majority element always exists in the array.
    /// </summary>
    public class MajorityElement : ILeetCode
    {
        public int Run(int[] nums)
        {
            var dictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dictionary.ContainsKey(nums[i]))
                {
                    dictionary[nums[i]]++;
                }
                else
                {
                    dictionary.Add(nums[i], 1);
                }
            }

            var majorityElemenKey = 0;
            var majorityElementValue = 0;

            foreach (var kvp in dictionary)
            {
                if (majorityElementValue < kvp.Value)
                {
                    majorityElemenKey = kvp.Key;
                    majorityElementValue = kvp.Value;
                }
            }

            return majorityElemenKey;
        }
    }
}