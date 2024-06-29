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
            var parentheses = s.ToArray(); //([])

            if (parentheses.Length % 2 != 0)
            {
                return false;
            }

            var validPairs = new Dictionary<string, string>()
            {
                { "(",")" },
                { "[","]" },
                { "{","}" },
            };

            var result = true;
            var openOptions = new Stack<string>();

            //iterate over individual parentheses
            for (int i = 0; i < parentheses.Length; i++)
            {
                //check if parentheses is an open option
                if (validPairs.ContainsKey(parentheses[i].ToString()))
                {
                    openOptions.Push(parentheses[i].ToString());
                }
                else
                {
                    if (openOptions.Count == 0)
                    {
                        return false;
                    }

                    foreach (var openOption in openOptions)
                    {
                        //next value is the closing for the open option
                        if (validPairs[openOption] == parentheses[i].ToString())
                        {
                            openOptions.Pop();
                            break;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            if (openOptions.Count > 0)
            {
                result = false;
            }

            return result;
        }
    }
}