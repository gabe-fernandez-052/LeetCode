using System.Text;

namespace LeetCode.Challenges.Medium
{
    /// <summary>
    /// Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.
    /// </summary>
    public class GenerateParentheses : ILeetCode
    {
        private StringBuilder _solution = new();
        private List<string> _results = new();

        public IList<string> Run(int n)
        {
            BackTrack(n, 0, 0);
            return _results;
        }

        private void BackTrack(int n, int open, int close)
        {
            if (_solution.Length == 2 * n)
            {
                _results.Add(_solution.ToString());
                return;
            }

            if (open < n)
            {
                _solution.Append("(");
                BackTrack(n, open + 1, close);
                _solution.Length--;
            }

            if (open > close)
            {
                _solution.Append(")");
                BackTrack(n, open, close + 1);
                _solution.Length--;
            }
        }
    }
}