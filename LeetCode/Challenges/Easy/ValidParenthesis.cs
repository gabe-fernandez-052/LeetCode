namespace LeetCode.Challenges.Easy
{
    /// <summary>
    /// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
    /// An input string is valid if:
    /// Open brackets must be closed by the same type of brackets.
    /// Open brackets must be closed in the correct order.
    /// Every close bracket has a corresponding open bracket of the same type.
    /// </summary>
    public class ValidParenthesis : ILeetCode
    {
        public bool Run(string s)
        {
            if (s.Length % 2 != 0)
            {
                return false;
            }

            var closedParenStack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(')
                {
                    closedParenStack.Push(')');
                    continue;
                }

                if (c == '[')
                {
                    closedParenStack.Push(']');
                    continue;
                }

                if (c == '{')
                {
                    closedParenStack.Push('}');
                    continue;
                }

                if (closedParenStack.Count == 0 || c != closedParenStack.Pop())
                {
                    return false;
                }
            }

            return closedParenStack.Count == 0;
        }
    }
}