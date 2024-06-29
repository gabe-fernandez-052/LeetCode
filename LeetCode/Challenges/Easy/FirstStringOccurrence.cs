namespace LeetCode.Challenges.Easy
{
    /// <summary>
    /// Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
    /// </summary>
    public class FirstStringOccurrence : ILeetCode
    {
        public int Run(string haystack, string needle)
        {
            if (haystack == needle)
            {
                return 0;
            }

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (haystack.Substring(i, needle.Length) == needle)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}