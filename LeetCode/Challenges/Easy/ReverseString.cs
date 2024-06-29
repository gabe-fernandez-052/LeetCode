namespace LeetCode.Challenges.Easy
{
    /// <summary>
    /// Write a function that reverses a string. The input string is given as an array of characters s.
    /// You must do this by modifying the input array in-place
    /// </summary>
    public class ReverseString : ILeetCode
    {
        public void Run(char[] s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                var placeHolder = s[i];

                s[i] = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = placeHolder;
            }
        }
    }
}