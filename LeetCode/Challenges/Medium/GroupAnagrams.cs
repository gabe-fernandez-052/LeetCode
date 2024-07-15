namespace LeetCode.Challenges.Medium
{
    /// <summary>
    /// Given an array of strings strs, group the anagrams together. You can return the answer in any order.
    /// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
    /// </summary>
    public class GroupAnagrams : ILeetCode
    {
        public List<List<string>> Run(string[] strs)
        {
            var dictionary = new Dictionary<string, List<string>>();

            foreach (var str in strs)
            {
                var charArray = str.ToCharArray();

                for (int i = 0; i < charArray.Length - 1; i++)
                {
                    for (int j = 0; j < charArray.Length - i - 1; j++)
                    {
                        if (charArray[j] > charArray[j + 1])
                        {
                            var tmp = charArray[j];
                            charArray[j] = charArray[j + 1];
                            charArray[j + 1] = tmp;
                        }
                    }
                }

                var sortedString = new string(charArray);

                if (dictionary.TryGetValue(sortedString, out List<string>? value))
                {
                    value.Add(str);
                }
                else
                {
                    dictionary[sortedString] = [str];
                }
            }

            var results = new List<List<string>>();

            foreach (var kvp in dictionary)
            {
                results.Add(kvp.Value);
            }

            return results;
        }
    }
}