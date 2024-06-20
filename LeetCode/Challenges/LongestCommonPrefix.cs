using System.Text;

namespace LeetCode.Challenges
{
    public class LongestCommonPrefix : ILeetCode
    {
        /// <summary>
        /// Write a function to find the longest common prefix string amongst an array of strings.
        /// If there is no common prefix, return an empty string "".
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public string Run(string[] strs)
        {
            if (strs.Length == 0)
            {
                return string.Empty;
            }

            var sb = new StringBuilder();

            for (int i = 0; i < strs[0].Length; i++) //f l o w e r
            {
                for (int j = 1; j < strs.Length; j++) //flow //flight
                {
                    //out of bounds
                    //letter does not match first character
                    if (i >= strs[j].Length || strs[0][i] != strs[j][i])
                    {
                        return sb.ToString();
                    }
                }

                sb.Append(strs[0][i]);
            }

            return sb.ToString();
        }
    }
}