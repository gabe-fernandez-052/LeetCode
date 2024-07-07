namespace LeetCode.Challenges.Medium
{
    /// <summary>
    /// Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent. Return the answer in any order.
    /// A mapping of digits to letters(just like on the telephone buttons) is given below.Note that 1 does not map to any letters.
    /// </summary>
    public class PhoneLetterCombinations : ILeetCode
    {
        private Dictionary<char, string> _dictionary = new()
        {
            { '2', "abc" },
            { '3', "def" },
            { '4', "ghi" },
            { '5', "jkl" },
            { '6', "mno" },
            { '7', "pqrs" },
            { '8', "tuv" },
            { '9', "wxyz" }
        };

        public IList<string> Run(string digits)
        {
            var results = new List<string>();

            if (string.IsNullOrWhiteSpace(digits))
            {
                return results;
            }

            BackTrack(string.Empty, digits, 0, results);
            return results;
        }

        private void BackTrack(string combination, string digits, int index, List<string> results)
        {
            if (index == digits.Length)
            {
                results.Add(combination);
                return;
            }
            foreach (char letter in _dictionary[digits[index]])
            {
                BackTrack(combination + letter, digits, index + 1, results);
            }
        }
    }
}