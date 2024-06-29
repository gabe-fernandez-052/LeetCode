namespace LeetCode.Challenges.Easy
{
    /// <summary>
    /// Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.
    /// </summary>
    public class FirstUniqueCharacter : ILeetCode
    {
        public int Run(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return -1;
            }

            for (int outer = 0; outer < s.Length; outer++)
            {
                var unique = true;

                for (int inner = 0; inner < s.Length; inner++)
                {
                    if (outer != inner)
                    {
                        if (s[outer] == s[inner])
                        {
                            unique = false;
                            break;
                        }
                    }
                }

                if (unique)
                {
                    return outer;
                }
            }

            return -1;
        }
    }
}