namespace LeetCode.Challenges.Easy
{
    /// <summary>
    /// Given two strings s and t, return true if t is an anagram of s, and false otherwise.
    /// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
    /// </summary>
    public class ValidAnagram : ILeetCode
    {
        public bool Run(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            var sDictionary = new Dictionary<char, int>();
            var tDictionary = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (sDictionary.ContainsKey(c))
                {
                    sDictionary[c]++;
                }
                else
                {
                    sDictionary.Add(c, 1);
                }
            }

            foreach (char c in t)
            {
                if (tDictionary.ContainsKey(c))
                {
                    tDictionary[c]++;
                }
                else
                {
                    tDictionary.Add(c, 1);
                }
            }

            foreach (var kvp in sDictionary)
            {
                if (!tDictionary.ContainsKey(kvp.Key))
                {
                    return false;
                }
                else if (tDictionary[kvp.Key] != kvp.Value)
                {
                    return false;
                }
            }

            return true;
        }
    }
}